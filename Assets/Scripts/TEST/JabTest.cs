using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JabTest : BaseAttackClass
{

    public override void Attack()
    {
        if(stamina > staminaloss)
        {
            stamina -= staminaloss;


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
