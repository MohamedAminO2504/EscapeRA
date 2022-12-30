using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cinemachine;

public class EventSimpleMecanisme : MonoBehaviour
{

    public UnityEvent eventEtatA;
    public UnityEvent eventEtatB;

    public CinemachineVirtualCamera cam;
    public GameObject lumiere;
    public bool active;
    public bool isEtatA;
    public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
        isEtatA = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        if(!active)
            return;
        
        cam.m_Priority = 50;
        UI.SetActive(true);
                cam.gameObject.SetActive(true);

    }

    public void Actionne(){
        if(isEtatA){
            eventEtatA.Invoke();
            isEtatA = false;
        }else{
            eventEtatB.Invoke();
            isEtatA = true;
        }
    }

    public void Annuler() {

        cam.m_Priority = 0;
        UI.SetActive(false);
                cam.gameObject.SetActive(false);

    }
}
