using System;
using UnityEngine;
using Random = System.Random;

public class moneyJumper : MonoBehaviour
{
    public int maxJumpForce = 1;

    private Rigidbody rb;

    private Random rnd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            rb = GetComponent<Rigidbody>();
            rnd = new Random();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        try
        {
            rb.linearVelocity = new Vector3(rnd.Next(-maxJumpForce, maxJumpForce), rnd.Next(-maxJumpForce, maxJumpForce), rnd.Next(-maxJumpForce, maxJumpForce));
            scoreManager.instance.SumarPuntos();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
