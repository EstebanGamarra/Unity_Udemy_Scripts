using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array_Script : MonoBehaviour
{
    string[] letras = new string[5]{"a","b","c","d","e"};

    public int[] numeros; //UNITY tiene editor de esto para cargar manualmente en una ventana 
    // Update is called once per frame
    void Update()
    {
        Debug.Log(letras[4]);
        Debug.Log(letras[3]);
        Debug.Log(letras[2]);
        Debug.Log(letras[1]);
        Debug.Log(letras[0]);
    }
}
