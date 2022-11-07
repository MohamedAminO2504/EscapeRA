using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CartItemRA : MonoBehaviour
{

    public List<ItemRA> items;
    public ItemRA current;

    private ItemRAManager manager;
    public GameObject uiCartItem;
    public Text description;

    void Start() {

        manager = (ItemRAManager)FindObjectOfType(typeof(ItemRAManager));
    }

    public void SetItem(ItemRA item){
        current = item;
        foreach (var i in items)
        {
            if(i.item == current.item){
                i.gameObject.SetActive(true);
            }else{
                i.gameObject.SetActive(false);
            }
        }
        //AfficheDescription();
    }

    public void AfficheDescription(){
        uiCartItem.SetActive(true);
        description.text = current.item.description;
    }
}
