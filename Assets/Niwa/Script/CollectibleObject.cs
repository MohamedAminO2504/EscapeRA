using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleObject : MonoBehaviour
{   
    public string nom;
    public string description;
    public float sizeMultiplicateur = 1;
    private Vector3 position;
    private Vector3 scale;

    private Quaternion rotation;
    private Transform parent;

    private CartItemRA[] cartesItem;
    public bool inCard;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.localPosition;
        rotation = transform.localRotation;
        scale = transform.localScale;

        parent = transform.parent;
        cartesItem = FindObjectsOfType<CartItemRA>();

    }


    private void OnMouseDown() {
        UIManager uimanager = FindObjectOfType<UIManager>();
        uimanager.currentObject = this; 
        if(!inCard)
            uimanager.ShowChoixCarte();                
        else
            uimanager.ShowRangerCarte();
    }
    
    public void Ranger(){
        transform.parent = parent;

        transform.localPosition = position;
        transform.localRotation = rotation;

        transform.localScale = scale;
        inCard = false;
                UIManager uimanager = FindObjectOfType<UIManager>();

       uimanager.HideRangerCarte();
        uimanager.RestCartText();


    }
 
}
