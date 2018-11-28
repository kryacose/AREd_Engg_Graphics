using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewPArent : MonoBehaviour {

	GameObject shapes;
	public GameObject target;

	//void Awake ()
	//
	//	shapes = GameObject.Find ("Shapes");
	//	shapes.transform.parent = target.transform;
	//	shapes.transform.localPosition =new Vector3(0,0,0);
	///}
	void start()
	{
		UserParent ();
		Debug.Log ("Parent Start");
	}


	public void UserParent()
	{

		shapes = GameObject.Find ("Shapes");
		shapes.transform.position = new Vector3 (0, 0, 0);
		Destroy (shapes.GetComponent<Animator> ());
		shapes.transform.parent = target.transform;
		shapes.transform.localPosition = new Vector3 (0, 0, 0);
		shapes.transform.localScale /= 10.0f;
	
	}
		/*public void PredefinedParent(bool active)
	{
		if (active) 
		{
			shapes.transform.parent = target.transform;
		}
	}*/
}
