using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointRender : MonoBehaviour
{
    public int MinDay;
    public int currentDay;
    public Transform spawnPoint;
    public GameObject objectToRender;
    bool spawned;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentDay = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerResources>().DayCount;
        if(currentDay >= MinDay && !spawned){
            renderObject();
        }
    }

    public void renderObject()
    {
        //objectToRender = GameObject.GetComponent<Rigidbody>();
        spawned = true;
        Instantiate(objectToRender, spawnPoint.position, spawnPoint.rotation);
    
    }
}
