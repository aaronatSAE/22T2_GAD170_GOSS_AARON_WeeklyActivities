using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class CharacterWithMana : MonoBehaviour
    {
        public int maxHealth = 100;
        public int currentHealth;

        public int maxMana = 100;
        public int currentMana;

        private void Start()
        {
            Reset();
        }

        public void Reset()
        {
            currentHealth = maxHealth;
            currentMana = maxMana;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Enemy")
            {
                AdjustHealth(-20);
            }
            else if (other.tag == "Healing Potion")
            {
                AdjustHealth(10);
            }
        }

        public void AdjustHealth(int value)
        {
            currentHealth += value;
            // currentHealth = currentHealth - 20; (for our Enemy above)

            if (currentHealth > maxHealth)
            {
                // Character has more health than their max...
                // ...reset their health to max
                currentHealth = maxHealth;
            }
            else if (currentHealth <= 0)
            {
                // Character has no health left. OW
                Debug.Log("Ow!");
            }
        }
    }
}
