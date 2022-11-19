
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class Interpreter : MonoBehaviour
{
    Process process = null;
    
    StreamWriter messageStream;

    private PlayerMotor _playerMotor;

    public Interfacing interfacing;

    public InputField textField;

    private readonly string _interpreter =
        "\\..\\..\\Interpreter\\main.py";

    private readonly string _stash =
        "\\BattleScriptAssets\\Resources\\stash.amn";

    private const string Stash = "Assets/BattleScriptAssets/Resources/stash.amn";

    public void SendConsoleTextToInterpreter()
    {
        try
        {
            Debug.Log("STEP1");
            StreamWriter writer = new StreamWriter(Stash, false);
            writer.Write(textField.text);
            writer.Close();
            Debug.Log("STEP2");

            StringBuilder interpreterReturn = new StringBuilder();

            Debug.Log("STEP3");
            
            process = new Process();
            process.StartInfo.FileName = "python3";
            process.StartInfo.Arguments = Application.dataPath + _interpreter + " " + Application.dataPath + _stash;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.Start();
            process.BeginOutputReadLine();
            process.OutputDataReceived +=
                new DataReceivedEventHandler((sender, e) =>
                {
                    if (e.Data != null)
                    {
                        Debug.Log("STEP4");
                        interpreterReturn.AppendLine(e.Data);
                        
                    }
                });
            process.WaitForExit();
            
            Debug.Log(interpreterReturn);
            using (StringReader reader = new StringReader( interpreterReturn.ToString() )) 
            { 
                
                for (string line; (line = reader.ReadLine()) != null; ) 
                { 
                    interfacing.InterfaceFunction(line);
                } 
            }

            Debug.Log("Successfully launched app");
        }
        catch (Exception e)
        {
            Debug.LogError("Unable to launch app: " + e.Message);
        }
    }
}