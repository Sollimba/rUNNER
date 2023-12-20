using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditUp : BaseCredit
{
    public override int CreditValue => 1;
    public override void Point()
    {
        Credit++;
    }
}
