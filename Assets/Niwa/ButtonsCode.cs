using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsCode : MonoBehaviour
{
    public CodeMecanisme cm;

    public void Add(string val){
        cm.Add(val);
    }

    public void DelOne(){
        cm.DelOne();
    }

    public void DelAll(){
        cm.DelAll();

    }

    public void Valid(){
        cm.Valid();
    }
}
