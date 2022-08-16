using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AaronGoss
{
    public class CharacterControllerAG : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 10;

        void Update()
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime,
                                              0,
                                              Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        }
    }
}
