using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whentoshootbabyisaacwithteardrops : MonoBehaviour
{
    public GameObject tearDrop;
    public GameObject tearDrop1;
    public GameObject tearDrop2;
    public BabyAtcIsaac Health;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Health.hurt >= 4)
        {
            time += Time.deltaTime;
            if(time > 2)
            {
                tearDrop.SetActive(true);
                tearDrop1.SetActive(true);
                tearDrop2.SetActive(true);
                if(time > 3)
                {
                    tearDrop.SetActive(false);
                    tearDrop1.SetActive(false);
                    tearDrop2.SetActive(false);
                    time = 0;
                }
               

            }



        }
    }
}
