
using UnityEngine;
using UnityEngine.InputSystem;

public class JabRight : BaseAttackClass
{
    public override void Attack()
    {
        if (healthScript.stamina > staminaloss)
        {
            //print("Doing Jab");
            healthScript.stamina -= staminaloss;


            animator.SetTrigger("JabRight");


            healthScript.damage = damage;
        }
    }
}
