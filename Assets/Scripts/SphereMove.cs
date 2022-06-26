using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SphereMove : MonoBehaviour
{
    Rigidbody myRigidBody;
    [SerializeField] float speed = 15f;
    

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        var Triggers = FindObjectsOfType<TriggerEvent>();
        foreach (TriggerEvent trigger in Triggers)
        {
            if (trigger.Check())
            {
                StartCoroutine(Move());
            }
        }
    }

    IEnumerator Move()
    {
        yield return new WaitForSecondsRealtime(1f);
        float LfMove = Input.GetAxis("Horizontal");
        float UdMove = Input.GetAxis("Vertical");
        Vector3 playerVelocity = new Vector3(LfMove, 0f, UdMove);
        gameObject.transform.GetComponent<Rigidbody>().AddForce(playerVelocity * speed);

        bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
    }
}
