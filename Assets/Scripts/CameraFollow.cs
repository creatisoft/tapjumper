using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform playerObject;

    Vector3 velocityx = Vector3.zero;
    Vector3 targetPosition;

    // Use this for initialization

    void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {

        //target position
        targetPosition = new Vector3 ( playerObject.position.x , 0 , -10 );

        transform.position = Vector3.SmoothDamp ( transform.position , targetPosition , ref velocityx , 0.6f );

	}
}
