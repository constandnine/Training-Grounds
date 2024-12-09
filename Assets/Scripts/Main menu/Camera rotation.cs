using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Camerarotation : MonoBehaviour
{
    public float rotSpeed, moveSpeed;
    [Tooltip("If is rotating is true it wil rotate else it will move forward")]
    public bool isRotating, isMoving;
    private Vector3 startPos;

    public void Awake()
    {
        startPos = transform.position;
    }
    public void OnEnable()
    {
        transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            gameObject.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, rotSpeed, 0);
        }
        if (isMoving)
        {
            gameObject.GetComponent<Rigidbody>().velocity = transform.forward * moveSpeed;
        }
    }
}
