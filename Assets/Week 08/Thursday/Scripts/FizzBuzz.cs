using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class FizzBuzz : MonoBehaviour
    {
        void Start()
        {
            for (int i = 1; i <= 100; i++)
            {
                string output = "";

                if (i % 3 == 0) { output += "Fizz"; }
                if (i % 5 == 0) { output += "Buzz"; }
                if (i % 7 == 0) { output += "Brrr"; }

                if (output == "") { output += i; }

                Debug.Log(output);
            }
        }
    }
}
