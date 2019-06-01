using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    Animator animat;
    int health;

    public void Start()
    {
        animat = GetComponent<Animator>();
    }
    public void Damage (int damage)
    {
        health -= damage;

        if (health <= 0) animat.SetBool("Death", true);
    }

}
