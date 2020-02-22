using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampfireInteraction : MonoBehaviour
{
    public Button yesButton;
    public Button noButton;
    bool campfireEnabled;
    // Start is called before the first frame update
    void Start()
    {   
        campfireEnabled = GetComponent<CampfireInteraction>().enabled;
        yesButton.onClick.AddListener(SleepConfirm);
        noButton.onClick.AddListener(SleepDeny);
        //GetComponent<EventInteraction>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void DoInteraction()
    {
        if(campfireEnabled){
            campfireInteract();
        }
    }

    public void campfireInteract()
    {
        GameObject bedtimePanel = GameObject.Find("BedtimePanel");
        Animator animator = bedtimePanel.GetComponent<Animator>();
        if(animator != null){
            animator.SetBool("Display", true);
        }       
    }

    public void SleepConfirm()
    {
        /** this is currently being done in Fade  
        attachced to the yes button */

    }

    public void SleepDeny()
    {
        GameObject bedtimePanel = GameObject.Find("BedtimePanel");
        Animator animator = bedtimePanel.GetComponent<Animator>();
        if(animator != null){
            animator.SetBool("Display", false);
        }       
    }
}

