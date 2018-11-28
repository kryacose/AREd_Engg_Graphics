using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.Sockets;
using System.Net;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class EnterEmail : MonoBehaviour {

	string CreateUserURL ="http://radicals-ar-ed.000webhostapp.com/Login_.php" ;

	public Text email, Message;
	string data;

	public void ButtonCheck()
	{
		StartCoroutine(DateCheck());
	}
		

	IEnumerator CheckEmail(string email){
		WWWForm form = new WWWForm ();
		form.AddField ("emailPost", email);

		WWW www = new WWW (CreateUserURL, form);
		yield return www;
		data = www.text;
		print (data);
		Message.text = data;
		char[] charsToTrim = { ' ', '\t' };
		string result = data.Trim(charsToTrim);
		string active = "Activated";
		if (result == active) {
			PlayerPrefs.SetString ("UserEmail", email);
			SceneManager.LoadScene ("Menu");
			print ("Enter Menu");
			PlayerPrefs.SetInt ("App_Activation", 1);
		} else
			print ("Error");
	}

	IEnumerator DateCheck(){
		WWW onlineDate = new WWW ("http://radicals-ar-ed.000webhostapp.com/Time.php");
		yield return onlineDate;
		string onlineDateS = onlineDate.text;
		char[] charsToTrim = { ' ', '\t'};
		string result = onlineDateS.Trim(charsToTrim);
		//DateTime Now = DateTime.Parse (result);
		DateTime Now = Convert.ToDateTime(result);
		DateTime sysDate = System.DateTime.Today;
		if (Now != sysDate) {
			print ("Correct your System Date");
			Message.text = "Correct your System Date";
			 
		}
		else if (Now == sysDate){
			print ("Date Verified");
			if(email.text.ToString() != null )
				StartCoroutine(CheckEmail( email.text.ToString()));
			else 
				Message.text = "Enter your Emial ID";
		}
		
			
	}
}
