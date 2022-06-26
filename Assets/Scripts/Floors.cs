using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floors : MonoBehaviour
{
    [SerializeField] GameObject secondFloor;
    [SerializeField] GameObject thirdFloor;
    [SerializeField] GameObject forHide;

    public void HideSecondFloor()
    {
        secondFloor.SetActive(false);
    }
    public void HideThirdFloor()
    {
        thirdFloor.SetActive(false);
    }

    public void Hide()
    {
        forHide.SetActive(false);
    }
    public void ShowFloors()
    {
        secondFloor.SetActive(true);
        thirdFloor.SetActive(true);
        forHide.SetActive(true);
    }
    

}
