using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class Scaler : MonoBehaviour
    {
        [SerializeField] private bool returnToNormal = false;

        private void OnEnable()
        {
            EventManager.OnClicked += Scale;
        }

        private void OnDisable()
        {
            EventManager.OnClicked -= Scale;
        }

        private void Scale()
        {
            Vector3 newScale = new Vector3(Random.value, Random.value, Random.value);
            transform.localScale = newScale;
        }

        #region Other Fanciness
        private void Update()
        {
            if (returnToNormal)
            {
                transform.localScale += (Vector3.one - transform.localScale) * Time.deltaTime;
            }
        }
        #endregion
    }
}
