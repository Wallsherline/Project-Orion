using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settings;
    public void PlayGame ()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenSettings ()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
