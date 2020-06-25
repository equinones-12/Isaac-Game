using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GetHurt : MonoBehaviour
{
    public int hurt;
    public int health;
    public SpawnNewEnemy spawn;
    public Rigidbody2D rb;
    public Animator anim;
    public int t;
    public float u;
  
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {

        if(hurt > health)
        {

            anim.SetTrigger("Die");
            t = 5;
            if (u > 0.3)
            {
                
                rb.velocity = new Vector2(2f, 0f);
            }
            if(u > 0.7)
            {
                Dead();

            }

        }
        if(t > 0)
        {
            u += Time.deltaTime;

        }

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("isaac"))
        {
            
            hurt += 1;
          

        }
    }
    public void Dead()
    {
        
        spawn.Spawn();
        Destroy(gameObject);


    }
}
