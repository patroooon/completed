using System;
using System.Collections;
using System.Collections.Generic;
using TestXlab;
using UnityEngine;


namespace TestXlab
{
    public class PlayerController : MonoBehaviour
    {
        public Rigidbody falling_stone;
        public Transform Spawn;
        public CloudMove cloudMove;
        public ToolChange toolChange;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                Debug.Log("X key down");
                Instantiate(falling_stone, Spawn.position, Quaternion.identity);
            }


            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("Z key down");
                cloudMove.MoveToNextPoint();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space key down");
                toolChange.SwapTools();
            }
        }
    }
}