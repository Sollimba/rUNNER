using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectUp : MonoBehaviour
{
    private int totalCredits;
    public PlayerControler playerControler;
    [SerializeField] Text TextCredit;

    private void OnTriggerEnter2D(Collider2D other)
    {
        BaseCredit credit = null;

        if (other.CompareTag("Credit"))
        {
            credit = new CreditUp();
        }
        else if (other.CompareTag("CreditRed"))
        {
            credit = new CreditRedUp();
        }
        else if (other.CompareTag("CreditGold"))
        {
            credit = new CreditGoldUp();
        }

        if (credit != null)
        {
            HandleCredit(credit, other);
        }
    }

    private void HandleCredit(BaseCredit credit, Collider2D other)
    {
        credit.Point();
        totalCredits += credit.Credit;
        TextCredit.text = totalCredits.ToString();
        playerControler.CreditPlayer += credit.CreditValue;
        Destroy(other.gameObject);
    }
}


