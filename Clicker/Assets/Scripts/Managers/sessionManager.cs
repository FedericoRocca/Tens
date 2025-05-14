using System;
using UnityEngine;

public class sessionManager : MonoBehaviour
{
    public static sessionManager instance;

    void Start()
    {
        try
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
            loadData();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void saveData()
    {
        try
        {
            PlayerPrefs.SetInt("puntaje", scoreManager.instance.getPuntos());
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void loadData()
    {
        try
        {
            scoreManager.instance.setPuntos(PlayerPrefs.GetInt("puntaje"));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
