using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace AaronGoss
{
    public class ResetCounter : MonoBehaviour
    {
        // we need to have a COUNTER...
        [SerializeField] private TextMeshProUGUI resetCounterUI;
        [SerializeField] private int resetCount = 0;

        // ...and we need to increase the counter's value every time the marble resets.

        // We need to start and stop listening to the OnMarbleReset event
        private void OnEnable()
        {
            MarbleCatcher.OnMarbleReset += IncreaseResetCount;
        }

        private void OnDisable()
        {
            MarbleCatcher.OnMarbleReset -= IncreaseResetCount;
        }

        // when the OnMarbleReset event is announced...
        private void IncreaseResetCount()
        {
            // ...we want to increase the counter's value
            resetCount++;
            resetCounterUI.text = resetCount.ToString();
        }
    }
}
