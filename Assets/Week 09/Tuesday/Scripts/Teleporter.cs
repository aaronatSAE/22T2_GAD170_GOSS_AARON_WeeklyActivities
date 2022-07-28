using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class Teleporter : MonoBehaviour
    {
        [SerializeField] private bool returnToNormal = false;

        /// <summary>
        /// Called whenever the object this script is attached to
        /// is created, or enabled, in a Scene.
        /// </summary>
        private void OnEnable()
        {
            // Subscribe our Teleport() method to the OnClicked event of the EventManager script.
            // We use the += operator to do this.
            // By subscribing a method to an event, we ensure that whenever the event occurs,
            // our method will be called.
            EventManager.OnClicked += Teleport;
        }
        
        /// <summary>
        /// Called whenever an object is disabled, or destroyed, in a Scene.
        /// </summary>
        private void OnDisable()
        {
            // Unsubscribe our method from the event using the -= operator.
            // This ensures that our method is no longer called when the event occurs.
            // This step is incredibly important, and failure to do so can lead to
            // memory leaks and errors in your game.
            // Whenever you subscribe to an event, you should have a corresponding unsubscribe.
            EventManager.OnClicked -= Teleport;
        }

        /// <summary>
        /// This is the method that we will be subscribing to the event that we created in the EventManager.
        /// It has no parameters, and a return type of void, just like our delegate.
        /// </summary>
        private void Teleport()
        {
            // Create a new Vector3 variable and assign it a random Vector3 value between (-1, -1, -1) to (1, 1, 1).
            Vector3 newPosition = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            // Set our transform position to our newPosition (which was randomly generated.
            transform.position = newPosition;
        }

        #region Other Fanciness
        private void Update()
        {
            if (returnToNormal)
            {
                transform.position += (Vector3.zero - transform.position) * Time.deltaTime;
            }
        }
        #endregion
    }
}
