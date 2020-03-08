using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BushInteraction : MonoBehaviour
{
    private PlayerResources resources;
    public int PickCount;
    public bool Empty;
    public Sprite FullSprite;
    public Sprite EmptySprite;
    // Start is called before the first frame update
    void Start()
    {
        resources = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerResources>();
        Button YesButton = GameObject.Find("YesButton").GetComponent<Button>();
        YesButton.onClick.AddListener(() => RefillBush());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /** Add a way to "Pick" the bush so that you can only take 
    one berry a day */
    public void DoInteraction(){
        if(!Empty){
            resources.resources["Food"] += 1;
            PickCount += 1;
            if(PickCount >= 2){
                EmptyBush();
            }
        }
    }

    public void EmptyBush(){
        Empty = true;
        GetComponent<SpriteRenderer>().sprite = EmptySprite;

    }

    public void RefillBush(){
        Empty = false;
        GetComponent<SpriteRenderer>().sprite = FullSprite;
        PickCount = 0;
    }
}
