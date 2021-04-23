using System.Collections;
using System.Collections.Generic;
using IBM.Watsson.Examples;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Interactable2 : MonoBehaviour
{
    public bool isInsideZone = false;
    public bool gazedAt = false;
    public float gazeInteractTime = 2f;
    public float gazeTimer = 0;
    public string interactionButton = "Interact";
    public string voiceCommand = "Brincar";

    void Start()
    {
        ExampleStreaming commandProcessor = GameObject.FindObjectOfType<ExampleStreaming>();
        commandProcessor.onVoiceCommandRecognized += OnVoiceCommandRecognized;
    }
    
    public virtual void Update()
    {
        // if (isInsideZone && Input.GetKeyDown(interactionKey))
        if (isInsideZone && CrossPlatformInputManager.GetButtonDown(interactionButton))
        {
            Interact();
        }
        if (gazedAt)
        {
            if ((gazeTimer += Time.deltaTime) >= gazeInteractTime)
            {
                Interact();
                gazedAt = false;
                gazeTimer = 0f;
            }
        }
    }
 
    public void OnVoiceCommandRecognized(string command)
    {
        if (command.ToLower() == voiceCommand.ToLower() && gazedAt)
        {
            Interact();
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





    public void OnPointerEnter()
    {
        gazedAt = true;
        gazeTimer = 0f;
    }

    public void OnPointerExit()
    {
        gazedAt = false;
        gazeTimer = 0f;
    }

    /// <summary>
    /// This method is called by the Main Camera when it is gazing at this GameObject and the screen
    /// is touched.
    /// </summary>
    public void OnPointerClick()
    {
        Interact();
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