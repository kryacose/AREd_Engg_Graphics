using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SandboxARManager : MonoBehaviour {

	//public GameObject Shapes;

	public void BackButton(string newGameLevel)
	{
		SceneManager.LoadScene (newGameLevel);

	}

	public void DestroyObject()
	{
		Destroy (GameObject.Find ("Shapes"));
	}
}
