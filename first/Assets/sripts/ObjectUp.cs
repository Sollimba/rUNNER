using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectUp : MonoBehaviour
{
    CreditUp credit;
    CreditRedUp creditred;
    CreditGoldUp creditgoldup;
    public PlayerControler playerControler;
    [SerializeField] Text TextCredit;

    private void Start()
    {
        credit = new CreditUp();
        creditred = new CreditRedUp();
        creditgoldup = new CreditGoldUp();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Credit"))
        {
            credit.Point();
            TextCredit.text = credit.Credit.ToString();
            playerControler.CreditPlayer += 1;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("CreditRed")) 
        {
            creditred.Point();
            TextCredit.text = creditred.Credit.ToString();
            playerControler.CreditPlayer += 2;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("CreditGold"))
        {
            creditgoldup.Point();
            TextCredit.text = creditgoldup.Credit.ToString();
            playerControler.CreditPlayer += 5;
            Destroy(other.gameObject);
        }
    }
}

