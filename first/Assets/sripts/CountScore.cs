using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{

    [SerializeField] Transform point;
    [SerializeField] Text distanceText;

    public PlayerControler playerControler;
    public static float distance;

    void Update()
    {
        distance = (point.transform.position - transform.position).magnitude;
        if (distance != 0)
        {
            playerControler.ScorePlayer = distance;
        }
        distanceText.text = ((int)distance).ToString() + " Score";
    }

}