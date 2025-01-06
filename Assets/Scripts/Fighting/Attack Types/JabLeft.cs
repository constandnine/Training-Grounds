
using UnityEngine;
using UnityEngine.InputSystem;

public class JabLeft : BaseAttackClass
{
    public override void Attack()
    {
        if (healthScript.stamina > staminaloss)
        {
            //print("Doing Jab");
            healthScript.stamina -= staminaloss;


            animator.SetTrigger("JabLeft");


            if (connected == true)
            {
                objectiveManager.UpdateObjective();
                healthScript.health -= damage;
            }
        }
    }
}
