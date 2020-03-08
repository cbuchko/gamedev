using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeInteraction : MonoBehaviour
{
    private PlayerResources resources;
    private PlayerAction action;
    public Transform spawnPoint;
    public GameObject objectToRender;
    

    // Start is called before the first frame update
    void Start()
    {
        resources = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerResources>();
        action = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAction>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    /** Different things happen depending on whats equipped */
    public void DoInteraction(GameObject actionItem)
    {
        switch(actionItem.tag)
        {
        case "Axe":
            AxeInteraction();
            break;
        default:
            //FistInteraction();
            break;
        }
          
    }

    /** Main way to interact with a tree. Drops a log on the ground */
    public void AxeInteraction()
    {
        Instantiate(objectToRender, spawnPoint.position, spawnPoint.rotation);
        // resources.resources["Log"] += 1;
        action.currentObject = null;
        gameObject.SetActive(false); 
    }

    public void FistInteraction()
    {
        //Debug.Log("Ouch that hurts");
    }
}
