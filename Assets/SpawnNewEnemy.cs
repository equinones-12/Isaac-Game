using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewEnemy : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Spawn()
    {
        Instantiate(enemy, new Vector2(0.436f, 0.029f), Quaternion.identity);
    }
}
