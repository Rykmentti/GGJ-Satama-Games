using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    enum CurrentState
    {
        Idling,
        MovingTowardsNavPoint,
    }
    [SerializeField] CurrentState currentState;
    [SerializeField] public List<GameObject> NavPoints = new List<GameObject>();
    [SerializeField] Vector3 targetLocation;

    [SerializeField] float distanceToTarget;
    [SerializeField] float speed;
    [SerializeField] int currentNavPointInTheList;
    [SerializeField] bool haveWeReachedTarget;

    void SetState(CurrentState state) // Method we use to change states in the state machine.
    {
        currentState = state;
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject caller = gameObject;
        GetComponentInParent<SpawnScript>().AssignNavPointsToChildren(caller);
        currentNavPointInTheList = 0;
        targetLocation = NavPoints[currentNavPointInTheList].transform.position;
        SetState(CurrentState.MovingTowardsNavPoint);
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case CurrentState.Idling: // Idle Behaviour
                IdleBehavior();
                break;
            case CurrentState.MovingTowardsNavPoint: // Moving Towards Nav Point
                MoveTowardsNavPoint();
                break;
            default: // Default Behaviour. I.e. If statemachine does not recognize the state, it will default to this state that something is trying to put into it. (It's not in enum CurrentState?)
                Debug.Log("This state '" + currentState + "' for state machine doesn't exist, or there is a typo in name(string) of the state, defaulting to Idle State");
                SetState(CurrentState.Idling);
                break;
        }
    }

    void IdleBehavior()
    {

    }

    void MoveTowardsNavPoint()
    {

        DistanceCalcuation();
        Vector3 moveDirection = (targetLocation - transform.position).normalized;
        if (distanceToTarget < 0.01f && haveWeReachedTarget != true)
        {
            currentNavPointInTheList++;
            targetLocation = NavPoints[currentNavPointInTheList].transform.position;
        }
        else
        {
            transform.Translate(speed * Time.deltaTime * moveDirection);
            if (distanceToTarget >= 0.01f)
            {
                haveWeReachedTarget = false;
            }
        }
    }
    float DistanceCalcuation()
    {
       distanceToTarget = Vector3.Distance(targetLocation, transform.position);
       Debug.Log("Distance to target is " + distanceToTarget);
       return distanceToTarget;
    }
}
