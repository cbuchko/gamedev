using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushInteraction : MonoBehaviour
{
    private PlayerResources resources;
    // Start is called before the first frame update
    void Start()
    {
        resources = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerResources>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /** Add a way to "Pick" the bush so that you can only take 
    one berry a day */
    public void DoInteraction(){
        resources.resources["Food"] += 1;
    }
}
