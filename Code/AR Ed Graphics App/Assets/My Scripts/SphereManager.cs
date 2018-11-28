using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereManager : MonoBehaviour {

	public GameObject shape,panel,sectionPlane;
	public Text radius,cuttingPlaneAngle,cuttingPlaneHeight;
	public Toggle cuttingPlane; 
	float num1,num2;

	Vector3 cuttingPlaneloc;

	void start()
	{
		//cuttingPlaneloc = sectionPlane.transform.position;
		num2 = 0.0f;
	}

	public void ShapedDimenstionRadius()
	{
		num1 = float.Parse (radius.text);
        num1 /= 5;
		shape.transform.localScale = new Vector3 (num1,num1,num1);
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
		if (num2 != 0)
			//sectionPlane.transform.position -= new Vector3 (0,num1,0);
		num2 = float.Parse (cuttingPlaneHeight.text);
        num2 /= 5;
        //float num1 = System.Convert.ToSingle(cuttingPlaneHeight); 
        num1 *=100;
		//sectionPlane.transform.position = cuttingPlaneloc;
		sectionPlane.transform.position += new Vector3 (0,num1,0);
		if (!sectionPlane.active)
			sectionPlane.SetActive (true);
	}

	public void AfterSectioningAngle()
	{
		float num2 = float.Parse (cuttingPlaneAngle.text);
		sectionPlane.transform.Rotate (0, 0, num2);
	}
}
