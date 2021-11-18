using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    private const int numberOfBallons = 64;
    public const int numberOfBallonObjects = 2;

    public GameObject[ ] publicGameObjects = new GameObject[ numberOfBallonObjects ];
    private GameObject[] privateGameObjects = new GameObject[ numberOfBallons ];

    private const int magicNumberForward = -1;

    int connectedXAnchor = -2;
    int connectedYAnchor = 1;
    // Use this for initialization

    void Start () {

        for(int i = 0 ; i < privateGameObjects.Length ; i++ ) {

            int r = Random.Range ( 0 , 3 );


            privateGameObjects[i] = Instantiate ( publicGameObjects[ r ] );
            privateGameObjects[i].SetActive ( false );

        }


        InvokeRepeating ("JumpSpawnForward", 0 , 0.88f );
    }

    private void SpawnPlatform ( ) {

        for ( int i = 0 ; i < privateGameObjects.Length ; i++ ) {

            if ( privateGameObjects[ i ].activeInHierarchy == false ) {

                privateGameObjects[ i ].SetActive ( true );
                privateGameObjects[ i ].transform.position = transform.position;
                privateGameObjects[ i ].transform.rotation = transform.rotation;
                

                privateGameObjects[i].gameObject.GetComponent<DistanceJoint2D>().connectedAnchor = new Vector2( connectedXAnchor , connectedYAnchor);

                break;
            }

        }

    }

    private void JumpSpawnForward ( ) {


        SpawnPlatform();    

        Vector2 currentlocation = transform.position;
        currentlocation.x = (currentlocation.x - magicNumberForward);

        transform.position = new Vector2 ( currentlocation.x , 0.15f );
        connectedXAnchor = connectedXAnchor + 1;
        connectedYAnchor = 1;

    }

    // Update is called once per frame
    void Update () {



	}
}
