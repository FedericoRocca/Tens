using System;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = System.Random;

public class Coin : MonoBehaviour
{
    public int maxJumpForce = 250;
    private Transform coin;

    private Random rand;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            coin = GetComponent<Transform>();    
            rand = new Random();
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
        
    }

    void OnMouseOver()
    {
        try
        {
            if (Input.GetMouseButtonDown(0))
            {
                coin.transform.GetComponent<Rigidbody>().AddForce(rand.Next(-maxJumpForce/3, maxJumpForce/3), rand.Next(0, maxJumpForce), 0);
                coin.transform.GetComponent<Rigidbody>().AddTorque(rand.Next(-maxJumpForce/3, maxJumpForce/3), rand.Next(-maxJumpForce/3, maxJumpForce/3), rand.Next(-maxJumpForce/3, maxJumpForce/3));
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
