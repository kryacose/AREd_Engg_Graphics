using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetIsometricView : MonoBehaviour {
	
	public GameObject IsometricButton;

	void Update () {
		if (this.GetComponent<MeshRenderer>().isVisible)
			ActivateObject ();
		else
			DeactivateObject ();
		
	}

	void ActivateObject()
	{
		//IsometricButton.SetActive(true);
	}

	void DeactivateObject()
	{
		//IsometricButton.SetActive(false);
	}

}
