using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [Flags]
    public enum RotationDirection
    {
        None,
        Horizontal = ( 1 << 0),
        Vertical = (1 << 1)
    }


    [SerializeField] private Vector2 MouseSensitivity;
    public Transform PlayerBody;
    
    
    [SerializeField] private Vector2 acceleration;
    [SerializeField] private float inputLagPeriod;
    [SerializeField] private float maxAngle;
    [SerializeField] private RotationDirection rotationDirections;
    private Vector2 rotation;
    private Vector2 velocity;
    private Vector2 lastInputEvent;
    private float inputLagTimer;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnEnable()
    {
        velocity = Vector2.zero;
        inputLagTimer = 0;
        lastInputEvent = Vector2.zero;

        Vector3 euler = transform.localEulerAngles;

        if(euler.x >= 180)
        {
            euler.x = -360;
        }

        euler.x = ClampVerticaleAngle(euler.x);
        transform.localEulerAngles = euler;
        rotation = new Vector3(euler.y, euler.x);
    }

    private float ClampVerticaleAngle(float angle)
    {
        return Mathf.Clamp(angle, -maxAngle, maxAngle);
    }

    private Vector2 GetInput()
    {
        inputLagTimer += Time.deltaTime;
        Vector2 input = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        

        if ((Mathf.Approximately(0, input.x) && Mathf.Approximately(0, input.y)) == false || inputLagTimer >= inputLagPeriod)
        {
            lastInputEvent = input;
            inputLagTimer = 0;
        }
        return lastInputEvent;
    }
    void LateUpdate()
    {
        Vector2 wantedVelocity = GetInput() * MouseSensitivity;
        if ((rotationDirections & RotationDirection.Horizontal) == 0)
        {
            wantedVelocity.x = 0;
        }

        if ((rotationDirections & RotationDirection.Vertical) == 0)
        {
            wantedVelocity.y = 0;
        }

        velocity = new Vector2(
            Mathf.MoveTowards(velocity.x, wantedVelocity.x, acceleration.x * Time.deltaTime), 
            Mathf.MoveTowards(velocity.y, wantedVelocity.y, acceleration.y * Time.deltaTime));
        rotation += velocity * Time.deltaTime;
        rotation.y = ClampVerticaleAngle(rotation.y);
        transform.localEulerAngles = new Vector3(rotation.y, rotation.x, 0);

    }
}
