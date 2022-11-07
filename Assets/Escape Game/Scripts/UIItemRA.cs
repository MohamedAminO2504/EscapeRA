using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIItemRA : MonoBehaviour
{

    public Text nameOfItem;

    private ItemRAManager manager;

    void Start() {
        manager = (ItemRAManager)FindObjectOfType(typeof(ItemRAManager));
    }

    public void DisplayName(string name){
        Debug.Log("DisplayName "+name);
        nameOfItem.text = name;
    }

}
