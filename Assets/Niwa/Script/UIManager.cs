using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject choixCarte;
        public GameObject rangerCarte;

    public Text textCard1;
    public Text textCard2;
    public Text textCard3;
    public CollectibleObject currentObject;
    private CartItemRA[] cartesItem;

    public void Ranger(){
        currentObject.Ranger();
    }
    
    public void ShowRangerCarte(){
        rangerCarte.SetActive(true);
    }
    public void HideRangerCarte(){
        rangerCarte.SetActive(false);
    }
    public void ShowChoixCarte(){
        choixCarte.SetActive(true);
    }
    public void HideChoixCarte(){
        choixCarte.SetActive(false);
    }

    public void SetCartItem1(){
        textCard1.text = currentObject.nom;
        cartesItem[0].SetCurrentObject(currentObject);
        HideChoixCarte();
    }
    public void SetCartItem2(){
        textCard2.text = currentObject.nom;
        cartesItem[1].SetCurrentObject(currentObject);
        HideChoixCarte();

    }
    public void SetCartItem3(){
        textCard3.text = currentObject.nom;
        cartesItem[2].SetCurrentObject(currentObject);
        HideChoixCarte();

    }

    // Start is called before the first frame update
    void Start()
    {
        cartesItem = FindObjectsOfType<CartItemRA>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
