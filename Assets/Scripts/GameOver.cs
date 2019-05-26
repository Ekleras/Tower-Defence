using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public Text roundsText;
    public SceneFader sceneFader;
    public string menuSceneName = "MainMenu";

    // Kiek isgyvneo roundu.
    private void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }

    // onClickas eventas
    public void Retry()
    {
        sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }

    // onClickas eventas
    public void Menu()
    {
        sceneFader.FadeTo(menuSceneName);
    }
}
