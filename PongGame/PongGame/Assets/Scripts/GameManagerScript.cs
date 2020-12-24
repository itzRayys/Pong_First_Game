using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player1")]
    public GameObject Player1Paddle;
    public GameObject Player1Goal;

    [Header("Player2")]
    public GameObject Player2Paddle;
    public GameObject Player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    [Header("Pause Menu")]
    public GameObject ResumeButton;
    public GameObject RestartButton;
    public GameObject QuitButton;
    public GameObject PauseMenu;

    private int Player1Score;
    private int Player2Score;
    public static bool isPaused = false;

    void Start()
    {
        Resume();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void Pause() 
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }


    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();

    }
    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }
    private void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        Player1Paddle.GetComponent<Paddle>().Reset();
        Player2Paddle.GetComponent<Paddle>().Reset();
    }
    public void RestartGame()
    {
        Player1Score = 0;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        Player2Score = 0;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
        Resume();
    }
    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
