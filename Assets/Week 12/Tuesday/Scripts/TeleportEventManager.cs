using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class TeleportEventManager : MonoBehaviour
    {
        public delegate void TeleporterActivationAction();
        public static event TeleporterActivationAction OnTeleporterActivation;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if(OnTeleporterActivation != null)
                {
                    OnTeleporterActivation();
                }
            }
        }
    }
}
