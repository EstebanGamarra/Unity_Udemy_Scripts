using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    public string[] cadena = new string[10]{"a","b","c","d","e","f","g","h","i","j"};
    void Start()
    {
        for (int i= 0; i<10 ; i++){
            Debug.Log(cadena[i]);
        }
    }
}
