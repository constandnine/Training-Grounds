using UnityEngine;

public class HookRight : BaseAttackClass
{
    public override void Attack()
    {
        if (healthScript.stamina > staminaloss)
        {
            healthScript.stamina -= staminaloss;


            animator.SetTrigger("HookRight");


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
