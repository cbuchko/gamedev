using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCount : MonoBehaviour
{
    public List<GameObject> forest = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform child in this.gameObject.transform)
        {
            forest.Add(child.gameObject);
        }       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
