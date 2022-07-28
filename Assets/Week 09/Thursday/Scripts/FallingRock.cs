using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class FallingRock : MonoBehaviour
    {
        public int rockDamage = 5;

        private void OnCollisionEnter(Collision collision)
        {
            collision.gameObject.GetComponent<PlayerHealth>().playerHealth -= rockDamage;
            // same thing as writing "...playerHealth = playerHealth - 5; (as below)
            //collision.gameObject.GetComponent<PlayerHealth>().playerHealth = collision.gameObject.GetComponent<PlayerHealth>().playerHealth - 5;
        }
    }
}
