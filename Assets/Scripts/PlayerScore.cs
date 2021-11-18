using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScore : MonoBehaviour {

    public Text scoreText;
    private AudioSource aSource;
    int ourScore = 0;
    // Start is called before the first frame update

    public int AddPoint() {

        ourScore = ourScore + 1;
        aSource.Play();
        return ourScore;

    }




    void Start() {
        aSource = gameObject.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update() {

        scoreText.text = "Score: " + ourScore.ToString();

    }
}
