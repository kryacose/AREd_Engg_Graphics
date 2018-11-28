using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SolidVirtualiserButtonManager : MonoBehaviour {

	public GameObject parent;
	public GameObject Body;
	public Text Out;

	GameObject shape,UI_Shape;
	GameObject CubeUI; 



	public void DoneButton()
	{		

		if (shape == null) {
			parent.SetActive (true);
			shape = parent.transform.Find (Out.text).gameObject;
			shape.SetActive (true);
			UI_Shape=Body.transform.Find (Out.text).gameObject;
			UI_Shape.SetActive (true);	
		} 
		else
		{
			shape.SetActive (false);
			UI_Shape.SetActive (false);
			//Reload ();
			shape = parent.transform.Find (Out.text).gameObject;
			shape.SetActive (true);
			UI_Shape=Body.transform.Find (Out.text).gameObject;
			UI_Shape.SetActive (true);
		}
	}



	public void BackButton(string Menu)
	{
		SceneManager.LoadScene (Menu);
	}

	public void Reload()
	{
		parent.transform.localScale = new Vector3 (1, 1, 1);
	}

}
