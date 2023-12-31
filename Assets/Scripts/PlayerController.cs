using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Golf
{

    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Player player;

        private void Start()
        {
            if (player == null)
            {
                Debug.Log("Player is NULL!!!");
            }
        }

        public void OnDown()
        {
            player.SetDown(true);
        }

        public void OnUp()
        {
            player.SetDown(false);
        }
    }
}