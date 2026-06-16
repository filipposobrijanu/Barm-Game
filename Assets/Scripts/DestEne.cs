using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestEne : MonoBehaviour
{
    public float timer;

    void Update()
    {

        timer += Time.deltaTime;

        if (timer > 12)
        {

            Destroy(gameObject);

        }

    }

}
