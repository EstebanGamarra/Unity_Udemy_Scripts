using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigg : MonoBehaviour
{
    public GameObject Cilindro;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider coll)
    {
        Cilindro.GetComponent<Rigidbody>().isKinematic = false;
        Debug.Log("Entro Trigger");
    }
    void OnTriggerStay(Collider coll)
    {
        Debug.Log("Esta Trigger");
    }
    void OnTriggerExit(Collider coll)
    {
        Debug.Log("Salio del Trigger");
    }
}
