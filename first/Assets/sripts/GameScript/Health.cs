using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public GameObject GameOverScreen;

    public void TakeHit(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            GameOverScreen.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void SetHealth(int bonusHealht)
    {
        health += bonusHealht;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

}
