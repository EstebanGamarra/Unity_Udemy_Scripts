using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ButtonProperties : MonoBehaviour  {

	public Image imageButton;

	void Start()
	{
		imageButton = GetComponent<Image>();
	}

	public void ColorEnterPoint()
	{
		imageButton.color = Color.cyan;
	}

	public void ColorPointEnterSharp()
	{
		imageButton.color = Color.gray;
	}

	public void ColorPointerOut()
	{
		imageButton.color = Color.white;
	}

	public void ColorPointOutSharp()
	{
		imageButton.color = Color.black;
	}
	
}