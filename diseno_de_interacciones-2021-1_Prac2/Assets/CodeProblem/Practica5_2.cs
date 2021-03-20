using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

  
public class Practica5_2 : MonoBehaviour
{
    void Start()
    {
       int[] nums = {4,1,2,1,2};

       buscar(nums); //llamar funcion   
    }

      public static bool NOrepit(int numero, int[] nums)
        {
           int cont = 0;
           int i;

            for(i = 0; i < nums.Length ; i++)
            {
                if (nums[i] == numero) 
                {
                    cont++;
                }
            }
          return cont == 1;
        }

      public static void buscar(int[] nums)
        {
            int no = 0;
            int i;

            for(i = 0 ; i < nums.Length ; i++)
            {
                if( NOrepit(nums[i], nums) )
                 {
                    no = nums[i];
                 }
            }
            Debug.Log("El numero que no se repite es: " + no);
        } 
}

