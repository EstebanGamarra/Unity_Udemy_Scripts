using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision_precipicio : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(0);
    }
}
