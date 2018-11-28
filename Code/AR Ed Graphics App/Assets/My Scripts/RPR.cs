using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RPR : MonoBehaviour {

	public Transform LoadingBar;
	public Transform TextIndicator;
	public Transform TextLoading;
	[SerializeField] private float currentAmount;
	[SerializeField] private float speed;

	void Update () 
	{
		if (currentAmount < 100) {
			currentAmount += speed * Time.deltaTime;
			TextIndicator.GetComponent<Text> ().text = ((int)currentAmount).ToString () + "%";
			TextLoading.gameObject.SetActive (true);
		} else
		{
			TextLoading.gameObject.SetActive (false);
			TextIndicator.GetComponent<Text> ().text = "DONE!";
		}
		LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
	}
}
