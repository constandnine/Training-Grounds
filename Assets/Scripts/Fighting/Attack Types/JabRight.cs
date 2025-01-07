
using UnityEngine;
using UnityEngine.InputSystem;

public class JabRight : BaseAttackClass
{
    public override void Attack()
    {
        if (healthScript.stamina > staminaloss)
        {
            //print("Doing Jab");
            healthScript.stamina -= staminaloss;


            animator.SetTrigger("JabRight");
        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6 && collision.gameObject.tag != transform.gameObject.tag)
        {
            Health otherPlayerHealth = collision.gameObject.GetComponent<Health>();

            otherPlayerHealth.health -= damage;


            objectiveManager.UpdateObjective();


            hitSound.Play();
        }
    }
}
