using System;
using UnityEngine;

public class MenuInGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quit()
    {
        try
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
