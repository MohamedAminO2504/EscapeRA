using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerEvent : MonoBehaviour
{

    public int heure;
    public int minute;
    public float seconde;

    public UnityEvent events;

    public Timer timer;
    private bool passed;
    // Start is called before the first frame update
    void Start()
    {
        passed = false;
        timer = (Timer)FindObjectOfType(typeof(Timer));

    }

    // Update is called once per frame
    void Update()
    {
        if(passed)
            return; 

        if(heure == timer.heure && minute == timer.minute && seconde < (timer.seconde + 0.1f) && seconde > (timer.seconde - 0.1f) ){
            events.Invoke();
            passed = true;
        }
    }
}
