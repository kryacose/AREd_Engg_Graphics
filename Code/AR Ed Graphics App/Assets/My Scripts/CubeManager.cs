using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeManager : MonoBehaviour {

	public GameObject shape,panel,sectionPlane;
	public Text length,cuttingPlaneAngle,cuttingPlaneHeight;
	public Toggle cuttingPlane; 
	public void Length()
	{
		float num = float.Parse (length.text);
        num /= 5;
		shape.transform.localScale = new Vector3 (num,num,num);
	}

	public void CuttingPlaneToggle()
	{
		if (cuttingPlane.isOn)
			
			panel.SetActive (true);
		else
			panel.SetActive (false);
	}

	public void AfterSectioniongHeight()
	{
		float num1 = float.Parse (cuttingPlaneHeight.text);
        num1 /= 5;
		//float num1 = System.Convert.ToSingle(cuttingPlaneHeight); 
		num1 *=100;
		sectionPlane.transform.position += new Vector3 (0,num1,0);
		sectionPlane.SetActive (true);
	}

	public void AfterSectioningAngle()
	{
		float num2 = float.Parse (cuttingPlaneAngle.text);
		sectionPlane.transform.Rotate (0, 0, num2);
	}

}
