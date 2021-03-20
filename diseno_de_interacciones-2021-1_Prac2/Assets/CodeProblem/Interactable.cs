using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;
using System;

public class Interactable : MonoBehaviour
{
    public bool isInsideZone = false;
   // public KeyCode interactionKey = KeyCode.P;
    public string interactionButton = "Interact";
    public string exitButton = "ExitButton";
    public string pauseButton = "PauseButton";
    public string continuarButton = "ButtonContinuar";
    
    public GameObject TextOff;
    public GameObject ImageOff; 

    public GameObject MoverOff;
    public GameObject CameraOff; 


    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>

  public virtual void Update()
    {
        //if (isInsideZone && Input.GetKeyDown(interactionKey))
        if (isInsideZone  && CrossPlatformInputManager.GetButtonDown(interactionButton))
         {   
             Interact();
            TextOff.gameObject.SetActive(false);
            ImageOff.gameObject.SetActive(false);  
         }   

        if (CrossPlatformInputManager.GetButtonDown(pauseButton)) // pausar juego
        {
           Time.timeScale = 0;
             MoverOff.gameObject.SetActive(false);
             CameraOff.gameObject.SetActive(false); 
        }
        
        if (CrossPlatformInputManager.GetButtonDown(continuarButton)) // pausar juego
        {
           Time.timeScale = 1;
             MoverOff.gameObject.SetActive(true);
             CameraOff.gameObject.SetActive(true);        
        }

    //    if (CrossPlatformInputManager.GetButtonDown(continuarButton))   //continuar juego
    //     { 
    //       Time.timeScale = 1;
    //     }

        // if (CrossPlatformInputManager.GetButtonDown(exitButton))  //salir de juego
        // { 
        //     Application.Quit();
        // }
    }


    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>

void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        Debug.Log("Entró en el área");
        isInsideZone = true;

       TextOff.gameObject.SetActive(true);
       ImageOff.gameObject.SetActive(true);
    }

    /// <summary>
    /// OnTriggerExit is called when the Collider other has stopped touching the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    
void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        Debug.Log("Salió en el área");
        isInsideZone = false;

       TextOff.gameObject.SetActive(false);
       ImageOff.gameObject.SetActive(false);

    }

   public virtual void Interact()
    {  
    }
}