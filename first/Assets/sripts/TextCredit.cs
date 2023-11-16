using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCredit : MonoBehaviour
{
    public static int Credit;
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = Credit.ToString();
    }
}
