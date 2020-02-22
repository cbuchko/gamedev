using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResources : MonoBehaviour
{
    public Dictionary<string, int> resources = new Dictionary<string, int>();
    public int DayCount;

    // Start is called before the first frame update
    void Start()
    {
        resources.Add("Log", 0);
        resources.Add("Food", 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(resources);
    }

    public void IncrementDay()
    {
        DayCount += 1;
    }
}
