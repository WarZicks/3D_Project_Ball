using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseRestart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*if (transform.position.y <= -40)
        {
            Application.LoadLevel(Application.loadedLevel);
        }*/
    }

    private void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
