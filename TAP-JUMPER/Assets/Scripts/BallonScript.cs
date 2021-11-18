using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonScript : MonoBehaviour {


    private float upwardSpeedForce = 1.0f;
    private float maxVelocity = 1.0f;
    public float floatSpeed = 1.0f;
    private Rigidbody2D myRigidBody2D;

    // Use this for initialization
    void Start ( ) {

        myRigidBody2D = gameObject.GetComponent<Rigidbody2D> ( );

    }

    void OnEnable ( ) {

        Invoke ( "Destroy" , 6.2f );

    }

    void OnDisable ( ) {

        CancelInvoke ( "Destroy" );

    }

    void Destroy ( ) {

        this.gameObject.SetActive ( false );

    }

    void FixedUpdate ( ) {


        myRigidBody2D.AddForce ( upwardSpeedForce * transform.up , ForceMode2D.Impulse );
        
        //Debug.Log ( myRigidBody2D.velocity.y );

        if ( myRigidBody2D.velocity.y > maxVelocity ) {
            myRigidBody2D.velocity = myRigidBody2D.velocity.normalized * floatSpeed;
        }

  

    }


    // Update is called once per frame
    void Update () {
		
	}
}
