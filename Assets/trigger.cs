using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Shake()
    {
        anim.SetTrigger("Shake");
    }
    // Update is called once per frame
    public void EShake()
    {
        anim.SetTrigger("ExtremeShake");
    }
}
