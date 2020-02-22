using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateResourcePanel : MonoBehaviour
{
    public PlayerResources playerResources;
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
        instruction = GameObject.Find("LogCount").GetComponent<Text>();
        instruction.text = LogCount.ToString();

    }

    public void updateFoodCount(int FoodCount){
        instruction = GameObject.Find("FoodCount").GetComponent<Text>();
        instruction.text = FoodCount.ToString();
    }
}
