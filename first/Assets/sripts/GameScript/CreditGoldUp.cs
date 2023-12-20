using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditGoldUp : BaseCredit
{
    public override int CreditValue => 5;
    public override void Point()
    {
        Credit = 5;
    }
}
