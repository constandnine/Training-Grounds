using UnityEngine.InputSystem;

public class Jab : BaseAttackClass
{
    public override void Attack()
    {
        print("Doing Jab");
        if (stamina > staminaloss)
        {
            //play jab animation
            LeftTemporaryHit();
            StartCoroutine(MaveLeftGloveBack());


            stamina -= staminaloss;


            if (connected == true)
            {
                healthScript.health -= damage;
            }
        }
    }
}
