using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour {
    Transform target;
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

                if (distance.x >= 3)
                {
                    animator.SetFloat("forwardSpeed", 0.7f, 1f, Time.deltaTime);
                }
                else animator.SetFloat("forwardSpeed", 1.4f, 1f, Time.deltaTime);                
            }
        }
    }
}
