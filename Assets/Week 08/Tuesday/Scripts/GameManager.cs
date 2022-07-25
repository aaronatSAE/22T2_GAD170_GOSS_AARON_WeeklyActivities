using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private CharacterWithMorale playerOne;
        [SerializeField] private CharacterWithMorale playerTwo;

        //[SerializeField] private Character[] players;

        private void Update()
        {
            // the check:
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //for (int i = 0; i < players.Length; i++)
                //{
                //    if (players[i] != null)
                //    {
                //        players[i].morale -= Random.Range(1, 13);
                //    }
                //}
                if (playerOne != null)
                {
                    // the adjustment:
                    playerOne.morale -= Random.Range(1, 13);
                    playerOne.health -= Random.Range(1, 9);

                    if (playerOne.health <= 0)
                    {
                        Destroy(playerOne.gameObject);
                        playerOne = null;
                    }
                }

                if (playerTwo != null)
                {
                    playerTwo.morale -= Random.Range(1, 13);
                    playerTwo.health -= Random.Range(1, 9);

                    if (playerTwo.health <= 0)
                    {
                        Destroy(playerTwo.gameObject);
                        playerTwo = null;
                    }
                }
            }
        }
    }
}
