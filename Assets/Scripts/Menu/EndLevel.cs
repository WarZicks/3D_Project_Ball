using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour {

    public static bool PlayerWin = false;

    public GameObject winMenuUI;

    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerWin = true;

            winMenuUI.SetActive(true);
            Time.timeScale = 0f;
            PlayerWin = true;

            Destroy(Player);
        }
    }

}
