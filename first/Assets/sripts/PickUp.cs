using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    private PlayerControler boost;
    public static float BoostSpeed;

    private void Start()
    {
        BoostSpeed = 10;
    }
    void Boostmin()
    {
        boost.speed -= BoostSpeed;
        Destroy(gameObject);
    }
  
        void OnTriggerEnter2D(Collider2D other)
        {
        if (other.CompareTag("Player"))
        {
            boost = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControler>();
            boost.speed += BoostSpeed;
            Invoke("Boostmin", 1);
        }
        }


}
