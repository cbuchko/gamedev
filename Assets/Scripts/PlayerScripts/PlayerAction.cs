using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour{

    private PlayerInventory inventory;
    
    public GameObject currentObject = null;

    // Start is called before the first frame update
    void Start()
    {
        
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
            PerformItemAction(); 
    }

    /* Might need to be changed so that every item
    has its own script for their actions but idk yet */

    public void PerformItemAction()
    {
        if(currentObject){
            currentObject.SendMessage("DoInteraction", inventory.equippedItem);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Interactable")){
            currentObject = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Interactable")){        
            if(other.gameObject == currentObject){
                currentObject = null;
            }
        }
    }
}
