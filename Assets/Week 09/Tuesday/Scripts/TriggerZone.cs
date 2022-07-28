using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class TriggerZone : MonoBehaviour
    {
        public delegate void TriggerAction();
        public static event TriggerAction OnTrigger;

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Hey! A " + other.name + " has triggered this Trigger Zone!");

            //other.transform.position = new Vector3(0, 6, 0);

            if(OnTrigger != null)
            {
                OnTrigger();
            }
        }
    }
}
