
using UnityEngine;
using UnityEngine.InputSystem;

public class Jab : BaseAttackClass
{
    public override void Attack()
    {
        if (stamina > staminaloss)
        {
            print("Doing Jab");
            stamina -= staminaloss;


            //stateManager.SwitchStates(stamina, damage);


            if (buttonNorth == true)
            {
                Debug.Log(buttonNorth);
                animator.SetTrigger("JabLeft");
            }

            if (buttonSouth == true)
            {
                Debug.Log(buttonSouth);
                animator.SetTrigger("JabRight");
            }


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }


    public override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
    }
}
