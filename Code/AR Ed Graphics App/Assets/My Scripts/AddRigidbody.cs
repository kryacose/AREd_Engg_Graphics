using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddRigidbody : MonoBehaviour {
	public GameObject toggle;

	public void choice(string name)
	{
		if (toggle.GetComponent<Toggle> ().isOn)
			AddRigidBody (name);
		else
			RemoveRigidBody (name);
	}

	void AddRigidBody(string name)
	{
		GameObject[] activeShapes;
		activeShapes = GameObject.FindGameObjectsWithTag (name);
		foreach (GameObject shape in activeShapes) 
		{
			Rigidbody rg = shape.AddComponent<Rigidbody> ();
		
		}
	}

	void RemoveRigidBody(string name)
	{
		GameObject[] activeShapes;
		activeShapes = GameObject.FindGameObjectsWithTag (name);
		foreach (GameObject shape in activeShapes) 
		{
			Destroy (shape.GetComponent<Rigidbody>());

		}
	}
}
