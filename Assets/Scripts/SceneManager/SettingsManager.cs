using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
 
public class SettingsManager : MonoBehaviour
{
    public Button button;
    public Sprite image1;
    public Sprite image2;

    public void SwitchImage() 
    {
        button.GetComponent<Image>().sprite = image1;
    }
}
