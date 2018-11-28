using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour {
	public Button okButton ;

	void Awake ()
	{
		okButton.interactable = false;
	}

	public void SetButton(bool state)
	{
		okButton.interactable = state;
	}
}
