using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CustomRPR : MonoBehaviour {

	public Transform LoadingBar;
	public Transform TextIndicator;
	public Transform TextLoading;
	private float currentAmount;
	public GameObject preservedObj;
	//[SerializeField] private float speed;
	public Canvas loadingCanvas;
	GameObject[] gos;
	public GameObject loadingScreenObj;
	AsyncOperation async;

	/*void Start () {

		gos = GameObject.FindGameObjectsWithTag("Active UI");

	}*/


	/*public void ButtonPressSound()
	{
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();	
	}*/


	public void PreservedOoj()
	{
		if (preservedObj!=null)
			DontDestroyOnLoad (preservedObj.transform.gameObject);
	}

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
		loadingScreenObj.SetActive (true);
		async = SceneManager.LoadSceneAsync (level);
		async.allowSceneActivation = false;

		while (async.isDone == false) {
			currentAmount = async.progress * 100;
			TextIndicator.GetComponent<Text> ().text = ((int)currentAmount).ToString () + "%";
			TextLoading.gameObject.SetActive (true);
			if (async.progress == 0.9f) {
				currentAmount = 1.0f*100;
				TextLoading.gameObject.SetActive (false);
				async.allowSceneActivation = true;
				TextIndicator.GetComponent<Text> ().text = "DONE!";
			}
			LoadingBar.GetComponent<Image> ().fillAmount = currentAmount / 100;
			yield return null;
		}

	}
}
