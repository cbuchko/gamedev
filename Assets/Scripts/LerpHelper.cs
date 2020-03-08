using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpHelper : MonoBehaviour
{
    public bool shouldLerp = false;

    public float timeStartedLerping;
    public float lerpTime;
    public Transform endPosition;
    private Vector3 destinationPosition;
    // Start is called before the first frame update

    private void StartLerping()
    {
        timeStartedLerping = Time.time;
        destinationPosition = Camera.main.ScreenToWorldPoint(endPosition.position);
    }
    void Start()
    {
        StartLerping();  
    }

    // Update is called once per frame
    void Update()
    {
        if(shouldLerp){
            transform.position = Lerp(transform.position, destinationPosition, timeStartedLerping, lerpTime);
        }
        if(transform.position == destinationPosition){
            shouldLerp = false;
            Destroy(gameObject);
        }
    }

    public Vector3 Lerp(Vector3 start, Vector3 end, float timeStartedLerping, float lerpTime = 1)
    {
        float timeSinceStarted = Time.time - timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;
        var result = Vector3.Lerp(start, end, percentageComplete);

        return result;
    }
    
}
