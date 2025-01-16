using UnityEngine;

public class HookLeft : BaseAttackClass
{
    public override void Attack()
    {
        if (healthScript.stamina > staminaloss)
        {
            healthScript.stamina -= staminaloss;


            animator.SetTrigger("HookLeft");


            healthScript.damage = damage;
        }
    }
}
