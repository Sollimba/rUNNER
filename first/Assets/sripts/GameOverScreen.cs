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

    public ObjectUp objectUp;
    public float score;
    public int cred;

    public void Start()
    {
        CreditScoreText();
    }

    public void Setup()
    {
        gameObject.SetActive(true);
    }
 
    void Update()
    {
        ScoreHighScoreText();
    }

    public void CreditScoreText()
    {
        playerData.Cred += cred;
        CreditText.text = "POINT " + playerData.Cred.ToString();
    }

    public void ScoreHighScoreText()
    {
        ScoreText.text = "SCORE " + ((int)score).ToString();
        if (playerData.Score <= score)
        {
            playerData.Score = score;
        }
        HighScoreText.text = "HighScore " + ((int)playerData.Score).ToString();
    }
    public void ResrartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
