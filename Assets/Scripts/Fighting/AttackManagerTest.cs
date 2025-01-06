using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttackManagerTest : MonoBehaviour
{
    [Header("Script references")]

    private BaseAttackClass attack;

    private InputController inputController;


    private void Awake()
    {
        inputController = new InputController();
    }


    private void OnEnable()
    {
        inputController.Enable();
    }


    private void OnDisable()
    {
        inputController.Disable();
    }


    public void OnJabLeft(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            attack = GameObject.Find("JabLeft").GetComponent<BaseAttackClass>();
            attack.Attack();
        }   
    }


    public void OnJabRight(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            attack = GameObject.Find("JabRight").GetComponent<BaseAttackClass>();
            attack.Attack();
        }
    }

    public void OnHookLeft(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            attack = GameObject.Find("HookLeft").GetComponent<BaseAttackClass>();
            attack.Attack();
        }
    }


    public void OnHookRight(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            attack = GameObject.Find("HookRight").GetComponent<BaseAttackClass>();
            attack.Attack();
        }
    }

    public void OnUppercut(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            attack = GameObject.Find("Uppercut").GetComponent<BaseAttackClass>();
            attack.Attack();
        }
    }
}
