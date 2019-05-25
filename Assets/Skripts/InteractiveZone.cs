using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveZone : MonoBehaviour {
    [SerializeField] GameObject enemy;
    [SerializeField] Transform apperance;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(enemy);
        }
    }
}
