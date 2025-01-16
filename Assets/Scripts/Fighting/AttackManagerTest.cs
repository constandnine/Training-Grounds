using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttackManagerTest : MonoBehaviour
{
    [Header("Script references")]

    [SerializeField] private BaseAttackClass[] attacks;

    private InputController inputController;


    [Header("Index")]

    private int attackIndex;


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
            attackIndex = 0;


            attacks[attackIndex].Attack();
        }   
    }


    public void OnJabRight(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            attackIndex = 1;


            attacks[attackIndex].Attack();
        }
    }

    public void OnHookLeft(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            attackIndex = 2;


            attacks[attackIndex].Attack();
        }
    }


    public void OnHookRight(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            attackIndex = 3;


            attacks[attackIndex].Attack();
        }
    }

    public void OnUppercut(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            attackIndex = 4;


            attacks[attackIndex].Attack();
        }
    }
}
