using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectUp : MonoBehaviour
{
    public static int Credit;
    public PlayerControler playerControler;


    [SerializeField] Text TextCredit;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Credit"))
        {
            Credit ++;
            playerControler.CreditPlayer = Credit;
            UpdateUI();
            Destroy(other.gameObject);
        }
    }
        private void UpdateUI()
    {
        TextCredit.text = Credit.ToString();
    }
}
