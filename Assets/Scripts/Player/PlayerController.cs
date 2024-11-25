using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [Header("Input")]

    private  InputController inputController;
    InputAction leftStick;

    private Vector2 movementInput;


    [Header("Movement")]
    private Vector3 targetMovementPosition;

    [SerializeField] private float speed;
    [SerializeField] private float smoothness;


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


    private void Update()
    {
        Walk();
    }


    public void Input(InputAction.CallbackContext context)
    {
        //movementInput = inputController.Player.Walk.ReadValue<Vector2>();
        movementInput = context.ReadValue<Vector2>();
    }

    public void Walk()
    {
        Vector3 movement = new Vector3(movementInput.x, 0, movementInput.y);


        transform.Translate(movement * speed * Time.deltaTime);
    }
}
