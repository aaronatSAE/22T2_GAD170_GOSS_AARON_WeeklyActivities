using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class Week04Q5 : MonoBehaviour
    {
        public void Surprise()
        {
            int a = 5;
            int b = 0;

            if (a > 3)
            {
                b = 7;
            }

            Debug.Log("Integer a = " + a + ". Integer b = " + b);
        }
    }
}
