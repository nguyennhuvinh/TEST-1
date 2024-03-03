using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public TMP_Text ScoreDisplay;
    public GameObject gameOverScreenObject;

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
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.ResetScore();
        }
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();

    }
}
