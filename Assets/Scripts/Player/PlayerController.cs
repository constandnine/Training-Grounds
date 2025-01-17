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


    [Header("Map Boundaries")]

    [SerializeField] private float minimalXBoundery;
    [SerializeField] private float maximalXBoundery;

    [SerializeField] private float minimalZBoundery;
    [SerializeField] private float maximalZBoundery;


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
        ClampPosition();
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
        transform.position += movement * speed * Time.deltaTime;
    }


    private void ClampPosition()
    {
        // Clamp the player's position within the map boundaries.
        float clampedX = Mathf.Clamp(transform.position.x, minimalXBoundery, maximalXBoundery);
        float clampedZ = Mathf.Clamp(transform.position.z, minimalZBoundery, maximalZBoundery);

        // Update the player's position with the clamped values.
        transform.position = new Vector3(clampedX, transform.position.y, clampedZ);
    }
}
