
using UnityEngine.InputSystem;

public class Jab : BaseAttackClass
{
    public override void Attack()
    {
        print("Doing Jab");
        if (stamina > staminaloss)
        {
            stamina -= staminaloss;


            if (buttonNorth == true)
            {
                animator.SetTrigger("JabLeft");
            }

            if (buttonSouth == true)
            {
                animator.SetTrigger("JabRight");
            }


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
