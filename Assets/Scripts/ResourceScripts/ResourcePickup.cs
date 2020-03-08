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

    /** Need to not hardcode this to only work with logs */
    /** When collided with a resource, lerp it to the panel and
        increment the value */
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){       
            gameObject.GetComponent<LerpHelper>().timeStartedLerping = Time.time;
            gameObject.GetComponent<LerpHelper>().shouldLerp = true;
            resources.resources["Log"] += 1;
        }
    }
}
