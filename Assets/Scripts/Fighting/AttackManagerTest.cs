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


    public void OnJab(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            attack = GameObject.Find("Jab").GetComponent<BaseAttackClass>();
            attack.Attack();
            print("12");
        }   
    }
}
