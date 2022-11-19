using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public string scene_name;

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Switch()
    {
        SceneManager.LoadScene(scene_name, LoadSceneMode.Single);
    }
}
