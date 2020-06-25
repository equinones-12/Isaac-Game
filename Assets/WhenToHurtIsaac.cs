using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WhenToHurtIsaac : MonoBehaviour
{
    public GetHurt Hurt;
    public Animator anim;
    private float howOften;
    public bool shouldIhit;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("isaac"))
        {
            shouldIhit = true;

        }


    }
    // Update is called once per frame
    void Update()
    {
        if (shouldIhit == true)
        {
            howOften += Time.deltaTime;
            if (howOften > 5)
            {
                anim.SetTrigger("Atc");
                trunitfalse();
                 howOften = 0;
            }
            
            if (Hurt.hurt > 4)
            {
                howOften += Time.deltaTime;
                if (howOften > 4)
                {
                    anim.SetTrigger("Atc");
                    trunitfalse();
                    howOften = 0;
                }


            }
        }
    }
    public void trunitfalse()
    {
        shouldIhit = false;


    }
}
