using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private SphereMovement playerMovement;
    private InputAction move,open;

    private Rigidbody myRigidBody;

    public float maxSpeed = 5f;

    private void Awake()
    {
        myRigidBody = this.GetComponent<Rigidbody>();
        playerMovement = new SphereMovement();

        if(myRigidBody is null)
        {
            Debug.LogError("RigidBody is NULL");
        }
    }
    private void OnEnable()
    {
        move = playerMovement.Sphere_Map.Movement;
        open = playerMovement.Sphere_Map.OpenGate;
        playerMovement.Sphere_Map.Enable();
    }
    private void OnDisable()
    {
        move = playerMovement.Sphere_Map.Movement;
        open = playerMovement.Sphere_Map.OpenGate;
        playerMovement.Sphere_Map.Disable();
    }

    private void FixedUpdate()
    {
        var triggers = FindObjectsOfType<TriggerEvent>();
        var buttomArea = FindObjectOfType<TriggerButton>().CheckInArea();

        foreach (TriggerEvent trigger in triggers)
        {
            if (trigger.Check())
            {
                StartCoroutine(Move());
            }
        }
        if(buttomArea)
        {
            OpenGate();
        }
    }

    IEnumerator Move()
    {
        yield return new WaitForSecondsRealtime(1f);
        Vector3 playerVelocity = new Vector3(move.ReadValue<Vector2>().x, 0f, move.ReadValue<Vector2>().y);
        myRigidBody.AddForce(playerVelocity * maxSpeed);
    }
    private void OpenGate()
    {
        if(open.triggered)
        {
            FindObjectOfType<Gate>().OpenGate();
        }
    }
}
