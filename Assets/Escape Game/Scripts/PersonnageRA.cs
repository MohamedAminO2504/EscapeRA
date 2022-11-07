using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class PersonnageRA : MonoBehaviour
{

    public TrajetStep targets;

    [SerializeField]
   // private Transform movePositionTransform;
     NavMeshAgent myNavMeshAgent;
     private Animator anim;
    private int indexTrajet;
    public Transform currentTarget;
    public Vector3 p;
     
     public bool f;
     public float va;
     public float speed;

     public float currentVit;

    void Start()
    {
        currentVit = 0f;
        anim = GetComponent<Animator>();
      
    }


      public void GoStep(GameObject obj){
        targets = obj.GetComponent<TrajetStep>();
        if(targets.trajets.Count > 0){
            currentTarget = targets.Get(0);
            anim.SetFloat("vel",(1));
        }
        indexTrajet = 0;
    }

    void Update(){
        if(currentTarget != null){
            if(currentVit < speed)
                currentVit = currentVit + 5*Time.deltaTime;
 
            float distLieu1 = Vector3.Distance(currentTarget.position, transform.position);
             transform.Translate (Vector3.forward * Time.deltaTime*currentVit) ;

            //transform.localPosition = new Vector3(transform.localPosition.x , transform.localPosition.y, transform.localPosition.z - currentVit*Time.deltaTime);
            transform.LookAt(currentTarget);
            va = distLieu1;
            if(distLieu1 < 40){
                NextStep();
            }
        }
    }

    private void NextStep(){
        indexTrajet++;
        if(targets.trajets.Count == indexTrajet){
            Debug.Log("finis");
            
            if(targets.loop){
                indexTrajet = -1;
            }else{
                currentTarget = null;
                currentVit = 0;
                anim.SetFloat("vel",(0));
                targets.eventApresLeTrajet.Invoke();
            }

        }
        else{
            currentTarget = targets.Get(indexTrajet);
        }
    }

    
}
