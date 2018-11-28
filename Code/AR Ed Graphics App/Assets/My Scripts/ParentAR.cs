using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ParentAR : MonoBehaviour {
	public GameObject shapes;

	public void Parent()
	{
		///shapes.transform.parent = userDefinedTarget.transform;
		//DontDestroyOnLoad (userDefinedTarget.transform.gameObject);
		DontDestroyOnLoad (transform.gameObject);
	}

	public void LoadARScene(string newGameLevel)
	{
		SceneManager.LoadScene (newGameLevel);

	}
}
