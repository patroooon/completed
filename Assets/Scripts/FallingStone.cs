using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FallingStone : MonoBehaviour
{
    public Rigidbody falling_stone;
    public Transform Spawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(falling_stone, Spawn.position, Quaternion.identity);
        }
    }
}
