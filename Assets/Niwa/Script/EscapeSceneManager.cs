using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeSceneManager : MonoBehaviour
{
   
    public GameObject pause;
    public GameObject inGame;
    public GameObject exitVR;
    public GameObject vRButtons;

    public AudioSource audioSource;

    private GyroControle[] gyros;

    public void ShowExitVR(){
        exitVR.SetActive(true);
        vRButtons.SetActive(false);
    }
    public void HideExitVR(){
        exitVR.SetActive(false);
        vRButtons.SetActive(true);
    }

    public void ExitAllVR(){
        foreach (var item in gyros)
        {
            item.DiseableGyro();
        }
    }
    
    private void Start() {
        PlaySong();
        gyros = FindObjectsOfType<GyroControle>();
        HideAllEffectGyro();
    }

    public void ShowAllEffectGyro(){
        foreach (var item in gyros)
        {
            item.DisplayFx();
        }
    }
    public void HideAllEffectGyro(){
        foreach (var item in gyros)
        {
            item.HideFx();
        }
    }


    public void Pause(){
        pause.SetActive(true);
                inGame.SetActive(false);

        Time.timeScale  = 0f;
        if(audioSource)
            audioSource.volume = 0f;
    }

    public void Play(){
        pause.SetActive(false);
        inGame.SetActive(true);

        Time.timeScale  = 1f;
        if(audioSource)
            audioSource.volume = 1f;
    }

    public void PlaySong(){
        if(audioSource)
            audioSource.Play();
    }

    public void PauseSong(){
        if(audioSource)
            audioSource.Pause();
    }

    public void ChangeScene(int scene){
        Time.timeScale  = 1f;
        StartCoroutine(LoadYourAsyncScene(scene));
    }

    IEnumerator LoadYourAsyncScene(int s)
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(s);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
