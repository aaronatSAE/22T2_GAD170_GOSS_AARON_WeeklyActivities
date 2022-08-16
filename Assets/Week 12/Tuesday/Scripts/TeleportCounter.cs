using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace AaronGoss
{
    public class TeleportCounter : MonoBehaviour
    {
        // For our events system we need these things:
        // Announce the event at particular times or when a particular collision occurs, etc...
        // We want to make sure our UI is LISTENING for the event.
        // When the event is announced, we want to update our UI.

        [SerializeField] private TextMeshProUGUI teleportCounter;
        [SerializeField] private int teleportCount = 0;

        private void OnEnable()
        {
            TeleportEventManager.OnTeleporterActivation += IncreaseTeleportCount;
        }

        private void OnDisable()
        {
            TeleportEventManager.OnTeleporterActivation -= IncreaseTeleportCount;
        }

        private void IncreaseTeleportCount()
        {
            teleportCount++;
            teleportCounter.text = "Teleporters Used: " + teleportCount;
        }
    }
}
