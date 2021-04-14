using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Interactable2 : MonoBehaviour
{
    public bool isInsideZone = false;
    public bool gazedAt = false;
    public float gazeInteractTime = 2f;
    public float gazeTimer = 0;
    public string interactionButton = "Interact";


    public virtual void Update()
    {
        // if (isInsideZone && Input.GetKeyDown(interactionKey))
        if (isInsideZone && CrossPlatformInputManager.GetButtonDown(interactionButton))
        {
            Interact();
        }

         if (gazedAt) //Mientras lo estoy obsevando incrementamos el timmer
        {
            if ((gazeTimer += Time.deltaTime) >= gazeInteractTime) //si el timmer ya llego al limite, solo activa
            {
                Interact();
                gazedAt = false;
                gazeTimer = 0f;  //resetear el timmer
            }
        }  
    }
 
    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        Debug.Log("Entró en el área");
        isInsideZone = true;
    }


    public void SetGazedAt(bool gazedAt)
    {
         this.gazedAt = gazedAt;
        if (!gazedAt)
        {
            gazeTimer = 0f;
        }
    }


        void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        Debug.Log("Salió en el área");
        isInsideZone = false;
    }

    public virtual void Interact()
    {

    }    
}