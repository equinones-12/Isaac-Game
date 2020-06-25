using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class IsaacHealth : MonoBehaviour
{ Image bar;
    float maxHealth = 100f;
    public static float healths;
    

    // Start is called before the first frame update
    void Start()
    {
       bar = GetComponent<Image> ();
       healths = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = healths / maxHealth;
      

     if(bar.fillAmount == 0){
        
SceneManager.LoadScene("dead");





     }

    }




}