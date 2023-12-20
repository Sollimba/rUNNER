using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnInvisible : MonoBehaviour
{
    public float maxDistance = 40f;

    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");

        if (player != null)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

            if (distanceToPlayer > maxDistance)
            {
                Destroy(gameObject);
            }
        }
    }
}
