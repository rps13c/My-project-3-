using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to UI Text (TMP)
    private int score = 0; // Initial score

    void Start()
    {
        UpdateScoreText(); // Initialize the score display
    }

    public void AddPoint()
    {
        score += 1;
        UpdateScoreText();
    }

    public void SubtractPoint()
    {
        score -= 1;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
