using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour {

	public GameObject loadingScreenObj;
	public Slider slider;

	AsyncOperation async;

	public void LoadScreen(string level)
	{
		StartCoroutine (LoadingScreen (level));
	}

	IEnumerator LoadingScreen(string level)
	{
		loadingScreenObj.SetActive (true);
		async = SceneManager.LoadSceneAsync (level);
		async.allowSceneActivation = false;

		while (async.isDone == false)
		{
			slider.value = async.progress;
			if (async.progress == 0.9f)
			{
				slider.value = 1.0f;
				async.allowSceneActivation = true;
			}
			yield return null;
		}
	}
}
