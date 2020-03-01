using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateResourcePanel : MonoBehaviour
{
    public PlayerResources playerResources;
    public GameObject resourcePanel;
    public GameObject foodText;
    public GameObject foodImage;
    Text instruction;
    // Start is called before the first frame update
    void Start()
    {
        playerResources = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerResources>();
    }

    // Update is called once per frame
    void Update()
    {
        updateResourceCount();
    }

    public void updateResourceCount(){

        foreach(var resource in playerResources.resources){
            switch(resource.Key)
            {
                case "Log":
                    updateLogCount(resource.Value);
                    break;
                case "Food":
                    updateFoodCount(resource.Value);
                    break;
                default:
                    break;
            }
        }
    }

    public void updateLogCount(int LogCount){
        //Initial statement to activate the resource panel after the first log has been collected
        if(LogCount != 0)
            resourcePanel.SetActive(true);
        
        if(resourcePanel.activeSelf){
            instruction = GameObject.Find("LogCount").GetComponent<Text>();
            instruction.text = LogCount.ToString();
        }   
    }

    public void updateFoodCount(int FoodCount){
        //Initial statement to activate the food resource after the first food has been collected
        if(FoodCount != 0){
            foodImage.SetActive(true);
            foodText.SetActive(true);
        }

        if(foodImage.activeSelf){
            instruction = GameObject.Find("FoodCount").GetComponent<Text>();
            instruction.text = FoodCount.ToString();
        }
    }
}
