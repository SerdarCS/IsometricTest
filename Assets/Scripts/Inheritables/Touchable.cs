using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchable : MonoBehaviour {
    //Inheritable script for objects that respond to touch events

    public virtual void OnTouchDown() {
        //Override this method
        Debug.Log("Touched");
    }
}
