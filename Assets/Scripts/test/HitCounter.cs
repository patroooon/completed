using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class HitCounter : MonoBehaviour
    {
        private int hitCount = 0;

        private void Start()
        {
            Target target = GetComponent<Target>();
            target.OnHit += IncrementHitCount;
        }

        private void IncrementHitCount()
        {
            hitCount++;
            Debug.Log("—чет: " + hitCount);
        }

    }
}