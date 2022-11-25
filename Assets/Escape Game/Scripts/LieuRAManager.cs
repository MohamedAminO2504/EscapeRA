using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;

public class LieuRAManager : MonoBehaviour
{
   /* public Slider sliderRotate;
    public CartLieuRA cartLieu1;
    public CartLieuRA cartLieu2;
    public CartLieuRA cartLieu3;
    public CartLieuRA cartLieu4;

    private CameraManager cameraManager;

    private CartLieuRA plusProcheLieu;
    public Text debug;
    
    void Start() {
        cameraManager = (CameraManager)FindObjectOfType(typeof(CameraManager));
        cartLieu1.active = true;
    }

    public void log(string l){
        debug.text = l;
    }

    public CartLieuRA GetPlusProcheCartLieu(){
        CartLieuRA gagnant1 = plusProcheEntreDeux(cartLieu1, cartLieu2);
        CartLieuRA gagnant2 = plusProcheEntreDeux(cartLieu3, cartLieu4);
        return plusProcheEntreDeux(gagnant1,gagnant2);

    }

    private CartLieuRA plusProcheEntreDeux(CartLieuRA a1 , CartLieuRA a2){
            if(a1 == null || !a1.active)
                return a2;
            if(a2 == null || !a2.active)
                return a1;
                    
            float distLieu1 = Vector3.Distance(cameraManager.mainCamera.transform.position, a1.gameObject.transform.position);
            float distLieu2 = Vector3.Distance(cameraManager.mainCamera.transform.position, a2.gameObject.transform.position);
            if(distLieu1 < distLieu2){
                return cartLieu1;
            }else{
                return cartLieu2;
            }
    }

    public void RotateStart(){
        plusProcheLieu = GetPlusProcheCartLieu();
        Debug.Log("Le lieu le plus proche est "+plusProcheLieu.name);
        log("Le lieu le plus proche est "+plusProcheLieu.name);
        plusProcheLieu.content.transform.position = new Vector3(plusProcheLieu.content.transform.position.x, plusProcheLieu.content.transform.position.y + 50, plusProcheLieu.content.transform.position.z);
    }

    public void RotateStop(){
        plusProcheLieu.content.transform.position = new Vector3(plusProcheLieu.content.transform.position.x, plusProcheLieu.content.transform.position.y - 50, plusProcheLieu.content.transform.position.z);
        plusProcheLieu.content.transform.eulerAngles = new Vector3( plusProcheLieu.content.transform.eulerAngles.x, plusProcheLieu.currentRotateContent, plusProcheLieu.content.transform.eulerAngles.z );
        plusProcheLieu = null;
    }


    public void Rotade(){
        float y = plusProcheLieu.currentRotateContent + sliderRotate.value;
        plusProcheLieu.content.transform.eulerAngles = new Vector3( plusProcheLieu.content.transform.eulerAngles.x, y, plusProcheLieu.content.transform.eulerAngles.z );
    }
*/

}
