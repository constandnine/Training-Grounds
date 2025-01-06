
using UnityEngine;
using UnityEngine.InputSystem;

public class JabLeft : BaseAttackClass
{
    public override void Attack()
    {
        if (stamina > staminaloss)
        {
            //print("Doing Jab");
            stamina -= staminaloss;


            animator.SetTrigger("JabLeft");


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
