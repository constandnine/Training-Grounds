using UnityEngine.InputSystem;
using UnityEngine;

public class Uppercut : BaseAttackClass
{
    public override void Attack()
    {
        print("Doing Uppercut");
        if (stamina > staminaloss)
        {
            stamina -= staminaloss;


            //stateManager.SwitchStates(stamina, damage);


            animator.SetTrigger("Uppercut");


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
