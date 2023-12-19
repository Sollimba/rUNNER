using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditRedUp : CreditUp
{

    public override void Point()
    {
        Credit += 2;
    }
    public override string ToString()
    {
        return Credit.ToString();
    }
}
