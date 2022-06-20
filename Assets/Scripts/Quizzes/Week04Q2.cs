using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class Week04Q2 : MonoBehaviour
    {
        [SerializeField] private int snickersLeft = 1;

        private void Start()
        {
            Surprise(snickersLeft);
            Surprise(snickersLeft);
        }

        public void Surprise(int numberToCheck)
        {
            if(numberToCheck > 0)
            {
                numberToCheck -= 1;
            }
            else
            {
                Debug.Log("Aaron is now sad.");
            }
        }
    }
}
