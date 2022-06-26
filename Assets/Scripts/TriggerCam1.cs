using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCam1 : MonoBehaviour
{
    [SerializeField] int position=0;

    private void OnTriggerEnter(Collider other)
    {
 
        if (other.tag == "Sphere")
        {
            FindObjectOfType<TriggerEvent>().SetCheck2(false);
            if(position==1)
            {
                FindObjectOfType<Vcam>().SetFirstposition();
            }
            if (position == 2)
            {
                FindObjectOfType<Vcam>().SetSecondposition();
            }
            FindObjectOfType<Vcam>().SetCamera1();
        }
    }
}
