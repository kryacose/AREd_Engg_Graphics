using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.Sockets;
using System.Net;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DateChecker : MonoBehaviour {

	public GameObject TEXTBOOK, SANDBOX, errorText;
	public Text ErrorText;
	int Deactive;

	// Use this for initialization
	void Start () {
		//DateCheck ();
		InvokeRepeating ("DateCheck", 1.0f, 10.0f);

		if (PlayerPrefs.HasKey ("App_Activation"))
			print ("");
		else 
			SceneManager.LoadScene ("StudentLogin");

		
	}

	void DateCheck()
	{
		int flag;
		int OLD;


		DateTime ExpiryDay = new DateTime(2020, 5, 21);
		double DaysToGo = (ExpiryDay - System.DateTime.Today).TotalDays;


		if (PlayerPrefs.HasKey ("OLD_DaysToGo")) 
		{
			OLD = PlayerPrefs.GetInt ("OLD_DaysToGo");
			if (OLD < (int)DaysToGo)
				flag = 0;
			else
				flag = 1;
		}

		else
			flag = 1;



		if (flag == 1)
		{
			if (DaysToGo <= 0) 
			{
				Deactivate ("Expired");
			}
			PlayerPrefs.SetInt("OLD_DaysToGo", (int) DaysToGo);
		}

		if (flag == 0)
		{
			Deactivate ("Date Change Detected");
		}
			

		if (Deactive != 1) {
			int status =  PlayerPrefs.GetInt ("Remote_terminate");
			int status_user =  PlayerPrefs.GetInt ("Remote_terminate_user");
			if (status == 1)
				Deactivate ("Remotely Terminated");
			
			else if (status_user == 1)
				Deactivate ("Remotely Terminated");
			else
				ActivateMenu ();
		}
	
	}



	void Deactivate(string Error)
	{
		Deactive = 1;
		errorText.SetActive (true);
		TEXTBOOK.SetActive (false);
		SANDBOX.SetActive (false);
		ErrorText.text = Error;
		MyShowToastMethod (Error);
		Debug.Log (Error);
	}

	void ActivateMenu(){
			int status = PlayerPrefs.GetInt ("App_Activation");
			if (status != 1) {
				Deactivate ("App has not been Activated");
			}
			else if (Deactive != 1) {
				Scene currentScene = SceneManager.GetActiveScene ();
				string sceneName = currentScene.name;

				if (sceneName != "Menu")
					SceneManager.LoadScene ("Menu");
				else 
				{
					TEXTBOOK.SetActive (true);
					SANDBOX.SetActive (true);
				}
				
			}			
	}

	string toastString;
	AndroidJavaObject currentActivity;

	public void MyShowToastMethod (string Toast)
	{
		if (Application.platform == RuntimePlatform.Android) {
			showToastOnUiThread (Toast);
		}
	}

	void showToastOnUiThread(string toastString){
		AndroidJavaClass UnityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");

		currentActivity = UnityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
		this.toastString = toastString;

		currentActivity.Call ("runOnUiThread", new AndroidJavaRunnable (showToast));
	}

	void showToast(){
		Debug.Log ("Running on UI thread");
		AndroidJavaObject context = currentActivity.Call<AndroidJavaObject>("getApplicationContext");
		AndroidJavaClass Toast = new AndroidJavaClass("android.widget.Toast");
		AndroidJavaObject javaString=new AndroidJavaObject("java.lang.String",toastString);
		AndroidJavaObject toast = Toast.CallStatic<AndroidJavaObject> ("makeText", context, javaString, Toast.GetStatic<int>("LENGTH_SHORT"));
		toast.Call ("show");
	}



}
