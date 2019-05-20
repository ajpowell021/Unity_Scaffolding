using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassManager : MonoBehaviour {
    
    // Instance

    public static ClassManager instance = null;

    // Classes

    public InputManager inputManager;
    
    // Init

    private void Awake() {
        setInstance();
        setClasses();
    }
    
    // Private Functions

    private void setInstance() {
        if (instance == null) {
            instance = this;
        }
        else if (instance != null) {
            Destroy(this);
        }
    }

    private void setClasses() {
        inputManager = gameObject.GetComponent<InputManager>();
    }
}
