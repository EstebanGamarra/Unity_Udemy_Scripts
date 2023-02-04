using UnityEngine;
using System.Collections;

public class Carretera : MonoBehaviour {

	Coche miCoche;

	// Use this for initialization
	void Start () 
	{
		CrearCoche();
		miCoche.EncenderMotor();
		Debug.Log("Mi coche es marca " + miCoche.marca);
		Debug.Log("Mi coche tiene " + miCoche.puertas.cantidad + " puertas");
		Debug.Log("Mi coche tiene " + miCoche.ruedas.cantidad + " ruedas");

		// Debug log de todas las propiedades de la clase coche
		ApagarMotorCoches();
	}

	void CrearCoche()
	{
		miCoche = new Coche();
		miCoche.marca = "Ford";
		miCoche.puertas.cantidad = 4;
		miCoche.puertas.cerrojo = true;
		miCoche.ruedas.cantidad = 4;
		miCoche.ruedas.grosor = 10;
		miCoche.ruedas.llanta.cantidadTornillos = 6;
		miCoche.ruedas.colorRueda = Ruedas.ColorRueda.negra;

	}

	void ApagarMotorCoches()
	{
		miCoche.ApagarMotor();
	}
}
