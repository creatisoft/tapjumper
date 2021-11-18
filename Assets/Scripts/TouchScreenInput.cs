using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScreenInput : MonoBehaviour {
    // Start is called before the first frame update

    bool screenWasTapped = false;

    void Start(){
        

    }

    // Update is called once per frame
    void Update() {
        
        if(Input.touchCount > 0) {

            Touch touchin = Input.GetTouch(0);

            if( touchin.tapCount == 1 && touchin.phase == TouchPhase.Began) {

                //Debug.Log("Screen was tapped once");
                screenWasTapped = true;

            }else if (touchin.phase == TouchPhase.Stationary) {

                //Debug.Log("finger is stationary");
                screenWasTapped = false;

            } else if (touchin.phase == TouchPhase.Ended) {

                //Debug.Log("finger is stationary");
                screenWasTapped = false;

            }


        }

    }

    public bool ScreenTap() {

        return screenWasTapped;

    }
}
