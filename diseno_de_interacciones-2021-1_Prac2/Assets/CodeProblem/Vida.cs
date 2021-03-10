using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New life", menuName = "Inventory/Medicine")]
public class Vida : Item
{
   public float lifeAmount = 5.0f;
   public float effectiveness = 10f;
    public override void Use()
    {
        base.Use();
        //subirme vida
        Debug.Log($"Aumentando la vida en {lifeAmount} unidades");
    }

}  
