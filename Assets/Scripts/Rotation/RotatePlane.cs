using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Vertical") * Time.deltaTime * 30.0f;
        transform.Rotate(x, 0, 0);

        var y = Input.GetAxis("Horizontal") * Time.deltaTime * 30.0f;
        transform.Rotate(0, 0 , -y);
    }
}
