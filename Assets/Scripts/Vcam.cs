using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Vcam : MonoBehaviour
{
    CinemachineVirtualCamera vcam;

    void Start()
    {
        vcam= GetComponent<CinemachineVirtualCamera>();
    }

    public void SetCamera1()
    {
        vcam.m_Priority = 10;
    }

    public void SetCamera2()
    {
        vcam.m_Priority = 8;
    }
    public void SetFirstposition()
    {
        transform.position=new Vector3(transform.position.x,65f,transform.position.y);
    }
    public void SetSecondposition()
    {
        transform.position = new Vector3(transform.position.x, 35f, transform.position.y);
    }
}
