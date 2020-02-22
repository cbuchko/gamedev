using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventInteraction : MonoBehaviour
{
    public int cost;
    public string resourceType;
    private Dictionary<string, int> resources;
    private string errorMessage;
    bool eventEnabled = true;

    // Start is called before the first frame update
    void Start()
    {
        errorMessage = "Looks like I need at least " + cost + " " + resourceType + ".";
        resources = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerResources>().resources;
    }

    // Update is called once per frame
    void Update()
    {

    }

    /** IDEA: Disable event script after the event gets enabled,
        and then enable a more specific script(ie. a campfire script that
        can then be further interacted with) */
        
    public void DoInteraction(){      
        if(eventEnabled){
            if(resources[resourceType] >= cost){
                GetComponent<SpriteRenderer>().color = Color.white;
                resources[resourceType] -= cost;
                GetComponent<CampfireInteraction>().enabled = true;
                eventEnabled = false;
            }else{

                GameObject alert = GameObject.Find("AlertPanel");
                Animator animator = alert.GetComponent<Animator>();
                if(animator != null)
                {
                    animator.SetTrigger("Display");
                }
                GameObject.Find("AlertText").GetComponent<Text>().text = errorMessage;                           
            }
        }
    }
}
