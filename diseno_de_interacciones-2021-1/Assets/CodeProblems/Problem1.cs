using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] nums = {8,1,2,2,3};
        int[] output = NumbersLessThan(nums);
    
    /*foreach (var num in output)
      {
           Debug.Log(num);
      } */
    }

    private int[] NumbersLessThan(int[] nums)
    {
        int[] copia = {0,0,0,0,0}; //arreglo copia
        int cont = 0; //contador

        //input     {8,1,2,2,3}
        //output    [4,0,1,1,3] 

        for(int i = 0 ; i < nums.Length ; i++)
        { //for que mueve los elementos(5) a comparar
            
             copia [i] = nums[i]; //copiar elementos del arreglo nums
             
            for(int j = 0 ; j < nums.Length ; j++)
             { //for que compara un elmento con los demas(5)

                if(copia[i] > nums[j]) //comparar si el elemento de copia es mayor que el de nums
                 {                    
                  cont++;//suma de numeros menores que el elemento en la posicion i
                 }     
             }  

            Debug.Log(cont); //imprimir arreglo con la suma de numeros menores
            cont = 0; //regresar contador a 0 para la siguiente iteracion de elementos
        } 
        //generar output
        return nums;
    }
}
