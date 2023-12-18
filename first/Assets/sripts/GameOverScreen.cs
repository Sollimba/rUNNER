using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] Text HighScoreText;
    [SerializeField] Text ScoreText;
    [SerializeField] Text CreditText;
    [SerializeField] private  PlayerData playerData;

    public float score;
    public int cred;

    public void Setup()
    {
        gameObject.SetActive(true);
    }
 
    void Update()
    {
        ScoreHighScoreText();
        CreditScoreText();

    }

    public void CreditScoreText()
    {
        playerData.Cred = cred;
        CreditText.text = "POINT " + playerData.Cred.ToString();
    }

    public void ScoreHighScoreText()
    {
        ScoreText.text = "SCORE " + score.ToString();
        if (playerData.Score <= score)
        {
            playerData.Score = score;
        }
        HighScoreText.text = "HighScore " + playerData.Score.ToString();
    }
    public void ResrartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
