using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PrinText : MonoBehaviour
{
    public Canvas canva;
    public TextMeshProUGUI textmesh;

    public void PrintText(string text)
    {
        canva.GetComponent<Canvas>().enabled = true;
        textmesh.text = text;
        StartCoroutine(WaitForText());
    }

    IEnumerator WaitForText()
    {
        yield return new WaitForSeconds(2);
        canva.GetComponent<Canvas>().enabled = false;
    }
}
