using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField] bool check2 = false;
    [SerializeField] int numFloor = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sphere")
        {
            SetCheck2(true);
            FindObjectOfType<Vcam>().SetCamera2();
            if(numFloor==2)
            {
                StartCoroutine(HideFloor2());
            }
            if(numFloor == 3)
            {
                StartCoroutine(HideFloor3());
            }
            if(numFloor==4)
            {

                StartCoroutine(HideFloor4());
            }
        }
    }
    
    public bool Check()
    {
        return check2;
    }
    public void SetCheck2(bool other)
    {
        check2 = other;
    }
    IEnumerator HideFloor2 ()
    {
        yield return new WaitForSecondsRealtime(1f);
        FindObjectOfType<Floors>().HideSecondFloor();
    }
    IEnumerator HideFloor3()
    {
        yield return new WaitForSecondsRealtime(1f);
        FindObjectOfType<Floors>().HideThirdFloor();
    }
    IEnumerator HideFloor4()
    {
        FindObjectOfType<Floors>().Hide();
        yield return new WaitForSecondsRealtime(1f);
        FindObjectOfType<AreaSpawner>().SetTriggerOn();
    }
}
