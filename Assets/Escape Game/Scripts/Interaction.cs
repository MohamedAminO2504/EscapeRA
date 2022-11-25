using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;

using Cinemachine;

public class Interaction : MonoBehaviour
{

    public UnityEvent events;

    public CollectibleObject key;
    public CinemachineVirtualCamera cam;

    private CameraManager cameraManager;
    public bool active = false;
    public GameObject UI;

    private void Start() {
      
    }


    private void OnMouseDown() {
        if(!active)
            return;
        if(cam)
        cam.m_Priority = 50;
                CartItemRA[] cartesItem = FindObjectsOfType<CartItemRA>();
        int i = 0;
        foreach (var item in UI.GetComponentsInChildren<Text>())
        {   
            if(cartesItem[i].currentObject == null)
                item.text = "Carte vide";
            else
                item.text = cartesItem[i].currentObject.nom;
            i++;
        }
        UI.SetActive(true);
    }


    public void Exit(){
        UI.SetActive(false);
        cam.m_Priority = 0;
    }

    public void Use(int i){
        CartItemRA[] cartesItem = FindObjectsOfType<CartItemRA>();
        if(cartesItem[i].currentObject == key){
            events.Invoke();
        }
    }


}
