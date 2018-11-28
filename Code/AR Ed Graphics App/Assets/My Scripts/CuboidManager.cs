using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CuboidManager : MonoBehaviour {

	public GameObject shape,panel,sectionPlane;
	public Text length,breadth,height,cuttingPlaneAngle,cuttingPlaneHeight;
	public Toggle cuttingPlane; 
	float num1,num2,num3;

	public void ShapedDimenstionLenght()
	{
		num1 = float.Parse (length.text);
        num1 /= 5;
		shape.transform.localScale = new Vector3 (num1,1,1);
	}

	public void ShapedDimensionBreadth()
	{
		num2 = float.Parse (breadth.text);
        num2 /= 5;
		shape.transform.localScale = new Vector3 (num1,1,num2);
	}

	public void ShapeDimensionHeight()
	{
		num3 = float.Parse (height.text);
        num3 /= 5;
		shape.transform.localScale = new Vector3 (num1,num3,num2);
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
