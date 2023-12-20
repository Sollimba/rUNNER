using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCredit
{
    public int Credit { get; protected set; }
    public abstract int CreditValue { get; }

    public abstract void Point();

}