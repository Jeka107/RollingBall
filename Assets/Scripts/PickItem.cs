using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public GameObject[] itemToPickFrom;

    void Start()
    {
        Pick();
    }

    void Pick()
    {
        int randomIndex = Random.Range(0, itemToPickFrom.Length);
        GameObject clone = Instantiate(itemToPickFrom[randomIndex], transform.position, Quaternion.identity, this.transform);
    }
}
