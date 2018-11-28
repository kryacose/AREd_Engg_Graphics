using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RPRTimed : MonoBehaviour {

	public Transform LoadingBar;
	public Transform TextIndicator;
	public Transform TextLoading;
	[SerializeField]private float currentAmount;
	public GameObject preservedObj;
	//[SerializeField] private float speed;
	public Canvas loadingCanvas;
	GameObject[] gos;
	public GameObject loadingScreenObj;
	AsyncOperation async;
	[SerializeField] private float speed;



	public void LoadScreen(string level)
	{
		StartCoroutine (LoadingScreen (level));
		Deactivate ();
	}

	void Deactivate() 
	{
		gos = GameObject.FindGameObjectsWithTag("Active UI");
		foreach (GameObject go in gos)
			go.SetActive (false);
	}

	IEnumerator LoadingScreen(string level)
	{
		loadingCanvas.gameObject.SetActive (true);
		//loadingScreenObj.SetActive (true);
		async = SceneManager.LoadSceneAsync (level);
		async.allowSceneActivation = false;

		while (async.isDone == false) {
			if(currentAmount <= 100.0f)
				currentAmount += speed * Time.deltaTime;
			TextIndicator.GetComponent<Text> ().text = ((int)currentAmount).ToString () + "%";
			TextLoading.gameObject.SetActive (true);
			 if (currentAmount >= 15.0f) {
				//currentAmount = 1.0f*100;
				async.allowSceneActivation = true;

			}
			if (currentAmount >= 100.0f) {
				TextLoading.gameObject.SetActive (false);
				TextIndicator.GetComponent<Text> ().text = "DONE!";
			}
			LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
			yield return null;
		}

	}
}
