using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0,30*Time.deltaTime, 0,Space.World);
	}
}
