﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    public Transform bullet;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void InstantiateGameObject(UnityEngine.Object to_clone)
    {

        //for now, instantiate the object at 0, 0, 0. in future, check what kind of object it is and spawn appropriately accordingly.
        Instantiate(to_clone, new Vector3(0, 0, 0), Quaternion.identity);

    }
}