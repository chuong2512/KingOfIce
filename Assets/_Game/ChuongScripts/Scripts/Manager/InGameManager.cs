using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace ChuongCustom
{
    public class InGameManager : Singleton<InGameManager>
    {
        private void OnEnable()
        {
            Time.timeScale = 1;
            ScoreManager.Score = 0;
        }

        [Button]
        public void Lose()
        {
            ScreenManager.Instance.OpenScreen(ScreenType.BeforeLose);
            Time.timeScale = 0;
        }

        public void Continue()
        {
            Time.timeScale = 1;
        }

        public int Point { get; set; }
    }
}