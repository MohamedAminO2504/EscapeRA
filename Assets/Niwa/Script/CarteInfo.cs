using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarteInfo : MonoBehaviour
{
    public Text titre;
    public Text description;
    public Text info1;
    public Text info2;
    public Image image;
    public Image image2;

    public InfoData infoData;

    public void SetInfo(InfoData data){
        titre.text = data.titre;
        description.text = data.description;
        info1.text = data.info1;
        if(data.image){
            image.gameObject.SetActive(true);
            image.sprite = data.image;
        }else{
            image.gameObject.SetActive(false);
        }

        if(data.image2){
            image2.gameObject.SetActive(true);
            image2.sprite = data.image2;
        }else{
            image2.gameObject.SetActive(false);
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        if(infoData)
            SetInfo(infoData);
    }


}
