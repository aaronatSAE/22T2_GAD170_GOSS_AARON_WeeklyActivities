using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class ColourChanger : MonoBehaviour
    {
        private void OnEnable()
        {
            EventManager.OnClicked += ChangeColour;
        }

        private void OnDisable()
        {
            EventManager.OnClicked -= ChangeColour;
        }

        private void ChangeColour()
        {
            Color newColour = new Color(Random.value, Random.value, Random.value);
            GetComponent<Renderer>().material.color = newColour;
        }
    }
}
