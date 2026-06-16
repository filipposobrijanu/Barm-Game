using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyprefab;

    public float radius;

    public double timer;

    public float timebetweenspawns;

    public float speedmultiplier;

    public ScoreManager sm;

    private void Update()
    {

        if (sm.score >= 10) 
        {

            speedmultiplier += Time.deltaTime * 0.005f;

            timebetweenspawns = 4 - speedmultiplier;

            timer += Time.deltaTime;

            if (timer > timebetweenspawns)
            {
                timer = 0;
                SpawnRandBullet();

            }
        }

    }

    public void SpawnRandBullet()
    {

        Vector3 center = new Vector3(0, 15, 0);

        Vector3 randomPos = Random.insideUnitSphere * radius + center;
        Vector3 randomPos_ = Random.insideUnitSphere * radius * 0.5f + center;

        if (sm.score >= 10 && sm.score < 15)
        {

            int randNum = Random.Range(0, 2);

            Instantiate(enemyprefab[randNum], randomPos, Quaternion.identity);
        }

        if (sm.score >= 15 && sm.score < 20) 
        {

            int randNum1 = Random.Range(0, 3);

            Instantiate(enemyprefab[randNum1], randomPos, Quaternion.identity);
        }

        if (sm.score >= 20 && sm.score < 30)
        {

            int randNum2 = Random.Range(0, 4);

            Instantiate(enemyprefab[randNum2], randomPos, Quaternion.identity);
        }

        if (sm.score >= 30 && sm.score < 50)
        {

            int randNum3 = Random.Range(0, 5);
            int randNum3_ = Random.Range(0, 5);

            Instantiate(enemyprefab[randNum3], randomPos, Quaternion.identity);
            Instantiate(enemyprefab[randNum3_], randomPos_, Quaternion.identity);

        }

        if (sm.score >= 50)
        {

            int randNum4 = Random.Range(0, 6);
            int randNum4_ = Random.Range(0, 6);

            Instantiate(enemyprefab[randNum4], randomPos, Quaternion.identity);
            Instantiate(enemyprefab[randNum4_], randomPos_, Quaternion.identity);
        }


    }

}
