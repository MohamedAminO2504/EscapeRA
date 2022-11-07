using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dialogue : MonoBehaviour
{
    public string name;
    public List<string> dialogues;
    public UnityEvent events;

    private DialogueRAManager dialogueManager;

    void Start() {
        dialogueManager = (DialogueRAManager)FindObjectOfType(typeof(DialogueRAManager));
        dialogueManager.dialogues.Add(this);
    }

}
