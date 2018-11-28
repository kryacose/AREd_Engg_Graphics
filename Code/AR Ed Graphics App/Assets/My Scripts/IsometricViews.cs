using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsometricViews : MonoBehaviour {

	public string Img ;
	public static IsometricViews Iso;
	GameObject Target;
	public Vuforia.VuforiaImgTracking Vimg;
	public GameObject Q21, Q22, Q23, Q24;

	void start()
	{
		//VImg = GameObject.FindGameObjectsWithTag ("VImgRecog");
	}

	public void ActivateFigure ()
	{
		
		//if(Vuforia.VuforiaImgTracking.Vimg.RecoganisedImg() != null)
		//Img = VImg.

		Img = Vimg.RecoganisedImg();
		Debug.Log (Img);

		if (Img == "q21")
			Q21.SetActive (true);

		if (Img == "q22")
			Q22.SetActive (true);

		if (Img == "q23")
			Q23.SetActive (true);

		if (Img == "q24")
			Q24.SetActive (true);
	}

	public void DeavtivateFigure()
	{
		if (Q21.activeSelf)
			Q21.SetActive (false);

		if (Q22.activeSelf)
			Q22.SetActive (false);

		if (Q23.activeSelf)
			Q23.SetActive (false);

		if (Q21.activeSelf)
			Q24.SetActive (false);
	}
}