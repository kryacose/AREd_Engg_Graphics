using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextOrientedToCAmera : MonoBehaviour {
	

	private GameObject CameraToFollow;
	private float x,y,z;


		//public float DistanceFromCamera;

	void Start(){

		CameraToFollow = GameObject.Find ("ARCamera");
	}



		void Update() { 
		transform.rotation = CameraToFollow.transform.localRotation;
		//transform.rotation.y = CameraToFollow.transform.localRotation.y;
		//transform.LookAt(CameraToFollow.transform.position, transform.up);


		//Quaternion rot  = CameraToFollow.transform.localRotation;
		//rot.eulerAngles = new Vector3 (rot.x + 90, rot.y - 90, rot.z);
		//this.transform.rotation = rot;
		}
	}