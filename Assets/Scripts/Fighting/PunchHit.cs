using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PunchHit : Attack
{
    [SerializeField]private bool _connected;
    public bool connected { get { return _connected; } set { _connected = value; } }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            connected = true;
        }
    }


    public virtual void DoUppercut(InputAction.CallbackContext context)
    {

    }


    public virtual void DoHook(InputAction.CallbackContext context)
    {

    }

    public virtual void DoJab(InputAction.CallbackContext context)
    {
        print("3");

    }
}
