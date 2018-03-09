using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VictoryMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void NextLevl()
    {
        SceneManager.LoadScene("Main_menu");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Main_menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
