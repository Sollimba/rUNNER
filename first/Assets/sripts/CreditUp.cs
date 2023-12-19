using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CreditUp : MonoBehaviour
{
    public int Credit { get; protected set; } = 0;

    public virtual void Point()
    {
        Credit++;
    }
    public override string ToString()
    {
        return Credit.ToString();
    }
}
