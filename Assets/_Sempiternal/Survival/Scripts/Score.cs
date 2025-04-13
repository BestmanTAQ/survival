using UnityEngine;
using UnityEngine.UI;

namespace Sempiternal.Survival.Scripts
{
    public class Score : MonoBehaviour
    {
        [SerializeField] private int score;
        [SerializeField] private Text textScore;

        public void ChangeScore()
        {
            score++;
            textScore.text = $"{score}";
        }
    }
}