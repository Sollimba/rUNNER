using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flore : MonoBehaviour
{
    private PolygonCollider2D polygonCollider;
    private Rigidbody2D rb;

    void Start()
    {
        polygonCollider = gameObject.AddComponent<PolygonCollider2D>();
        rb = gameObject.AddComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Static;
    }

    void Update()
    {
        polygonCollider.offset = new Vector2(transform.position.x, transform.position.y);
    }
}
