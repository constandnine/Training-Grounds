using UnityEngine.InputSystem;

public class Jab : BaseAttackClass
{
    public override void Attack()
    {
        if (stamina > staminaloss)
        {
            //play jab animation


            // check if it was the right or left jab


            stamina -= staminaloss;


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
