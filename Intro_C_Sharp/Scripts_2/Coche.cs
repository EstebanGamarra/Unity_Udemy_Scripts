using UnityEngine;
using System.Collections;

public class Coche {

	public string marca;
	public Ruedas ruedas = new Ruedas();
	public Puertas puertas = new Puertas();

	public void EncenderMotor()
	{
		Debug.Log("El motor esta encendido");
	}

	public void ApagarMotor()
	{
		Debug.Log("El motor esta apagado");
	}
}
