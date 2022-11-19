using System.Text.RegularExpressions;
using UnityEngine;


public class Interfacing : MonoBehaviour
{
    public PlayerMotor player;

    public void InterfaceFunction(string value)
    {
        string strippedValue = Regex.Replace(value, @"\s", "");
        switch (strippedValue)
        {
            case "MoveUp":
                Debug.Log("On Move Up :)");
                player.MoveUp();
                break;
            case "MoveDown":
                Debug.Log("On Move Down :)");
                player.MoveDown();
                break;
            case "MoveLeft":
                Debug.Log("On Move Left :)");
                player.MoveLeft();
                break;
            case "MoveRight":
                Debug.Log("On Move Right :)");
                player.MoveRight();
                break;
            default:
                Debug.Log("A afficher en PRINT");
                break;
        }
    }
}