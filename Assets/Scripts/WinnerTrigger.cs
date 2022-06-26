using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerTrigger : MonoBehaviour
{
    [SerializeField] GameObject winnerLabel;
    [SerializeField] float timeWinLabel = 0;
    void Start()
    {
        winnerLabel.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Sphere")
        {
            FindObjectOfType<Vcam>().SetCamera1();
            ShowWinnerLabel();
        }
    }
    public void ShowWinnerLabel()
    {
        FindObjectOfType<Floors>().ShowFloors();
        StartCoroutine(WinnerLabel());
    }

    IEnumerator WinnerLabel()
    {
        yield return new WaitForSecondsRealtime(timeWinLabel);
        winnerLabel.SetActive(true);
    }
}
