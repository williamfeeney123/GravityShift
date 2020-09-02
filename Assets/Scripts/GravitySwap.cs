using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwap : MonoBehaviour
{
    public Rigidbody2D Rigid;

    void OnCollisionEnter2D(Collision2D other)
    {
       
        if (other.gameObject.CompareTag("Player"))
        {
            Rigid.mass = 4;
            Rigid.gravityScale = -.4f; // This is if you want to turn the gravity off;
        }
    
    }

}
