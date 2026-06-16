using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletprefab;
    public GameObject bulletprefab1;
    public GameObject bulletprefab2;
    public GameObject bulletprefab3;

    public float radius;

    public ScoreManager sm;

    public void SpawnRandBullet()
    {
        //Vector3 randomPos = Random.insideUnitCircle * radius;
        Vector3 center = Vector3.zero;

        Vector3 randomPos = Random.insideUnitSphere * radius + center;


        if (sm.lastpressedguns == 0)
        {

            Instantiate(bulletprefab, randomPos, Quaternion.identity);

        }
        else if (sm.lastpressedguns == 1)
        {

            Instantiate(bulletprefab1, randomPos, Quaternion.identity);

        }
        else if (sm.lastpressedguns == 2)
        {

            Instantiate(bulletprefab2, randomPos, Quaternion.identity);

        }
        else if (sm.lastpressedguns == 3)
        {

            Instantiate(bulletprefab3, randomPos, Quaternion.identity);

        }

    }

}
