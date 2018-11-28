using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCameraPos : MonoBehaviour {

	public GameObject ARCamera;

	public void Position()
	{
		this.transform.position = ARCamera.transform.position;
	}
}
