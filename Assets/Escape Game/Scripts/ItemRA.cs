using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using Cinemachine;

public class ItemRA : MonoBehaviour
{
    private LieuRAManager lieumanager;

    public Item item;
    private ItemRAManager manager;
    private CameraManager cameraManager;
    public UnityEvent use;
    public CinemachineVirtualCamera cam;

    void Start() {
        manager = (ItemRAManager)FindObjectOfType(typeof(ItemRAManager));
                lieumanager = (LieuRAManager)FindObjectOfType(typeof(LieuRAManager));

        cameraManager = (CameraManager)FindObjectOfType(typeof(CameraManager));
    }

    public void Select(){
        manager.SetCurrentItem(this);
    }

    public void Use(){
        use.Invoke();
    }

    public void Show(){
        cameraManager.Show(this);
    }

    public void Hide(){

    }

    public void DisplayUI(){
        manager.DisplayUIItem();
    }

    private void OnMouseDown() {
        lieumanager.log("je touche "+this.name);
        Select();
        Show();
        DisplayUI();
    }
}
