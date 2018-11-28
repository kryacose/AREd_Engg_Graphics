using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounds : MonoBehaviour {
	
	public GameObject minCamera, maxCamera;
	public float newy, newz;

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (
			Mathf.Clamp (transform.position.x, minCamera.transform.position.x, maxCamera.transform.position.x), 
			Mathf.Clamp (transform.position.y, minCamera.transform.position.y, maxCamera.transform.position.y), 
			Mathf.Clamp (transform.position.z, minCamera.transform.position.z, maxCamera.transform.position.z));
	}

	public void CmeraTopView()
	{
		if (transform.eulerAngles.x != (90)) 
		{
			transform.position = new Vector3 (transform.position.x, transform.position.y + newy, transform.position.z + newz);
			transform.rotation = Quaternion.Euler (90, 0, 0);
		}
	}

	public void CmeraFrontView()
	{
		if (transform.eulerAngles.x != (0)) 
		{
			transform.position = new Vector3 (transform.position.x, transform.position.y - newy, transform.position.z - newz);
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}
	}
}
