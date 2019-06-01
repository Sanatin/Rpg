using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour {
    float speed;
    Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;

        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                transform.LookAt(hit.transform.position);

                Vector3 distance = hit.transform.position - transform.position;

                if (distance.magnitude < 1)
                {
                    speed = 0;
                }
                else
                {
                    if (distance.magnitude >= 8)
                    {
                        speed = 2;
                    }
                    else speed = 1;
                }
            }
        }
            animator.SetFloat("forwardSpeed", speed);
    }
}
