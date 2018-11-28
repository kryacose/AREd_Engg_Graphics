using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAngle : MonoBehaviour {


	double angle1,angle2,angle3 ;
	// Update is called once per frame
	void Update () {
		//angle = Vector3.Angle (transform.eulerAngles, target.eulerAngles);
		//Debug.Log (angle);
		//angle = AngleBetweenVector2 (target.eulerAngles, This.eulerAngles);
		Angle2();
		//Debug.Log (angle);
		Debug.Log(angle2);
		//Debug.Log(transform.rotation.z);
	}

	private float AngleBetweenVector2(Vector3 vec1, Vector3 vec2)
	{
		Vector3 diference = vec2 - vec1;
		float sign = (vec2.y < vec1.y)? -1.0f : 1.0f;
		return Vector3.Angle(Vector3.right, diference) * sign;
	}

	void Angle1()
	{
		Vector3 myVec = transform.forward;
		Vector3 worldUp = new Vector3 (0.0f, 1.0f, 0.0f);
		angle1 = Mathf.Asin (Vector3.Dot (myVec, worldUp));
		angle1 = angle1  * Mathf.Rad2Deg;
	}

	void Angle2()
	{
		Vector3 myVec = transform.up;
		Vector3 worldUp = new Vector3 (1.0f, 0.0f, 0.0f);
		angle2 = Mathf.Asin (Vector3.Dot (myVec, worldUp));
		angle2 = angle2 * Mathf.Rad2Deg;
	}

	void Angle3()
	{
		Vector3 myVec = transform.right;
		Vector3 worldUp = new Vector3 (0.0f, 0.0f, 1.0f);
		angle3 = Mathf.Asin (Vector3.Dot (myVec, worldUp));
		angle3 = angle3 * Mathf.Rad2Deg;
	}


}
