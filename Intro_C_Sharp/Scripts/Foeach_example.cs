using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foeach_example : MonoBehaviour
{
    string[] animales = {"jirafa","raton","conejo"};
    int[] incremento = new int [] {1,2,3,9,10};
    int resultado = 0;
    int i = 0;
    void Start()
    {
        /*foreach (string animal in animales){ //animal es variable temporal
            Debug.Log(animal);
        }*/
        do{
            resultado += incremento[i];
            Debug.Log(resultado + "incremento de suma");
            i++;
            Debug.Log(i + "valor de i");
        }while (i < 5);
        Debug.Log(resultado +"resultado al terminar el loop");
    }
}
