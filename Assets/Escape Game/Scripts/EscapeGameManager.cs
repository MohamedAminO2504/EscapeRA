using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
    using UnityEngine.SceneManagement;

public class EscapeGameManager : MonoBehaviour
{
    public UnityEvent firstEvent;
    private bool firstTime;
    public Interaction interaction;
    public ItemRA item;
    public GameObject uiOjetAUtiliser;
    
    private CameraManager cameraManager;
    public GameObject uiInteraction;
    public bool debug;
    public CartItemRA currentCartItem;

    private void Start() {
        cameraManager = (CameraManager)FindObjectOfType(typeof(CameraManager));
        firstTime = true;    
    }

    public void Commencer(){
        if(firstTime){
            firstTime = false;
            firstEvent.Invoke();
        }
    }

    public void SetInteraction(Interaction i){
        interaction = i;
    }

    public void UseCart(CartItemRA obj){
      //  CartItemRA cartItemRA = obj.GetComponent<CartItemRA>();
      //  currentCartItem = cartItemRA;
      //  item = cartItemRA.current;
      //  UseItem();
    }

    public void SetItem(ItemRA i){
        item = i;
       // uiOjetAUtiliser.SetActive(true);
    }
    
    public void UseItem(){
     /*   if(interaction.itemAttendu == item){
            Debug.Log("Bravo");
            interaction.Use();
        }else{
            Debug.Log("Rater");
        }
        
        item = null;
        HideInteraction();
       uiInteraction.SetActive(false);*/
    }
    
    public void HideInteraction(){
        cameraManager.SwitchViewToMainCamera(interaction);
        interaction = null;
    }

 

    public void loadlevel(int level)
    {
       
            StartCoroutine(LoadYourAsyncScene(level));
        
    }

    IEnumerator LoadYourAsyncScene(int level)
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(level);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
