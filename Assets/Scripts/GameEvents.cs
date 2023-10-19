using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{

    public static class GameEvents
    {
        public static event System.Action onCollisionStones;
        public static event System.Action onStickHit;
        public static event System.Action onStoneInHole;

        public static void CollisionStonesInvoke(Collision collision)
        {
            onCollisionStones?.Invoke();
        }

        public static void StickHit()
        {
            onStickHit?.Invoke();
        } 

        public static void StoneInHole(Collision collision)
        {
            onStoneInHole?.Invoke();
        }
    }
}