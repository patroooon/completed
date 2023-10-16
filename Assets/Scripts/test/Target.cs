using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Target : MonoBehaviour
    {
        public delegate void HitDelegate();
        public event HitDelegate OnHit;

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Respawn"))
            {
                if (OnHit != null)
                {
                    OnHit();
                }
            }
        }
    }
}