using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class VerticalPusher : MonoBehaviour
    {
        [SerializeField] private Vector3 pushForce;

        private void OnEnable()
        {
            EventManagerThursday.OnClicked += PushObjectUp;
        }

        private void OnDisable()
        {
            EventManagerThursday.OnClicked -= PushObjectUp;
        }

        private void PushObjectUp()
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().AddForce(pushForce);
        }
    }
}
