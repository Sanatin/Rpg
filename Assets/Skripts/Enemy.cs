using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Transform player;
    public Transform apperance;
    Animator animator;

    // Use this for initialization
    void Start ()
    {
        animator = GetComponent<Animator>();
    }
	// Update is called once per frame
	void Update () {
        transform.LookAt(player);

        Vector3 direction = player.position;

        if(direction.magnitude >= 1)
        {
            animator.SetBool("Run", true);
            animator.SetBool("Attack", false);
        }
        else
        {
            animator.SetBool("Run", false);
            animator.SetBool("Attack", true);
        }
	}
}
