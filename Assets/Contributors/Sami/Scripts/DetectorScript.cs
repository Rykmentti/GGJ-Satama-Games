using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    public GameObject detectorTarget;
    [SerializeField] float detectorTargetDistance;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (detectorTarget != null)
        {
            DistanceCalcuation();
        }
    }
    /*void OnTriggerEnter2D(Collider2D other)
    {
        if (detectorTarget == null)
        {
            detectorTarget = other.gameObject;
        }
    }
    */
    void OnTriggerStay2D(Collider2D other)
    {
        if (detectorTarget != null)
        {
            return;
        }
        if (detectorTarget == null)
        {
            detectorTarget = other.gameObject;
        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (detectorTargetDistance >= 5f && detectorTarget != null)
        {
            detectorTarget = null;
        }
        
    }
    float DistanceCalcuation()
    {
        detectorTargetDistance = Vector3.Distance(detectorTarget.transform.position, transform.position);
        //Debug.Log("Distance to target is " + detectorTargetDistance);
        return detectorTargetDistance;
    }
}
