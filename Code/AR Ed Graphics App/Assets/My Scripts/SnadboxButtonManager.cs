using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SnadboxButtonManager : MonoBehaviour {

	public GameObject parent,DownButton,sectionPlane,sectionPlaneSphere;
	public GameObject Body;
	public Text Out;
	//public GameObject Cube_UI, Cuboid_UI,Square_Pyramid_UI,Cylinder_UI,Sphere_UI,Cone_UI;
	GameObject shape,UI_Shape;
	GameObject CubeUI; 



	//void start()
	////{
	//	CubeUI = Body.transform.Find ("CubeUI").gameObject;
	//}

	public void DoneButton()
	{		

		if (!parent.active) {
			parent.SetActive (true);
			shape = parent.transform.Find (Out.text).gameObject;
			shape.SetActive (true);
			UI_Shape=Body.transform.Find (Out.text).gameObject;
			UI_Shape.SetActive (true);	
		} 
		else
		{
			shape.SetActive (false);
			UI_Shape.SetActive (false);
			//Reload ();
			shape = parent.transform.Find (Out.text).gameObject;
			shape.SetActive (true);
			UI_Shape=Body.transform.Find (Out.text).gameObject;
			UI_Shape.SetActive (true);
		}
	}

	public void DisableShapesUI()
	{
		if (DownButton.activeSelf)
			UI_Shape.SetActive (false);
	}

	public void EnableShapesUI()
	{
		if (!DownButton.activeSelf)
			StartCoroutine("wait");

	}

	IEnumerator wait()
	{
		yield return new WaitForSeconds (1);
		UI_Shape.SetActive (true);
	}

	public void BackButton(string Menu)
	{
		SceneManager.LoadScene (Menu);
	}

	public void Reload()
	{
		parent.transform.localScale = new Vector3 (1,1,1);
		sectionPlane.transform.position = new Vector3 (0,-50,0);
		sectionPlane.transform.Rotate (0, 0, 0);
		sectionPlaneSphere.transform.position = new Vector3 (0,-99,0);
		sectionPlaneSphere.transform.Rotate (0, 0, 0);
	}
			
}
