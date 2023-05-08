using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsSC : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settings;
    public void BackToMainMenu()
    {
        mainMenu.SetActive(true);
        settings.SetActive(false);
    }
}
