using System;
using TMPro;
using UnityEngine;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;

    private int score = 0;

    public TextMeshProUGUI scoreText;


    // Disponibilizamos la instancia para que sea accesible desde cualquier Script
    private void Awake()
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
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public void SumarPuntos()
    {
        try
        {
            score++;
            scoreText.text = "Puntos: " + score.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public int getPuntos()
    {
        try
        {
            return score;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public void setPuntos(int _puntos)
    {
        try
        {
            score = _puntos;
            scoreText.text = "Puntos: " + score.ToString();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}
