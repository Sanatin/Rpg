using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    Transform player;
    Animator animator;

    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
    }
	// Update is called once per frame
	void Update () {
        transform.LookAt(player);

        Vector3 direction = player.position - transform.position;

        Debug.Log(direction.magnitude);

        if(direction.magnitude > 2)
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
