using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string levelToLoad = "MainLevel";
    public SceneFader sceneFader;

    // onClick eventas.
	public void Play()
    {
        sceneFader.FadeTo(levelToLoad);
    }

    // irgi onClick eventas.
    public void Quit()
    {
        Debug.Log("Exiting");
        Application.Quit();
    }

    // Same here
    public void Settings()
    {
        sceneFader.FadeTo("Settings");
    }

    // Same
    public void Menu()
    {
        sceneFader.FadeTo("MainMenu");
    }
}
