using System;
using UnityEngine;

public class menuJugar : MonoBehaviour
{
    public void exit()
    {
        try
        {
            sessionManager.instance.saveData();
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
