using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class WeekThreeActivities : MonoBehaviour
    {
        private string firstName = "Aaron";
        private string lastName = "Goss";

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("My name is: " + firstName + " " + lastName);
            PowerLevel(10, 8, 11);
        }

        void PowerLevel(int strength, int agility, int intelligence)
        {
            // sum of strength * 2 plus the agility * 1.5 and adds intelligence
            int result = 0;
            result = (int)(strength * 2 + agility * 1.5f + intelligence);

            Debug.Log("Power level: " + result);
        }
    }
}
