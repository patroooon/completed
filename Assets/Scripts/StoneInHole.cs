using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class StoneInHole : MonoBehaviour
    {
       
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Finish") && gameObject.CompareTag("Respawn"))
            {
                
                    Debug.Log("Победа!");
                }
                
            }
        }
    }


