using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMotor : MonoBehaviour
{
    public GameObject player;

    public void MoveUp()
    {
        Debug.Log("TEST1é");
        Vector3 movement = new Vector3(0, 0, 1f);
        Debug.Log("TEST2é");
        try
        {
            player.transform.Translate(movement);
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
        
        Debug.Log("TEST3é");
    }
    public void MoveDown()
    {
        Vector3 movement = new Vector3(0, 0, -1f);
        player.transform.Translate(movement);
    }
    public void MoveRight()
    {
        Vector3 movement = new Vector3(1f, 0, 0);
        player.transform.Translate(movement);
    }
    public void MoveLeft()
    {
        Vector3 movement = new Vector3(-1f, 0, 0);
        player.transform.Translate(movement);
    }

    private void Start()
    {
        MoveUp();
    }
    
}
