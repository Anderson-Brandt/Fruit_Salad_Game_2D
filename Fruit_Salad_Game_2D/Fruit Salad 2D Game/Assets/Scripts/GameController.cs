using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

    public GameObject gameOverPanel;

    public static GameController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }
    public void GameOverActive()
    {
        AudioController.currentAudio.NoMusic();
        AudioController.currentAudio.PlayMusic(AudioController.currentAudio.gameOver);
        gameOverPanel.SetActive(true);
        
    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // LINKS TELA FINAL

    public void OpenInstaAnderson()
    {
        Application.OpenURL("https://www.instagram.com/brandt_of/");
    }

    public void OpenPortfolio()
    {
        Application.OpenURL("https://linkr.bio/AndersonBrandt");
    }

    public void OpenLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/anderson-brandt/");
    }
}
