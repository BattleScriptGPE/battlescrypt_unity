using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGestion : MonoBehaviour
{

    public GameObject popUpWarning;


    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }


    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void EnablePopUp()
    {
        if (popUpWarning.activeSelf == true)
        {
            popUpWarning.SetActive(false);
        }
        else
        {
            popUpWarning.SetActive(true);
        }
    }
}
