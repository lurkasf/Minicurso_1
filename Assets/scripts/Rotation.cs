﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
    public float x;
    public float y;
    public float z;
    // Update is called once per frame
    void Update () {
        transform.Rotate(new Vector3(x,y,z)*Time.deltaTime);
	}
}
