using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemPickup : MonoBehaviour
{
    private PlayerInventory inventory;
    public GameObject itemButton;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventory>();
        
    }

    void OnTriggerEnter2D(Collider2D other){

        if (other.CompareTag("Player")){
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false){
                    inventory.isFull[i] = true;

                    Color tempColor = inventory.slots[i].GetComponent<Image>().color;
                    tempColor.a = 1;
                    inventory.slots[i].GetComponent<Image>().color = tempColor;

                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
