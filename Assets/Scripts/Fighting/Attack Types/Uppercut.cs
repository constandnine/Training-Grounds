using UnityEngine.InputSystem;
using UnityEngine;

public class Uppercut : BaseAttackClass
{
    public override void Attack()
    {
        if (healthScript.stamina > staminaloss)
        {
            healthScript.stamina -= staminaloss;


            animator.SetTrigger("Uppercut");
        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6 && collision.gameObject.tag != transform.gameObject.tag)
        {
            healthScript.health -= damage;


            objectiveManager.UpdateObjective();
        }
    }
}
