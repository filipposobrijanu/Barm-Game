using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner1 : MonoBehaviour
{
    public GameObject[] enemyprefab;

    public float radius;

    public double timer;

    public double timebetweenspawns;

    public float counter = 0;

    private void Update()
    {

        timer += Time.deltaTime;

        if (timer > timebetweenspawns)
        {

             counter++;
             timer = 0;
             if (counter < 4)
             {
                 timebetweenspawns = timebetweenspawns + 0.05;
             }
             SpawnRandBullet();

        }

        if (counter == 4)
        {

            timebetweenspawns = 1;

        }

    }

    public void SpawnRandBullet()
    {

        Vector3 center = new Vector3(0, 13, 0);

        Vector3 randomPos = Random.insideUnitSphere * radius + center;

        int randNum5 = Random.Range(0, 6);

        Instantiate(enemyprefab[randNum5], randomPos, Quaternion.identity);


    }

}
