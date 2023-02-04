using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{
    // Start is called before the first frame update

    public enum Brujula {none,north,south,east,west};
    
    Brujula miDireccion = Brujula.north;

    Brujula RevertirDireccion(Brujula dir){
        if (dir == Brujula.north){
            miDireccion = Brujula.south;
        }
        return dir;
    }
    void Start()
    {
        Debug.Log("Mi direccion es:" + miDireccion);
        RevertirDireccion(miDireccion);
        Debug.Log("Mi direccion revertida es: " + miDireccion);
    }
}
