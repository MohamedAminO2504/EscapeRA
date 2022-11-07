using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DialogueRAManager : MonoBehaviour
{   
    public List<Dialogue> dialogues;

    public Text dialogue;
    public GameObject ui;

    public Dialogue current;
    public int index;

    public void SetCurrent(Dialogue d){
        index = 0;
        current = d;
        ui.SetActive(true);
    }

    public void NextDialogue(){
            Debug.Log(current.dialogues.Count +" et "+ index);
            if(current.dialogues.Count == index){
                ui.SetActive(false);
                                current.events.Invoke();
                dialogue.text = "";
                current = null;
            }else{
                dialogue.text = current.dialogues[index];
                index++;
            }
    }

}
