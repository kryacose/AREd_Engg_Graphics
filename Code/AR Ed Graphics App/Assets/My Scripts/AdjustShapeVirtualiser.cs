using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustShapeVirtualiser : MonoBehaviour {

	public GameObject shape;
	public Text length,breadth,height,radius,Base;
	public Text Out;
	float num1,num2,num3;

	public float MultiplicationFactor, MultiplicationFactor2;

	public void Length()
	{
		float num = float.Parse (length.text);
		shape.transform.localScale = new Vector3 (num*MultiplicationFactor,num*MultiplicationFactor,num*MultiplicationFactor);
	}

	public void ShapedDimenstionLenght()
	{
		num1 = float.Parse (length.text);
		shape.transform.localScale = new Vector3 (num1*MultiplicationFactor,1*MultiplicationFactor,1*MultiplicationFactor);
	}

	public void ShapedDimensionBreadth()
	{
		num2 = float.Parse (breadth.text);
		shape.transform.localScale = new Vector3 (num1*MultiplicationFactor,1*MultiplicationFactor,num2*MultiplicationFactor);
	}

	public void ShapeDimensionHeight()
	{
		 num3 = float.Parse (height.text);
		shape.transform.localScale = new Vector3 (num1*MultiplicationFactor,num3*MultiplicationFactor,num2*MultiplicationFactor);
	}

	public void ShapedDimenstionRadiusCyl()
	{
		num1 = float.Parse (radius.text);
		shape.transform.localScale = new Vector3 (num1*MultiplicationFactor,num3*MultiplicationFactor,num1*MultiplicationFactor);
	}

	public void ShapeDimensionHeightCyl()
	{
		num2 = float.Parse (height.text);
		shape.transform.localScale = new Vector3 (num1*MultiplicationFactor,num2*MultiplicationFactor,num1*MultiplicationFactor2);
	}

	public void ShapedDimenstionBase()
	{
		num1 = float.Parse (Base.text);
		shape.transform.localScale = new Vector3 (num1*MultiplicationFactor,1*MultiplicationFactor,num1*MultiplicationFactor);
	}

	public void ShapeDimensionHeightSqPy()
	{
		num2 = float.Parse (height.text);
		shape.transform.localScale = new Vector3 (num1*MultiplicationFactor,num2*MultiplicationFactor,num1*MultiplicationFactor);
	}
}
