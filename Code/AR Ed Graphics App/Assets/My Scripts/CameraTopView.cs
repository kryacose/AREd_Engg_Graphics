using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTopView : MonoBehaviour {

	public GameObject target;

	public void TopView()
	{
		gameObject.transform.localEulerAngles = target.transform.localEulerAngles;
		gameObject.transform.position = target.transform.position;
	}
}
