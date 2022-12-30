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
    public CartItemRA[] cartesItem;

    public Text textUseCard1;
    public Text textUseCard2;
    public Text textUseCard3;

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
        if(textCard1)
            textCard1.text = currentObject.nom;
        if(textUseCard1)
        textUseCard1.text = currentObject.nom;
        cartesItem[0].SetCurrentObject(currentObject);
        HideChoixCarte();
    }
    public void SetCartItem2(){
        if(textCard2)
            textCard2.text = currentObject.nom;
        if(textUseCard2)
            textUseCard2.text = currentObject.nom;
        cartesItem[1].SetCurrentObject(currentObject);
        HideChoixCarte();

    }
    public void SetCartItem3(){
        if(textCard3)
            textCard3.text = currentObject.nom;
        if(textUseCard3)
        textUseCard3.text = currentObject.nom;
        cartesItem[2].SetCurrentObject(currentObject);
        HideChoixCarte();
    }

    public void RestCartText(){
        if(cartesItem[0].currentObject){
            if(textUseCard1)
                textUseCard1.text =  cartesItem[0].currentObject.nom;
            textCard1.text = cartesItem[0].currentObject.nom;
        }
        else{
            textCard1.text = "vide";
            if(textUseCard1)
                textUseCard1.text =  "vide";
        }

        if(cartesItem[1].currentObject){
            if(textUseCard2)
                textUseCard2.text =  cartesItem[1].currentObject.nom;
            textCard2.text = cartesItem[1].currentObject.nom;
        }
        else{
            textCard2.text = "vide";
            if(textUseCard2)
                textUseCard2.text =  "vide";
        }

        if(cartesItem[2].currentObject){
            if(textUseCard3)
                textUseCard3.text =  cartesItem[2].currentObject.nom;
            textCard3.text = cartesItem[2].currentObject.nom;
        }
        else{
            textCard3.text = "vide";
            if(textUseCard3)
                textUseCard3.text =  "vide";
        }


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
