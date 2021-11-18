using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {

    private Rigidbody2D myRigidBody2D;

    private AudioSource aSource;
    bool isJumping = false;
    bool playerOnTheFloor = true;
    bool screenWasTapped;

    public PlayerScore playerScore;

    public TouchScreenInput tScreenInput;
	
    // Use this for initialization
	void Start () {

        myRigidBody2D = gameObject.GetComponent<Rigidbody2D> ( );
        aSource = gameObject.GetComponent<AudioSource>();
	}


    public void JumpButton() {

        screenWasTapped = tScreenInput.ScreenTap();

        if ( playerOnTheFloor == true ) {

            //if ( playerOnTheFloor == true ) {

            myRigidBody2D.AddForce(Vector2.right * 1.24f, ForceMode2D.Impulse);
            myRigidBody2D.velocity += Vector2.up * 4.0f;
            playerOnTheFloor = false;

            //}
        }



    }

    void FixedUpdate ( ) {

        Debug.DrawRay(transform.position, Vector2.down * 0.22f, Color.blue);

        RaycastHit2D myRay2D = Physics2D.Raycast(transform.position, Vector2.down, 0.22f);

        if(myRay2D.collider != null) {

            if (myRay2D.transform.tag == "Floor") {

                //Debug.Log("Hitting the floor with the ray");
                playerOnTheFloor = true;

            } 
           
        } else {
            playerOnTheFloor = false;
        }





    }

    // Update is called once per frame
    void Update () {

        screenWasTapped = tScreenInput.ScreenTap();

        if ((Input.GetKeyDown(KeyCode.Space) || screenWasTapped == true) && playerOnTheFloor == true) {

            //if ( playerOnTheFloor == true ) {
            aSource.Play();
            myRigidBody2D.AddForce(Vector2.right * 1.24f, ForceMode2D.Impulse);
            myRigidBody2D.velocity += Vector2.up * 4.0f;
            playerOnTheFloor = false;

            //}
        }

    }

    public void OnTriggerEnter2D ( Collider2D collision ) {
        
        if(collision.gameObject.tag == "AddPoint" ) {

            playerScore.AddPoint();

            collision.gameObject.SetActive(false);

        }
    }
}
