using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GyroControle : MonoBehaviour
{

    private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rot;
    public CinemachineVirtualCamera camera;
    public GameObject room;
    public GameObject carte;

    public Transform roomGyro;
    public GameObject fx;

    public void DisplayFx(){
        if(fx)
            fx.SetActive(true);
    }

    public void HideFx(){
        if(fx)
            fx.SetActive(false);
    }

    // Update is called once per frame
   public void EnableGyro()
    {
        if(SystemInfo.supportsGyroscope){
            cameraContainer = new GameObject("CameraContainer");
            cameraContainer.transform.position = camera.transform.position;
            camera.transform.SetParent(cameraContainer.transform);
            gyro = Input.gyro;
            gyro.enabled = true;
            cameraContainer.transform.rotation = Quaternion.Euler(90f,90f,0f);
            rot = new Quaternion(0,0,1,0);

            gyroEnabled = true;
        }else{
            gyroEnabled = false;

        }    
        FindObjectOfType<EscapeSceneManager>().ShowExitVR(); 
        HideFx();
        camera.m_Priority = 50;
        if(roomGyro && room)
            room.transform.SetParent(roomGyro);
   
    }

   public void DiseableGyro(){
        if(SystemInfo.supportsGyroscope){
            camera.transform.SetParent(transform);
            gyro = Input.gyro;
            gyro.enabled = false;
            Destroy(cameraContainer);

        }        
        camera.m_Priority = 0;
        if(carte && room)
        room.transform.SetParent(carte.transform);
        FindObjectOfType<EscapeSceneManager>().HideExitVR(); 

        gyroEnabled = false;
        DisplayFx();
    }

    private void Update() {
        if(gyroEnabled){
            camera.transform.localRotation = gyro.attitude*rot;
            camera.transform.Translate(new Vector3(Input.acceleration.x,0,0));
        }
    }
}
