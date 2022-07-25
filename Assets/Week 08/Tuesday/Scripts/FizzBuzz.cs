using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FizzBuzz : MonoBehaviour
{
    void Start()
    {
        FizzBuzzGeniuses();
        FizzBuzzNotGeniuses();
    }

    private void FizzBuzzGeniuses()
    {
        for (int i = 1; i < 101; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("FizzBuzz!");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz!");
            }
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz!");
            }
            else
            {
                Debug.Log(i);
            }
        }
    }

    private void FizzBuzzNotGeniuses()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 != 0)
            {
                Debug.Log("Fizz");
            }
            else if (i % 5 == 0 && i % 3 != 0)
            {
                Debug.Log("Buzz");
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else
            {
                Debug.Log(i);
            }
        }
    }
}
