using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour {
    float speed;
    Animator animator;
    Vector3 distance;
    Vector3 target;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();

        target = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;
        distance = target - transform.position;

        if (distance.magnitude < 1)
        {
            animator.SetFloat("forwardSpeed", 0);
        }
        else
        {
            if (distance.magnitude >= 5)
            {
                animator.SetFloat("forwardSpeed", 2, 0.3f, Time.deltaTime);
            }
            else animator.SetFloat("forwardSpeed", 1, 0.3f, Time.deltaTime);
        }

        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                transform.LookAt(hit.transform.position);
                target = hit.transform.position;
            }
        }

            
    }
}
