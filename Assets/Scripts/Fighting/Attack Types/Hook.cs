using UnityEngine.InputSystem;

public class Hook : BaseAttackClass
{
    public override void Attack()
    {
        print("Doing Hook");
        if (stamina > staminaloss)
        {
            stamina -= staminaloss;


            if (buttonNorth == true)
            {
                animator.SetTrigger("HookLeft");
            }

            else if (buttonSouth == true)
            {
                animator.SetTrigger("HookRight");
            }


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
