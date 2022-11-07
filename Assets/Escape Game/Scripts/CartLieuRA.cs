using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartLieuRA : MonoBehaviour
{   

    public GameObject content;

    private LieuRAManager manager;
    public float currentRotateContent;
    public bool active;
    public Interaction currentInteraction;
    public EscapeGameManager eg;

    void Start() {
        manager = (LieuRAManager)FindObjectOfType(typeof(LieuRAManager));
                eg = (EscapeGameManager)FindObjectOfType(typeof(EscapeGameManager));

        currentRotateContent = content.transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col){
        manager.log(col.gameObject.name);
        if (col.gameObject.tag == "CartItem"){
            if(currentInteraction != null){
                eg.SetInteraction(currentInteraction);
                eg.SetItem(col.gameObject.GetComponent<CartItemRA>().current);
            }            
        }
    }

  
}
