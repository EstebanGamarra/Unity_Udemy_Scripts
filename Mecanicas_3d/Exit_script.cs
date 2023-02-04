using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_script : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
