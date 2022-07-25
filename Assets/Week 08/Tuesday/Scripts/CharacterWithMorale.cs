using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class CharacterWithMorale : MonoBehaviour
    {
        public int health = 100;
        public int morale = 100;

        private void Update()
        {
            if(morale <= 50)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }
}
