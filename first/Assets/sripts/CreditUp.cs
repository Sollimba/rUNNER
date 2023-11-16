using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TextCredit.Credit += 1;
            Destroy(gameObject);
        }
    }

}
