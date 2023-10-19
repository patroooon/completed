using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Golf
{
    public class GameplayState : GameState
    {
        public LevelController levelController;
        public PlayerController playerController;
        public GameState gameOverState;
        public TMP_Text scoreText;
        public WinState winState;

        protected override void OnEnable()
        {
            base.OnEnable();

            levelController.enabled = true;
            playerController.enabled = true;

            GameEvents.onCollisionStones += OnGameOver;
            GameEvents.onStickHit += OnStickHit;

            OnStickHit();

            GameEvents.onStoneInHole += OnWin;
        }

        private void OnStickHit()
        {
            scoreText.text = $"score : {levelController.score}";
        }

        private void OnGameOver()
        {
            Exit();
            gameOverState.Enter();
        }

        private void OnWin()
        {
            Exit();
            winState.Enter();
        }

        protected override void OnDisable()
        {
            base.OnDisable();

            GameEvents.onCollisionStones -= OnGameOver;
            GameEvents.onStoneInHole -= OnWin;

            levelController.enabled = false;
            playerController.enabled = false;
        }
    }
}
