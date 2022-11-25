using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartItemRA : MonoBehaviour
{

    public CollectibleObject currentObject;
    public GameObject conteneur;
    public List<Text> nomObjet;
    public List<Text> descriptionObjet;
    public Image img;

    void Start() {
        //conteneur.SetActive(false);
    }

    public void SetCurrentObject(CollectibleObject currentObject){
        if(this.currentObject != null)
            this.currentObject.Ranger();
        this.currentObject = currentObject;
        currentObject.inCard = true;
        DisplayObject();

    }

    public void DisplayObject(){
        if(currentObject == null)
            return;

        currentObject.gameObject.transform.SetParent(conteneur.transform);
        currentObject.transform.localPosition = new Vector3(0,0,0);
        currentObject.transform.localScale *= currentObject.sizeMultiplicateur;
        foreach (var item in nomObjet)
        {
            item.text = currentObject.nom;
        }
        foreach (var item in descriptionObjet)
        {
            item.text = currentObject.description;
        }

    }

}
