using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Cinemachine;

public class CodeMecanisme : MonoBehaviour
{

    public string value;

    public string current;
    public Text text;

    public UnityEvent eventOnValid;
    public UnityEvent eventOnError;

    public CinemachineVirtualCamera cam;
    public GameObject UI;
    public GameObject lumiere;
    public bool active;

    void Start()
    {
        current = "";
        text.text = current;
    }

    private void OnMouseDown() {
        if(!active)
            return;
        cam.m_Priority = 50;
        UI.SetActive(true);
    }

    public void Add(string val){
        current += val;
        text.text = current;
    }

    public void DelOne(){
        if(current.Length == 0)
            return ;
        current = current.Substring(0, current.Length - 1); 
    }

    public void DelAll(){
        current = "";
        text.text = current;
    }

    public void Valid(){
        if(current == value){
            eventOnValid.Invoke();
            active = false;
            lumiere.SetActive(false);
        }else{
            eventOnError.Invoke();
        }
        UI.SetActive(false);
        cam.m_Priority = 0;
        current = "";
    }

}
