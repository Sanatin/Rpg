using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveZone : MonoBehaviour {
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject apperance;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(enemy);
        }
        enemy.transform.position = apperance.transform.position;
    }
}
