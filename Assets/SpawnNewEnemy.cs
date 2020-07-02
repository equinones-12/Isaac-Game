using System;

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewEnemy : MonoBehaviour
{
    public GameObject enemy;
    public int ran;
    public int doy;
    public int amountOfEnimiesGone;
    public GameObject enemy2;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void Update()
    {
        if (doy == 1)
        {
            ran = UnityEngine.Random.Range(1, 10);
            if(ran > 5)
            {

                Instantiate(enemy, new Vector2(0.436f, 0.029f), Quaternion.identity);
                amountOfEnimiesGone += 1;
                doy = 0;
            }
            if (ran < 5)
            {

                Instantiate(enemy2, new Vector2(0.436f, 0.029f), Quaternion.identity);
                amountOfEnimiesGone += 1;
                doy = 0;
            }
        }
    }
    // Update is called once per frame
    public void Spawn()
    {
        doy = 1;
      
    }
}
