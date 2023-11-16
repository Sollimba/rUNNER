using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage = 100;
    public string collisionTag;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        Health health = coll.gameObject.GetComponent<Health>();
        health.TakeHit(collisionDamage);
    }
}
