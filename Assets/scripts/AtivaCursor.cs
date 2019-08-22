using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivaCursor : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (!Cursor.visible)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
