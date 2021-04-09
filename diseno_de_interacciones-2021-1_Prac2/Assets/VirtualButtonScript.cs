using UnityEngine;
using Vuforia;

public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{

    private VirtualButtonBehaviour virtualButton;
    public Animator animcontroller;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Se presionó");
        animcontroller.SetBool("bailar", true);
    } 

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Se levantó");
        animcontroller.SetBool("bailar", false);
    }

    void Awake()
    {
        virtualButton = GetComponent<VirtualButtonBehaviour>();
    }

    void Start()
    {
        if (virtualButton != null)
        {
            virtualButton.RegisterEventHandler(this);
        }
    }
}
