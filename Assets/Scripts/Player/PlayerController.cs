using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    #region Variables

    [Header("Input")]

    private  InputController inputController;

    private Vector2 movementInput;


    [Header("Movement")]

    [SerializeField] public float speed;

    private Vector3 movement;


    [Header("Player Statistics")]

    private float health;

    #endregion

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
        // Gets the value of the Left joystick
        movementInput = context.ReadValue<Vector2>();
    }

    public void Walk()
    {
        // Sets the X and Z axis of the movement Vector to the X and Y of the movement input vector.
        movement = new Vector3(movementInput.x, 0, movementInput.y);


        // Moves the payer based on the values of the moveement Vector.
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
