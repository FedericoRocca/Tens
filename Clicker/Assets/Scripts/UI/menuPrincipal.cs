using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipal : MonoBehaviour
{
    public void goJugar()
    {
        try
        {
            SceneManager.LoadScene("onPlay");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void exit()
    {
        try
        {
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
