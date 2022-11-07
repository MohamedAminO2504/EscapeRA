using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TrajetStep : MonoBehaviour
{
    public List<Transform> trajets;
    public UnityEvent eventApresLeTrajet;
    public bool loop;

    public Transform Get(int i){
        return trajets[i];
    }
}
