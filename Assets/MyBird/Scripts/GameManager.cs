using UnityEngine;
using TMPro;

namespace MyBird
{
    public class GameManager : MonoBehaviour
    {
        #region Variables
        public static bool IsStart { get; set; }
        public static bool IsDeath { get; set; }
        public static int Score { get; set; }
        public static int BestScore {  get; set; }
        public TextMeshProUGUI scoreText;
        // public GameObject readyUI;
        
        #endregion

        private void Start()
        {
            //초기화
            IsStart = false;
            IsDeath = false;
            Score = 0;
        }

        //점수 텍스트 업데이트
        private void Update()
        {
            scoreText.text = Score.ToString();
        }
    }
}