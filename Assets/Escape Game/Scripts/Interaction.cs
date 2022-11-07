using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using Cinemachine;

public class Interaction : MonoBehaviour
{

    public CartLieuRA cartLieuRA;
    public ItemRA itemAttendu;
    public UnityEvent events;
    private EscapeGameManager eg;
    public CinemachineVirtualCamera cam;

    private CameraManager cameraManager;
    public GameObject uiInteraction;

    private void Start() {
        eg = (EscapeGameManager)FindObjectOfType(typeof(EscapeGameManager));
        cameraManager = (CameraManager)FindObjectOfType(typeof(CameraManager));

    }

    public void Use(){
        events.Invoke();
    }

    public void DisplayUI(){
        uiInteraction.SetActive(true);
    }

    
    public void OnMouseDown() {
        Debug.Log("Ouiiiiii interaction");
        eg.SetInteraction(this);
        eg.uiInteraction.SetActive(true);
        cameraManager.Show(this);
    }

    public void Show(){
        cameraManager.Show(this);
    }

}
