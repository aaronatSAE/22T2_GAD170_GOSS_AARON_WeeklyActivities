using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AaronGoss
{
    public class MainMenuManager : MonoBehaviour
    {
        // We need some references to our menu panels
        // We want our panels to be set active/inactive when we click certain buttons

        [SerializeField] private GameObject mainMenuPanel;
        [SerializeField] private GameObject creditsPanel;

        /// <summary>
        /// Sets the main menu panel to active, and the credits panel to inactive.
        /// </summary>
        public void ShowMainMenuPanel()
        {
            mainMenuPanel.SetActive(true);
            creditsPanel.SetActive(false);
        }

        /// <summary>
        /// Sets the main menu panel to inactive, and the credits panel to active.
        /// </summary>
        public void ShowCreditsPanel()
        {
            mainMenuPanel.SetActive(false);
            creditsPanel.SetActive(true);
        }

        public void StartGame()
        {
            Debug.Log("Starting the game!");

            SceneManager.LoadScene(1);
        }

        public void QuitGame()
        {
            Debug.Log("Quitting the game!");

            Application.Quit();
        }
    }
}
