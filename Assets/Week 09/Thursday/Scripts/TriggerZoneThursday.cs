using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class TriggerZoneThursday : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Hello from the trigger zone!" + other.gameObject.name);

            // we want to move the falling sphere UP a bit, so it falls again
            // let's try setting the transform position
            other.gameObject.transform.position = new Vector3(0, 6, 0);
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}

