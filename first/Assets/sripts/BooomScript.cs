using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooomScript : MonoBehaviour
{
    public Vector2 moving;
    public float speed;

    void Start()
    {
        
    }


    void FixedUpdate()
    {
        transform.Translate(moving.normalized * speed);
    }
}
