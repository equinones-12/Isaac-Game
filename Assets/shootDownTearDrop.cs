using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootDownTearDrop : MonoBehaviour
{
    public Rigidbody2D rb;
    public int speed;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        rb.velocity = new Vector2(0, speed);
        if(time > 2)
        {
            Destroy(gameObject);

        }
    }
}
