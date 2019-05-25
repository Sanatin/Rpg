using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Transform player;
    public Transform apperance;

    // Use this for initialization
    void Start () {
        transform.position = apperance.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(player);
	}
}
