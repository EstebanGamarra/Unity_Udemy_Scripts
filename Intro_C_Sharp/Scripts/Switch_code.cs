using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_code : MonoBehaviour
{
    // Start is called before the first frame update

    public int caso;
    void Start()
    {
        switch (caso)
        {
            case 0:
                Debug.Log("Caso 0");
                break;
            case 1:
                Debug.Log("Caso 1");
                break;
            case 2:
                Debug.Log("Caso 2");
                break;
            default:
                Debug.Log("Caso Default");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
