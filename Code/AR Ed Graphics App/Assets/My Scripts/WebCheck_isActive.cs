using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCheck_isActive : MonoBehaviour {

	public string[] items;
	string CreateUserURL ="http://radicals-ar-ed.000webhostapp.com/WebCheck_User.php" ;

	IEnumerator Start(){

		if (!(PlayerPrefs.HasKey ("Remote_terminate"))) 
		{
			PlayerPrefs.SetInt("Remote_terminate", 0);
		}

		if (!(PlayerPrefs.HasKey ("Remote_terminate_user"))) 
		{
			PlayerPrefs.SetInt("Remote_terminate_user", 0);
		}


		WWW itemsData = new WWW ("http://radicals-ar-ed.000webhostapp.com/WebCheck_.php");
		yield return itemsData;
		string itemsDataString = itemsData.text;
		char[] charsToTrim = { ' ', '\t' };
		string result = itemsDataString.Trim(charsToTrim);
		if (result == "1") {
			print ("It is Now Active");
			PlayerPrefs.SetInt ("Remote_terminate", 0);
		} else {
			print ("App has been TERMINATED");
			PlayerPrefs.SetInt ("Remote_terminate", 1);
		}

		string email = PlayerPrefs.GetString ("UserEmail");
		WWWForm form = new WWWForm ();
		form.AddField ("emailPost", email);

		WWW www = new WWW (CreateUserURL, form);
		yield return www;
		string data = www.text;
		string Kill = data.Trim(charsToTrim);
		if (Kill == "1") {
			PlayerPrefs.SetInt ("Remote_terminate_user", 1);
		} else
			PlayerPrefs.SetInt ("Remote_terminate_user", 0);
		


	}


}
