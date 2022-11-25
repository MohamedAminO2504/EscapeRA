using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeSceneManager : MonoBehaviour
{
   
    public GameObject pause;
    public GameObject inGame;

    public AudioSource audioSource;
    private void Start() {
        PlaySong();
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
