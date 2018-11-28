using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateClone : MonoBehaviour {

	public GameObject Shapes;
	int num = 0;
	int solidTextNum = 1;
	public Text SolidText;
	GameObject clone;
	GameObject[] clones;
	public void Clone()
	{
		num++;
		string name;
		clone = Instantiate (this.gameObject, this.transform.position, this.transform.rotation) as GameObject;
		//clone.transform.parent = Shapes.transform;
		clone.SetActive (true);
		name = Shapes.name;
		clone.name = name;
		Shapes.name = "Shapes"+num;

	}	

	public void SlidText()
	{
		solidTextNum++;
		SolidText.text = "Solid " + solidTextNum;
	}

	/*public void ActivateSolids(string tagName)
	{
		string name;
		GameObject clon;
		for (int i = 1; i <= num; ++i)
		{
			name = "Shapes" + i;
			clon = GameObject.Find (name);
			if (clon !=null)
				clon.SetActive (true);
			else
				Debug.Log (name);
		}
		Debug.Log (num);
		clon = GameObject.Find ("Shapes");
		if (clon != null)
			clon.SetActive (true);

		*/
		/*
		clones = GameObject.FindGameObjectsWithTag (tagName);
		clones = GameObject.Fin
		if (clones==null)
			Debug.Log ("No Tags with" + tagName);
		else
			Debug.Log (clones);
		
		foreach (GameObject clone in clones) 
		{
			clone.SetActive (true);
			Debug.Log(clones.Length);
		}
	

	}*/

}
