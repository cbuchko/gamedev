using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpHelper : MonoBehaviour
{
    public bool shouldLerp = false;
    public float timeStartedLerping;
    public float lerpTime;
    public Vector3 destinationPosition;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        /** Make this bool true for an object to lerp it */
        if(shouldLerp){
            transform.position = Lerp(transform.position, destinationPosition, timeStartedLerping, lerpTime);
        }
        /* Once the lerping is done, stop it and destroy the object */
        if(transform.position == destinationPosition){
            shouldLerp = false;
            Destroy(gameObject);
        }
    }

    /* Incremently move the object to the destination, using the time past as a reference */
    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime = 1)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;
        var result = Vector3.Lerp(start, end, percentageComplete);

        return result;
    }
    
}
