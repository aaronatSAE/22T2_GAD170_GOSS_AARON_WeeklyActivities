using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class TeleportingObject : MonoBehaviour
    {
        private Vector3 teleportLocation;

        private void OnEnable()
        {
            // Start listening to our "Space Bar Press" event
            EventManagerThursday.OnClicked += Teleport;
        }

        private void OnDisable()
        {
            // Stop listening to our "Space Bar Press" event
            EventManagerThursday.OnClicked -= Teleport;
        }

        private void Start()
        {
            teleportLocation = transform.position;
        }

        private void Teleport()
        {
            transform.position = teleportLocation;
        }
    }
}
