using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSpawner : MonoBehaviour
{
    public GameObject ItemToSpread;
    public int numItemsToSpawn;

    public float itemXSpread = 10f;
    public float itemYSpread = 0f;
    public float itemZSpread = 10f;

    public bool triggerOn = false;

    IEnumerator SpreadItems()
    {
        yield return new WaitForSecondsRealtime(0.3f);
        Vector3 randomPosition = new Vector3(
            Random.Range(-itemXSpread, itemXSpread),
            Random.Range(-itemYSpread, itemYSpread),
            Random.Range(-itemZSpread, itemZSpread));
        GameObject clone = Instantiate(ItemToSpread, randomPosition + transform.position, Quaternion.identity, this.transform);
    }
    void Update()
    {
        if (triggerOn)
        {
            StartCoroutine("SpawnNumOfItems",1);
            triggerOn = false;
        }
    }

    IEnumerator SpawnNumOfItems()
    {
        for (int i = 0; i < numItemsToSpawn; i++)
        {
            yield return StartCoroutine(SpreadItems());
        }
    }

    public void SetTriggerOn()
    {
        triggerOn = true;
    }
}
