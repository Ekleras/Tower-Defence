using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool GameIsOver;
    public GameObject completeLevelUI;
    public GameObject gameOverUI;

    private void Start()
    {
        GameIsOver = false;
    }

    void Update () {

        if (GameIsOver)
            return;

        // E mygtukas = Game Over. Reiktu issimti is runtime turbut....
        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }

		if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
	}

    void EndGame()
    {
        GameIsOver = true;
        gameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        GameIsOver = true;
        if(PlayerPrefs.GetInt("highscore") < PlayerStats.Money)
        PlayerPrefs.SetInt("highscore", PlayerStats.Money);
        completeLevelUI.SetActive(true);
    }
}
