using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class EventManager : MonoBehaviour
    {
        // Create a delegate type named ClickAction. It must have no parameters (),
        // and a return type of void.
        public delegate void ClickAction();

        // Create our event variable. This is static, so that we can use it
        // outside of the class without instantiating an object of this class.
        // Our event variable, which we have named OnClicked, is of the type
        // of the delegate that we created above.
        public static event ClickAction OnClicked;

        private void OnGUI()
        {
            // Create a button on the screen.
            // By declaring a GUI.Button as if it were a function, it will be called when clicked.
            if(GUI.Button(new Rect(Screen.width/2-50, 5, 100, 30), "Click"))
            {
                // If we invoke an event with no subscribers, we will cause an error.
                // Therefore, we should always make sure that the event does not equal null before invoking it.
                if(OnClicked != null)
                {
                    // Call our event!
                    OnClicked();
                }
            }
        }
    }
}
