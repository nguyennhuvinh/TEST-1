using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public TMP_Text ScoreDisplay;
    public GameObject gameOverScreenObject;
    int score = 0;

    public void ShowGameOverScreen()
    {
        gameOverScreenObject.SetActive(true);
        if (ScoreManager.Instance != null)
        {
            int FinalScore = ScoreManager.Instance.GetCurrentScore();
            ScoreDisplay.text = FinalScore + " POINTS";
        }
    }

    public void Restart()
    {
        ScoreManager.Instance.scoreText.text = "Score: " + score;
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();

    }
}
