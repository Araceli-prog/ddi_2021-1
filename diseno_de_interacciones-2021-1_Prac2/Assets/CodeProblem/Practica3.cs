using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica3 : MonoBehaviour
{
      private int cons;
      private int uno;
      private int dos;
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = {15,3,4,5};
        int target = 20;

      int output = buscar(nums, target); //llamar funcion
    }
  
 public int buscar(int[] nums, int target)  //funcion
  {
     cons = nums[0];

    for( int i = 0; i < nums.Length ; i++)
     {  
    
       if(cons + nums[i] == target)
        {
          uno = 0; 
          dos = i;
        }
       else    
        {
          Debug.Log("El numero "+cons+" y el numero "+nums[i]+" no cumplen la suma");
        }
      } 
      
  Debug.Log("INDICE de los numeros que sumados dan " + target );    
      Debug.Log(uno);
      Debug.Log(dos);
    return 0;
  }
}
