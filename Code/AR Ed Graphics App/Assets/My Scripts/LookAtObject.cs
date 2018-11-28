using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour {

    public GameObject target;//the target object
    GameObject firstActiveGameObject;
    private float speedMod = 10.0f;//a speed modifier
    private Vector3 point;//the coord to the point where the camera looks at

    // Use this for initialization
    void Start () {
        for (int i = 0; i < target.gameObject.transform.childCount; i++)
        {
            if (target.gameObject.transform.GetChild(i).gameObject.activeSelf == true)
            {
                firstActiveGameObject = target.transform.GetChild(i).gameObject;
            }
        }
        //point = firstActiveGameObject.transform.position;//get target's coords
        point = firstActiveGameObject.transform.GetChild(0).position;
        transform.LookAt(point);//makes the camera look to it
    }
	
	// Update is called once per frame
	void LateUpdate () {
        transform.LookAt(point);
    }
}
