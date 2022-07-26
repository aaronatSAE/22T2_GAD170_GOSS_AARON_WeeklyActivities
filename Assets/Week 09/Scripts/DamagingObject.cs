using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class DamagingObject : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if(collision.gameObject.GetComponent<Health>() != null)
            {
                collision.gameObject.GetComponent<Health>().health -= 10;
                // Check if hero has <= 0 health, then destroy them if they do
                if(collision.gameObject.GetComponent<Health>().health <= 0)
                {
                    Destroy(collision.gameObject);
                }
            }
        }
    }
}
