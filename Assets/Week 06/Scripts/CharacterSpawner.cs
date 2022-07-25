using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class CharacterSpawner : MonoBehaviour
    {
        [SerializeField] private int count = 1;
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private Transform playerSpawnPoint;

        // Start is called before the first frame update
        void Start()
        {
            // We want to spawn our player character when the game starts.
            // What do we need?
            // - Make a player character prefab             ?
            // - A reference to that prefab (a variable)    ?
            // - Spawn it ("Instantiate")                   ?
            for (int i = 0; i < count; i++)
            {
                Instantiate(playerPrefab, playerSpawnPoint.position, Quaternion.identity);
            }
        }
    }
}
