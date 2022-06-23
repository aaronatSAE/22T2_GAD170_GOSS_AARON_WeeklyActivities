using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class Week04Q3 : MonoBehaviour
    {
        [SerializeField] private int snickersLeft = 1;

        private void Start()
        {
            snickersLeft += Surprise(snickersLeft);
            snickersLeft += Surprise(snickersLeft);
        }

        public int Surprise(int numberToCheck)
        {
            if(numberToCheck > 0)
            {
                Debug.Log("numberToCheck = " + numberToCheck + " before returning -1.");
                Debug.Log("snickersLeft = " + snickersLeft);
                return -1;
            }
            else
            {
                Debug.Log("Aaron is now sad.");
                return 0;
            }
        }
    }
}
