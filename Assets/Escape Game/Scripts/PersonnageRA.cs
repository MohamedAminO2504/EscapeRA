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
    public float speedRotation;
    public bool playAwake;
     public float currentVit;
    private bool play;

    public void Stop(){
        play = false;
        anim.SetFloat("vel",(0));

    }

    public void Play(){
        play = true;
        anim.SetFloat("vel",(1));
    }

    void Start()
    {
        anim = GetComponent<Animator>();

        if(playAwake){
            currentTarget = targets.Get(0);
            indexTrajet = 0;
            Play();
        }
      
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
        if(!play)
            return ;

        if(currentTarget != null){
            if(currentVit < speed)
                currentVit = currentVit + 10*Time.deltaTime;
 
            float distLieu1 = Vector3.Distance(currentTarget.position, transform.position);
             transform.Translate (Vector3.forward * Time.deltaTime*currentVit) ;

            //transform.localPosition = new Vector3(transform.localPosition.x , transform.localPosition.y, transform.localPosition.z - currentVit*Time.deltaTime);
            LookTraget();
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

    public void LookTraget(){
        Vector3 dir = currentTarget.position - transform.position;
        dir.y = 0; // keep the direction strictly horizontal
        Quaternion rot = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, speedRotation * Time.deltaTime);
    }
}
