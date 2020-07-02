using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public BabyAtcIsaac warning;
    public GameObject Projectile;
    private float waitTime;
    public int howmanytimes;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (warning.hurt > 4)
        {
            waitTime += Time.deltaTime;
            if (waitTime < 2)
            {
                howmanytimes = 1;
            }

            if (waitTime > 2.5)
            {
                if (howmanytimes > 0)
                {
                    Instantiate(Projectile, transform.position, Quaternion.identity);

                    howmanytimes = 0;
                }

                if (waitTime > 3)
                {
                    waitTime = 0;

                }

            }
        }
    }
}

