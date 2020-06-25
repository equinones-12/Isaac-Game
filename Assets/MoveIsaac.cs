using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveIsaac : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    public Animator anim;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal") , 0);
        moveVelocity = moveInput.normalized * speed;
        if (Input.GetKey("d"))
        {

            anim.SetTrigger("BabyAtc");


        }

        
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);


    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("enemy"))
        {

            camera.GetComponent<trigger>().Shake();
        }


    }
}
