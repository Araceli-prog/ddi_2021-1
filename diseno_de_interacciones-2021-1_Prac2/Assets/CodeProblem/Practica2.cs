using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica2 : MonoBehaviour
{
   public string Nombre;
   private string iguales;

    // Start is called before the first frame update
    void Start()
    {
      //Arreglo de estudiantes
      string[] lista = {"Araceli Luevano", "Alexis Duarte", "Daniela Hernandez", "Estella Jimenez", "Felix Quintero", "Javier Rodriguez"};

      //usuario ingresa desde unity el nombre del alumno que busca
       Debug.Log(" Nombre del alumno a buscar: " + Nombre);

      int output = lista_alumnos(lista, Nombre); //llamar funcion
    }


 public int lista_alumnos(string[] lista, string Nombre)  //funcion
  {

  Debug.Log("LISTA DE ALUMNOS");
  //Imprimir lista de alumnos con ciclo for
     for( int i = 0; i < lista.Length; i++)
     {  
       Debug.Log("Alumno["+i+"] = " + lista[i]);
      }   
  Debug.Log("FIN DE LISTA DE ALUMNOS");


     Debug.Log("El alumno se encuentra en la lista?");
    for( int i = 0; i < lista.Length; i++) //se busca de uno por uno en la lista
    {
        if(lista[i] == Nombre) //se compara con el nombre que ingreso
        {
          iguales = lista[i]; //si es que esta, se guarda en la variable igual
        }
    }

    //imprimir 'true" si "iguales" es igual que nombre, sino "false"
    print((iguales == Nombre) ? "True" : "False");
  
   return 0;
  }
}
     
