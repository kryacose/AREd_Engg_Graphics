using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour {
	public Text OUTPUT;
	int index;
	List<string> names = new List<string>{"None","Cube","Cuboid","Square Pyramid","Cylinder","Sphere","Cone"};
	// Use this for initialization
	private void Start () {
		//this.GetComponent<Dropdown> ().captionText.text = "SOLID";	
		
	}
	
	public void indexer(int val)
	{
		OUTPUT.text = ""+names[val];
		index = val;
		 
	}

	public string SelectedShape()
	{
		string value=OUTPUT.text;
		//value = ""+names[val];
		return value;

	}

}
