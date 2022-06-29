using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class Week04Q1 : MonoBehaviour
    {
        [SerializeField] private int snickersLeft = 1;

        private void Start()
        {
            Surprise();
            Surprise();
        }

        public void Surprise()
        {
            if(snickersLeft > 0)
            {
                snickersLeft -= 1;
            }
            else
            {
                Debug.Log("Aaron is now sad.");
            }
        }
    }
}
