using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{   
    public CinemachineVirtualCamera mainCamera;

    public void Show(ItemRA itemRA){
        if(itemRA.cam != null)  
            itemRA.cam.m_Priority = 20;
    }

    public void Show(Interaction interaction){
        if(interaction.cam != null)  
            interaction.cam.m_Priority = 120;
    }

    public void SwitchViewToMainCamera(ItemRA itemRA){
        if(itemRA.cam != null)  
            itemRA.cam.m_Priority = 0;
    }

       public void SwitchViewToMainCamera(Interaction interaction){
        if(interaction.cam != null)  
            interaction.cam.m_Priority = 0;
    }

}
