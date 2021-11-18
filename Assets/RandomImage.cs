using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomImage : MonoBehaviour {

    public Sprite[] images = new Sprite[4];
    Image imageObject;
    // Start is called before the first frame update


    
    void Start() {

        imageObject = gameObject.GetComponent<Image>();

        int r1 = Random.Range(0, 4);
        imageObject.sprite = images[r1];

    }

    // Update is called once per frame
    void Update() {

        //Debug.Log( Random.Range(0, 4) );


    }
}
