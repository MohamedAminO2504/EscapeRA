using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Cinemachine;

public class MecanismeDiscution : MonoBehaviour
{
    public List<UnityEvent> events;
    public List<string> dialogues;


    public CinemachineVirtualCamera cam;
    public GameObject UI;
    public GameObject lumiere;
    public bool active;
    public int index;
    public Text text;
    public bool end;

    public void Finish(){
        end = true;
    }
    public void SetIndex(int index){
        this.index = index;
    }

    private void OnMouseDown() {
        if(!active || end)
            return;
        if(cam)
            cam.m_Priority = 50;
        UI.SetActive(true);
        text.text = dialogues[index];
        ActiveCurrentAction();
    }

    public void ActiveCurrentAction(){
        ActiveAction(index);
    }
    public void ActiveAction(int i){
        Debug.Log("lala");
                text.text = dialogues[i];

        events[i].Invoke();
    }

    public void ProchaineAction(){
        if(end){
            Exit();
            return;
        }
        index++;
         ActiveCurrentAction();
   
    }

    public void Exit(){
        UI.SetActive(false);
        cam.m_Priority = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        end = false;
        index = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
