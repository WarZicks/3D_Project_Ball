using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour {

    public float speed = 15f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Rotate(-x, 0, 0);

        var y = Input.GetAxis("Horizontal") * Time.deltaTime *speed;
        transform.Rotate(0, 0, -y);
    }
}
