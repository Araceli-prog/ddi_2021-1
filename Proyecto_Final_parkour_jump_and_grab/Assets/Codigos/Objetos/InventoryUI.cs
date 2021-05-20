using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private Inventory _inventory;
    public GameObject panel;
    public string interactionInvent = "UpdateUI";

    // Start is called before the first frame update
    void Start()
    {
        _inventory = Inventory.InventoryInstance;
        _inventory.onChange += UpdateUI;
    }

    // Update is called once per frame
    void Update()
    {
        // if( Input.GetKeyDown(KeyCode.I))
        // {
        //     panel.SetActive(!panel.activeSelf);
        //     UpdateUI();
        // }
        if( CrossPlatformInputManager.GetButtonDown(interactionInvent))
        {
            panel.SetActive(!panel.activeSelf);
            UpdateUI();
        }
    }

    void UpdateUI() //se llama cuando hay un cambio en el inven.
    {
        //Debug.Log("Cambio el inventario");
        Slot[] slots = GetComponentsInChildren<Slot>();
        Item[] posionVidaItems = _inventory.GetAllItemsByType(ItemType.PosionVida);
        Item[] espadaItems = _inventory.GetAllItemsByType(ItemType.Espada);        
        Item[] flechaItems = _inventory.GetAllItemsByType(ItemType.Flecha);        
        Item[] posionSaltoItems = _inventory.GetAllItemsByType(ItemType.PosionSalto);
        Item[] posionVelocidadItems = _inventory.GetAllItemsByType(ItemType.PosionVelocidad);
        Item[] arcoItems = _inventory.GetAllItemsByType(ItemType.Arco);
        Item[] escudoItems = _inventory.GetAllItemsByType(ItemType.Escudo);
        Item[] medicineItems = _inventory.GetAllItemsByType(ItemType.Medicine); 


        if(posionVidaItems.Length > 0)
            slots[0].SetItem(posionVidaItems[0], posionVidaItems.Length);

        if(espadaItems.Length > 0)
            slots[1].SetItem(espadaItems[0], espadaItems.Length); 

        if(flechaItems.Length > 0)
            slots[2].SetItem(flechaItems[0], flechaItems.Length);
        
        if(posionSaltoItems.Length > 0)
            slots[3].SetItem(posionSaltoItems[0], posionSaltoItems.Length); 
       
        if(posionVelocidadItems.Length > 0)
            slots[4].SetItem(posionVelocidadItems[0], posionVelocidadItems.Length); 

        if(arcoItems.Length > 0)
            slots[5].SetItem(arcoItems[0], arcoItems.Length); 
          
        if(escudoItems.Length > 0)
            slots[6].SetItem(escudoItems[0], escudoItems.Length);       
      
        if(medicineItems.Length > 0)
            slots[7].SetItem(medicineItems[0], medicineItems.Length);        

        // for (int i = 0; i < slots.Length; i++)
        // { 
        //     if (i < _inventory.items.Count)
        //     {
        //        slots[i].SetItem(_inventory.items[i]);
        //    }
        //     else
        //     {
        //        slots[i].Clear();
        //     }
            
        // }
    }
}
