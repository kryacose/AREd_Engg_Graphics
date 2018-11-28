using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Centre : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		Vector3 CameraCenter = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2, Camera.main.nearClipPlane));
		RaycastHit hit;

		if (Physics.Raycast(CameraCenter, this.transform.forward, out hit, 1000))
		{
			var obj = hit.transform.gameObject;
			Debug.Log (obj);
		}

	}
}
