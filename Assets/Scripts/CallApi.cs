using System.Collections;
using System.Collections.Generic;
using System.Net;
using System;
using System.IO;
using UnityEngine;

public class CallApi : MonoBehaviour
{
    private string URL_API = "http://localhost:8081/";

    private void Start()
    {
        testApi();
    }

    void testApi()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Format(URL_API));
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = reader.ReadToEnd();
        Debug.Log(jsonResponse);
    }
}
