
using UnityEngine;
using UnityEngine.InputSystem;

public class JabRight : BaseAttackClass
{
    public override void Attack()
    {
        if (stamina > staminaloss)
        {
            //print("Doing Jab");
            stamina -= staminaloss;


            animator.SetTrigger("JabRight");
            


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
