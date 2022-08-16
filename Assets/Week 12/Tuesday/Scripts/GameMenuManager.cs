using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AaronGoss
{
    public class GameMenuManager : MonoBehaviour
    {
        // We need a game UI with some (or a) menu button/s to send the user to the main menu scene
        // We want to show the UI when we press the escape key (ESC)

        [SerializeField] private GameObject gameMenuPanel;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                // If our game menu panel is ACTIVE...
                if(gameMenuPanel.activeSelf == true)
                {
                    // ...HIDE it!
                    HideGameMenuPanel();
                }
                // Otherwise...
                else
                {
                    // SHOW it!
                    ShowGameMenuPanel();
                }
            }
        }

        /// <summary>
        /// Sets the game menu panel to active.
        /// </summary>
        public void ShowGameMenuPanel()
        {
            gameMenuPanel.SetActive(true);
        }

        /// <summary>
        /// Sets the game menu panel to active.
        /// </summary>
        public void HideGameMenuPanel()
        {
            gameMenuPanel.SetActive(false);
        }

        public void LoadScene(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
