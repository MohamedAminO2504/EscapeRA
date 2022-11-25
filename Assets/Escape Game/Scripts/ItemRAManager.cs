using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemRAManager : MonoBehaviour
{
    public ItemRA currentItem;
    public CartItemRA cartItem1;
    public UIItemRA ui;
    private CameraManager cameraManager;

    private void Start() {
       // cameraManager = (CameraManager)FindObjectOfType(typeof(CameraManager));
    }

    public void SetItemInCartItemRA1(){
       // cartItem1.SetItem(currentItem);
       //         cameraManager.SwitchViewToMainCamera(currentItem);

    }
    
    public void SetCurrentItem(ItemRA item){
      //  currentItem = item;
    }

    public void DisplayUIItem(){
       // ui.gameObject.SetActive(true);
       // ui.DisplayName(currentItem.name);
    }

    public void CancelAction(){
       // cameraManager.SwitchViewToMainCamera(currentItem);
       // currentItem = null;
       // ui.gameObject.SetActive(false);

    }

}
