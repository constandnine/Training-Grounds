using UnityEngine.InputSystem;

public class Uppercut : BaseAttackClass
{
    public override void Attack()
    {
        print("Doing Uppercut");
        if (stamina > staminaloss)
        {
            stamina -= staminaloss;


            animator.SetTrigger("Uppercut");


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
