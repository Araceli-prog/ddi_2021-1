using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica5 : MonoBehaviour
{
    void Start()
    {
        int[] nums = {12,345,2,6,7896};
        int cantidad = 0;

      int output = buscar(nums, cantidad); //llamar funcion   

      Debug.Log("Elementos con digitos pares: " + output ); 
    }

public int buscar(int[] nums, int cantidad)  //funcion
  {
    int cont = 0;
    
    for( int i = 0; i < nums.Length ; i++)
     {  
         
       int aux = nums[i]; //variable aux
       cantidad = 0;

       while (nums[i] > 0)  //contar digitos del elemento
		{
			nums[i] = nums[i] / 10;
			
			cantidad = cantidad + 1;
		}

        print("El numero "+ aux +" tiene " + cantidad + " digitos");

         if( cantidad % 2 == 0) //encontrar elementos con digitos pares
          {
             cont++;
          } 
      } //termina for (arreglo)

      cantidad = cont; // guardar en cantidad para regresar
    
    return cantidad; //regresar cont dentro de cantidad
  }
}
