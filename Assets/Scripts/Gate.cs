using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public float timeGateClosed=1f;
    public void OpenGate()
    {
        this.gameObject.GetComponent<Animator>().SetBool("ButtonPressed",true);
        StartCoroutine(CloseGate());

    }
    IEnumerator CloseGate()
    {
        yield return new WaitForSecondsRealtime(timeGateClosed);
        this.gameObject.GetComponent<Animator>().SetBool("ButtonPressed", false);
    }
}
