using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraRotation : MonoBehaviour {

	public GameObject toggle, mainCamera;

	public void choice()
	{
		if (toggle.GetComponent<Toggle> ().isOn) {
			//mainCamera.GetComponent<Lean.Touch.LeanCameraMoveSmooth> ().enabled = false;
			mainCamera.GetComponent<LookAtObject> ().enabled = true;
            mainCamera.GetComponent<Lean.Touch.LeanCameraMoveSmooth>().Distance = 5.5f;
            mainCamera.GetComponent<Lean.Touch.LeanCameraMoveSmooth>().Sensitivity = 3.1f;

        }

		else
		{
            //mainCamera.GetComponent<Lean.Touch.LeanCameraMoveSmooth> ().enabled = true;
            mainCamera.GetComponent<Lean.Touch.LeanCameraMoveSmooth>().Distance = 5.0f;
            mainCamera.GetComponent<Lean.Touch.LeanCameraMoveSmooth>().Sensitivity = 1.0f;
            mainCamera.GetComponent<LookAtObject> ().enabled = false;
		}
	}

}
