using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class MarbleDestroyer : MonoBehaviour
    {
        [SerializeField] private MarbleManager marbleManager;

        private void OnTriggerEnter(Collider other)
        {
            // remove the marble from the list on the marble manager
            marbleManager.allMarbles.Remove(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
