using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemType
{
     Medicine, Equip, PosionVida, Espada, Flecha, PosionSalto, PosionVelocidad, Arco, Escudo
}


[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Generic")]
public class Item : ScriptableObject
{
    public ItemType itemType = ItemType.Equip;
    public Sprite icon = null;

    public virtual void Use()
    {
        Debug.Log($"Usando item {name}");
    }
}
