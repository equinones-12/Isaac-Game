using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyAtcIsaac : MonoBehaviour
{
    public int health;
    public int hurt;
    public GameObject spawn;
    public Animator anim;
    public float u;
    public int t;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.FindWithTag("spawn");
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("isaac"))
        {
            hurt += 1;


        }
    }
    void Update()
    {
        if (hurt > health)
        {

            anim.SetTrigger("Die");
            t = 5;
            if (u > 0.1)
            {

                rb.velocity = new Vector2(8f, 0f);
            }
            if (u > 0.7)
            {
                Dead();

            }

        }
        if (t > 0)
        {
            u += Time.deltaTime;

        }



    }
    public void Dead()
    {
        spawn.GetComponent<SpawnNewEnemy>().doy = 1 ;
        Destroy(gameObject);
    }
}
