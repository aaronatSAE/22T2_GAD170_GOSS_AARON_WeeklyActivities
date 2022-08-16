using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class TriggerZoneAG : MonoBehaviour
    {
        [SerializeField] private AudioSource audioSourceToPlay;

        private void OnTriggerEnter(Collider other)
        {
            audioSourceToPlay.Play();
            Debug.Log("Audio has been played!");
        }
    }
}
