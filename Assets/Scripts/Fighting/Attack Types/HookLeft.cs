using UnityEngine;

public class HookLeft : BaseAttackClass
{
    public override void Attack()
    {
        if (stamina > staminaloss)
        {
            stamina -= staminaloss;


            animator.SetTrigger("HookLeft");


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
