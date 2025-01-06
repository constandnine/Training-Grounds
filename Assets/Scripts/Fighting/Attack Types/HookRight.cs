using UnityEngine;

public class HookRight : BaseAttackClass
{
    public override void Attack()
    {
        if (stamina > staminaloss)
        {
            stamina -= staminaloss;


            animator.SetTrigger("HookRight");


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
