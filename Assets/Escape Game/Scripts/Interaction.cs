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
    public float waitAfterResolve;
    public bool destroyItemAfter;

    private void Start() {
      if(cam)
        cam.gameObject.SetActive(false);
    }


    private void OnMouseDown() {
        if(!active)
            return;
        if(cam)
        cam.m_Priority = 50;
        
        
        UIManager uimanager = FindObjectOfType<UIManager>();
        EscapeSceneManager escapeSceneManager = FindObjectOfType<EscapeSceneManager>();
        escapeSceneManager.SetCurrentInteraction(this);
        escapeSceneManager.DisplayUseItemUI();
    
    }

    public void Exit(){
        cam.m_Priority = 0;
    }

    public void Use(int i){
        CartItemRA[] cartesItem = FindObjectsOfType<CartItemRA>();
        UIManager uimanager = FindObjectOfType<UIManager>();
                Debug.Log("USE "+uimanager.cartesItem[i].currentObject.nom);

        if(uimanager.cartesItem[i].currentObject == key){
            events.Invoke();
            if(destroyItemAfter){
                key.Ranger();
                key.gameObject.SetActive(false);
                uimanager.cartesItem[i].currentObject = null;
            }
        }
        uimanager.RestCartText();

        StartCoroutine(ExitWithDelai());
    }

    IEnumerator ExitWithDelai(){
        yield return new WaitForSeconds(waitAfterResolve);
        Exit();
    }

}
