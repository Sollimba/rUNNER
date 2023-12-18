using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectUp : MonoBehaviour
{
    private int Credit = 0;
    public PlayerControler playerControler;

    [SerializeField] Text TextCredit;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Credit"))
        {
            Credit++;
            UpdateUI();
            playerControler.CreditPlayer += 1;
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Speeed"))
        {

        }
    }

    private void UpdateUI()
    {
        TextCredit.text = Credit.ToString();
    }
}
