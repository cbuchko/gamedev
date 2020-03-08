using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcePickup : MonoBehaviour
{
    private PlayerResources resources;
    void Start()
    {
        resources = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerResources>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            resources.resources["Log"] += 1;       
            gameObject.GetComponent<LerpHelper>().shouldLerp = true;
        }
    }
}
