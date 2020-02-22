using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject equippedItem;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        try{
        equippedItem = slots[0].transform.GetChild(0).gameObject;
        }catch(UnityException){
        }
    }
}
