using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGestion : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("PlayMenu", LoadSceneMode.Single);
    }

    public void OptionGame()
    {
        SceneManager.LoadScene("OptionMenu", LoadSceneMode.Single);
    }

    public void ProfileGame()
    {
        SceneManager.LoadScene("ProfileMenu", LoadSceneMode.Single);
    }
}