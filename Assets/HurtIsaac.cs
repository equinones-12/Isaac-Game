using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtIsaac : MonoBehaviour
{
    public int howmuchyouhurt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("isaac"))
        {
            IsaacHealth.healths -= howmuchyouhurt;



        }
    }
}
