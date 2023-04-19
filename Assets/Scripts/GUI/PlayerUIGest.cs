using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUIGest : MonoBehaviour
{
    public GameObject text_field;
    public TMPro.TextMeshProUGUI text_field_data;

    public void Start()
    {
        try
        {
            text_field_data = text_field.GetComponent<TMPro.TextMeshProUGUI>();
        }
        catch
        {
            Debug.Log("Erreur lors de la récup du component");
        }
    }



    public void On_Click_Send()
    {

        Debug.Log("Player Send");
        Debug.Log(text_field_data.text.ToString());
    }

    public void On_Click_Clear()
    {
        text_field_data.text = "";
    }
}
