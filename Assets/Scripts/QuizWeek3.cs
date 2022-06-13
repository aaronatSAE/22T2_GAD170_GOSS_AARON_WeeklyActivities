using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class QuizWeek3 : MonoBehaviour
    {
        //[SerializeField] private int randomInt = 0;

        //private void Start()
        //{
        //    randomInt = Random.Range(0, 10);
        //}

        //[SerializeField] private float randomFloat = 0;

        //private void Start()
        //{
        //    randomFloat = Random.Range(0f, 10f);
        //}


        //[SerializeField] private int snickersCount = 0;

        //private void Start()
        //{
        //    if (snickersCount > 2)
        //    {
        //        Debug.Log("That's satisfying!");
        //    }
        //}

        [SerializeField] private int snickersToPurchase = Random.Range(0, 10);
        [SerializeField] private int marsToPurchase = Random.Range(0, 10);
        [SerializeField] private int jawbreakersToPurchase = Random.Range(0, 10);

        private void Start()
        {
            if (snickersToPurchase > 2 && (marsToPurchase <= 1 || jawbreakersToPurchase >= 5))
            {
                Debug.Log("That's a lot of Snickers and Jawbreakers!");
            }
        }
    }
}
