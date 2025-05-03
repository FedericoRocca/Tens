using System;
using UnityEngine;

public class MonedaMenu : MonoBehaviour
{
    private Transform moneda;

    public float rotationSpeed = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            moneda = GetComponent<Transform>();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            rotation();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void rotation()
    {
        try
        {
            moneda.Rotate(0, 0, 1*rotationSpeed);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
