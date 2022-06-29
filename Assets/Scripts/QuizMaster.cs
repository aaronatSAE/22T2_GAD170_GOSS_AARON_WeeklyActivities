using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class QuizMaster : MonoBehaviour
    {
        [SerializeField] private Week04Q1 q1;
        [SerializeField] private Week04Q2 q2;
        [SerializeField] private Week04Q3 q3;

        // Start is called before the first frame update
        void Start()
        {
            q1.Surprise();
            q2.Surprise(1);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}