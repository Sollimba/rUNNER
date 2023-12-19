using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditGoldUp : CreditUp
{
    public override void Point()
    {
        Credit += 5;
    }
    public override string ToString()
    {
        return Credit.ToString();
    }
}
