using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blueballon : MonoBehaviour {

    public float upwardSpeedForce = 1.0f;
    private float maxVelocity = 1.0f;
    private Rigidbody2D myRigidBody2D;

	// Use this for initialization
	void Start () {

        myRigidBody2D = gameObject.GetComponent<Rigidbody2D> ( );
        
	}

    void FixedUpdate ( ) {

        myRigidBody2D.AddForce ( upwardSpeedForce * transform.up , ForceMode2D.Impulse );
        //Debug.Log ( myRigidBody2D.velocity.y );

        if ( myRigidBody2D.velocity.y > maxVelocity ) {
            myRigidBody2D.velocity = myRigidBody2D.velocity.normalized * 2.0f;
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
