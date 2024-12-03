using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAttackClass : MonoBehaviour
{
    [Header("script reference")]

    public Health healthScript;


    [Header("damage and stamina")]

    [SerializeField] private float _damage;
    public float damage { get { return _damage;} set { _damage = value; } }

    [SerializeField]  private float _stamina;
    public float stamina { get { return _stamina; } set { _stamina = value; } }
    [SerializeField] private float _staminaloss;
    public float staminaloss { get { return _staminaloss; } set { _staminaloss = value; } }


    [Header("Landed")]

    private bool _connected;
    public bool connected { get { return _connected; } set { _connected = value; } }

    public virtual void Attack()
    {
        print("Doing the base attack!");
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            connected = true;
        }
    }
}
