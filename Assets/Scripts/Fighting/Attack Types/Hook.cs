using UnityEngine;

public class Hook : BaseAttackClass
{
    public override void Attack()
    {
        print("Doing Hook");
        if (stamina > staminaloss)
        {
            stamina -= staminaloss;


            //stateManager.SwitchStates(stamina, damage);


            if (buttonEast == true)
            {
                Debug.Log(buttonEast);

                animator.SetTrigger("HookLeft");
            }

            else if (buttonWest == true)
            {
                Debug.Log(buttonWest);

                animator.SetTrigger("HookRight");
            }


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
