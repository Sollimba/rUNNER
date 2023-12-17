using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{

    [SerializeField] Transform point;
    [SerializeField] Text distanceText;
    [SerializeField] private GameOverScreen gameOverScreen;

    public static float distance;

    void LateUpdate()
    {
        distance = (point.transform.position - transform.position).magnitude;
        gameOverScreen.score = distance;
        distanceText.text = distance.ToString("F1") + "Score";
    }

}