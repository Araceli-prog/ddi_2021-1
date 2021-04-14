  using UnityEngine;

public class Teleporter : Interactable2
{
    public Vector3 offset;
    public override void Interact()
    {
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        if (player != null)
        {
            player.position = this.transform.position + offset;
        }
    }
}