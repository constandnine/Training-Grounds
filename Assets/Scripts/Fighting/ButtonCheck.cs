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

    private bool _buttonNorth;
    public bool buttonNorth { get { return _buttonNorth; } set { _buttonNorth = value; } }

    private bool _buttonEast;
    public bool buttonEast { get { return _buttonEast; } set { _buttonEast = value; } }

    private bool _buttonSouth;
    public bool buttonSouth { get { return _buttonSouth; } set { _buttonSouth = value; } }

    private bool _buttonWest;
    public bool buttonWest { get { return _buttonWest; } set { _buttonWest = value; } }


    public void CheckButton(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            controlName = context.control.name;
        }


        if (controlName == "buttonNorth")
        {
            buttonNorth = true;
        }


        else if (controlName == "buttonEast")
        {
            buttonEast = true;
        }


        else if (controlName == "buttonSouth")
        {
            print("123");

            buttonSouth = true;

        }


        else if (controlName == "buttonWest")
        {
            buttonWest = true;
        }


        StartCoroutine(FlagToFalse());
    }

    private IEnumerator FlagToFalse()
    {
        yield return new WaitForSeconds(1);

        controlName = "";

        buttonWest = false;
        buttonNorth = false;
        buttonEast = false;
        buttonSouth = false;

    }
}