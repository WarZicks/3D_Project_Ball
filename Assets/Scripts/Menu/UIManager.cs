﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


   public void OnClickPlay (string Play)
    {
        SceneManager.LoadScene(Play);
    }

    public void OnClickCredits(string Credits)
    {
        SceneManager.LoadScene(Credits);
    }

    public void OnClickExit ()
    {
        Application.Quit();
    }
}