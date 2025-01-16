using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("scrip reference")]

    private BaseAttackClass attackClass;


    [Header("Statistics")]

    [SerializeField] private float _health;
    public float health { get { return _health;} set { _health = value; } }

    [SerializeField] private float _stamina;
    public float stamina { get { return _stamina; } set { _stamina = value; } }

    [SerializeField] private float _damage;
    public float damage { get { return _damage; } set { _damage = value; } }

    public Health otherPlayerHealth;

    private void KnockOut()
    {
        if (health < 1)
        {
            // KO logig here pls
        }
    }


    public void OnCollisionEnter(Collision collision)
    {
            //otherPlayerHealth = collision.gameObject.GetComponent<Health>();
        if (collision.gameObject.layer == 7)
        {
            otherPlayerHealth.health -= damage;
            print(collision.gameObject.layer);



            //objectiveManager.UpdateObjective();


            //hitSound.Play();
        }

        if (collision.gameObject.tag != transform.gameObject.tag)
        {
            print(collision.gameObject.tag);
        }
    }
}
