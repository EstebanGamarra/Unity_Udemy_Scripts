using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Control : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animController;
    void Start()
    {
        animController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Avanzar();
        Saltar();
        Viento();
        Escala();
    }

    void Avanzar()
    {
        if (Input.GetButtonDown("Fire1"))
            animController.SetBool("Avanzo",true);
        if (Input.GetButtonDown("Fire2"))
            animController.SetBool("Avanzo",false);
    }

    void Saltar()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
            animController.SetTrigger("Salto");
    }
    void Viento()
    {
        if (Input.GetKeyDown(KeyCode.V))
            animController.SetFloat("Viento",0.5f);
        if (Input.GetKeyDown(KeyCode.B))
            animController.SetFloat("Viento",0.0f);
    }
    void Escala()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            animController.SetInteger("Escala",3);
        if (Input.GetKeyDown(KeyCode.X))
            animController.SetInteger("Escala",0);
    }
}
