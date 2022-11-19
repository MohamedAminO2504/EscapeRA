using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Text timer;
    
    public int heure;
    public int minute;
    public float seconde;
    public float speed = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconde -= Time.deltaTime*speed;
        if(seconde < 0){
            minute--;
            if(minute < 0){
                heure--;
                minute = 59;
            }
            seconde = 59;
        }
        timer.text = heure+":"+minute+":"+((int)seconde);
    }
}
