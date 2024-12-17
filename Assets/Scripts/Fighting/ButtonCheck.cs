using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonCheck : MonoBehaviour
{
    [Header("Input")]

    private string _controlName;
    public string controlName { get { return _controlName; } set { _controlName = value; } }


    [Header("Button check's")]

    [SerializeField] private bool _buttonNorth;
    public bool buttonNorth { get { return _buttonNorth; } set { _buttonNorth = value; } }

    [SerializeField] private bool _buttonEast;
    public bool buttonEast { get { return _buttonEast; } set { _buttonEast = value; } }

    [SerializeField] private bool _buttonSouth;
    public bool buttonSouth { get { return _buttonSouth; } set { _buttonSouth = value; } }

    [SerializeField] private bool _buttonWest;
    public bool buttonWest { get { return _buttonWest; } set { _buttonWest = value; } }


    public void CheckButton(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            controlName = context.control.name;
        }


        else if (controlName == "buttonNorth")
        {
            Debug.Log(controlName);

            buttonNorth = true;

            buttonEast = false;
            buttonSouth = false;
            buttonWest = false;
        }


        else if (controlName == "buttonEast")
        {
            Debug.Log(controlName);
            buttonEast = true;

            buttonNorth = false;
            buttonSouth = false;
            buttonWest = false;
        }


        else if (controlName == "buttonSouth")
        {
            Debug.Log(controlName);
            buttonSouth = true;

            buttonNorth = false;
            buttonEast = false;
            buttonWest = false;
        }


        else if (controlName == "buttonWest")
        {
            Debug.Log(controlName);
            buttonWest = true;

            buttonNorth = false;
            buttonEast = false;
            buttonSouth = false;
        }
    }
}