using System.Collections;
using UnityEngine;
using Vuforia ;

public class VBScript : MonoBehaviour, IVirtualButtonEventHandler {
	private GameObject VBButtonObject;
	private int i;
	private GameObject PlayButton;
	int flag= 0 ;
	public int size = 0;
	public GameObject[] player = new GameObject[10]; 
	// Use this for initialization
	void Start () {
		VBButtonObject = GameObject.Find ("PlayButton");
		VBButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		PlayButton = GameObject.Find ("ImageTarget/PlayButton");
	}




	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb){
		Debug.Log ("Button Pressed");
		flag = 1;
		for (i = 0; i < size; ++i)
			player[i].SetActive (true);
		PlayButton.SetActive (false);


	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb2){

		Debug.Log ("Button Not Pressed");
	}
}

