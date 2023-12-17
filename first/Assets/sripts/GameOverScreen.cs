using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    CountScore countScore;
    [SerializeField] Text HighScoreText;
    [SerializeField] Text ScoreText;
    [SerializeField] private  PlayerData playerData;

    public float score;

    void Awake()
    {
        countScore = GameObject.FindGameObjectWithTag("Player").GetComponent<CountScore>();
        score = 0;
    }
    public void Setup()
    {
        gameObject.SetActive(true);
    }
 
    void Update()
    {
        float scr = score;
        ScoreText.text = "SCORE " + scr.ToString();
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
