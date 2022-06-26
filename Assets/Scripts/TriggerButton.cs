using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{
    [SerializeField] GameObject openGateLabel;
    bool ballInArea = false;

    void Start()
    {
        openGateLabel.SetActive(false);
    }
    private void Update()
    {
        if(ballInArea)
        {
            openGateLabel.SetActive(true);
        }
        else
        {
            openGateLabel.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sphere")
        {
            ballInArea = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Sphere")
        {
            ballInArea = false;
        }
    }
    public bool CheckInArea()
    {
        return ballInArea;
    }
}
