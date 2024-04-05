using UnityEngine;
using TMPro;

namespace SpaceShooter
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreLabel;

        private static ScoreManager instance;
        private int score;

        private void Awake()
        {
            instance = GetComponent<ScoreManager>();
        }

        public static void IncrementScore()
        {
            instance.privIncrementScore();
        }

        private void privIncrementScore()
        {
            score++;
            scoreLabel.text = score.ToString();
        }
    }
}
