using UnityEngine.InputSystem;
using UnityEngine;

public class Uppercut : BaseAttackClass
{
    public override void Attack()
    {
        if (healthScript.stamina > staminaloss)
        {
            healthScript.stamina -= staminaloss;


            animator.SetTrigger("Uppercut");


            if (connected == true)
            {
                objectiveManager.UpdateObjective();
                healthScript.health -= damage;
            }
        }
    }
}
