using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class InventoryUI : MonoBehaviour
{
    private Inventory _inventory;
    public GameObject panel;
    public string Activar = "UpdateUI";

    void Start()
    {
        _inventory = Inventory.InventoryInstance;
        _inventory.onChange += UpdateUI;
    }


 void Update()//visializacion del inventario
    {
       // if(Input.GetKeyDown(KeyCode.I))
        if(CrossPlatformInputManager.GetButtonDown(Activar))
        {
           panel.SetActive(!panel.activeSelf);
           UpdateUI();
        }
    }

 void UpdateUI() //se llama cuando hay un cambio en el inventario
    {
          Slot[] slots = GetComponentsInChildren<Slot>();
          //Item[] equipItems = _inventory.GetAllItemsByType(ItemType.Equip);
          //Item[] medicineItems = _inventory.GetAllItemsByType(ItemType.Medicine); 
          Item[] antorchaItems = _inventory.GetAllItemsByType(ItemType.Antorcha);
          Item[] cuerdaItems = _inventory.GetAllItemsByType(ItemType.Cuerda);        
          Item[] escudoItems = _inventory.GetAllItemsByType(ItemType.Escudo);
          Item[] espadaItems = _inventory.GetAllItemsByType(ItemType.Espada);
          Item[] gemaAzulItems = _inventory.GetAllItemsByType(ItemType.GemaAzul);    
          Item[] libroItems = _inventory.GetAllItemsByType(ItemType.Libro);    
          Item[] mapaItems = _inventory.GetAllItemsByType(ItemType.Mapa);    
          //Item[] cuchilloItems = _inventory.GetAllItemsByType(ItemType.Cuchillo);    
          Item[] gemaVerdeItems = _inventory.GetAllItemsByType(ItemType.GemaVerde);    
          Item[] gemaRojaItems = _inventory.GetAllItemsByType(ItemType.GemaRoja);
          Item[] gemaRosaItems = _inventory.GetAllItemsByType(ItemType.GemaRosa);


         /* if (equipItems.Length > 0)
              slots[0].SetItem(equipItems[0], equipItems.Length);

          if (medicineItems.Length > 0)
              slots[1].SetItem(medicineItems[0], medicineItems.Length); */ 

          if (gemaAzulItems.Length > 0)
              slots[0].SetItem(gemaAzulItems[0], gemaAzulItems.Length);  //gemaAzul

          if (gemaRojaItems.Length > 0)
              slots[1].SetItem(gemaRojaItems[0], gemaRojaItems.Length);   //gemaroja

          if (gemaRosaItems.Length > 0)
              slots[2].SetItem(gemaRosaItems[0], gemaRosaItems.Length);   //gemarosa

          if (gemaVerdeItems.Length > 0)
              slots[3].SetItem(gemaVerdeItems[0], gemaVerdeItems.Length);   //gemaVerde

          if (antorchaItems.Length > 0)
              slots[4].SetItem(antorchaItems[0], antorchaItems.Length); //antorcha

          if (cuerdaItems.Length > 0)
              slots[5].SetItem(cuerdaItems[0], cuerdaItems.Length);   //cuerda          

          if (escudoItems.Length > 0)
              slots[6].SetItem(escudoItems[0], escudoItems.Length);   //escudo

          if (espadaItems.Length > 0)
              slots[7].SetItem(espadaItems[0], espadaItems.Length);  //espada

          if (libroItems.Length > 0)
              slots[8].SetItem(libroItems[0], libroItems.Length);   //libro

          if (mapaItems.Length > 0)
              slots[9].SetItem(mapaItems[0], mapaItems.Length);    //mapa   

         // if (cuchilloItems.Length > 0)
          //    slots[10].SetItem(cuchilloItems[0], cuchilloItems.Length);    //cuchillo


    

        // for (int i = 0; i < slots.Length; i++)
        //   {
        //       if (i < _inventory.items.Count)
        //       {
        //          slots[i].SetItem(_inventory.items[i]);
        //       }
        //       else
        //       {
        //          slots[i].Clear();
        //       }
        //   }
    }
}