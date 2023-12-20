using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditRedUp : BaseCredit
{
    public override int CreditValue => 2;
    public override void Point()
    {
        Credit = 2;
    }

}
