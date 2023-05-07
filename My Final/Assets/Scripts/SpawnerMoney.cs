using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMoney : MonoBehaviour
{
    public MoneyActive _moneyActive;
    public GameObject moneys;
    public float spawnInterval = 1f; // Spawn interval in seconds

    private void Start()
    {
        StartCoroutine(SpawnMoney());
    }

    IEnumerator SpawnMoney()
    {
        while (true)
        {
            if (_moneyActive.active)
            {
                GameObject moneyObject = Instantiate(moneys, new Vector3(transform.position.x, transform.position.y , transform.position.z), Quaternion.identity);
                Destroy(moneyObject, 4f); // slet objektet efter 2 sekunder
            }
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}