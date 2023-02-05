using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlades : MonoBehaviour
{
    enum CurrentState
    {
        Idling,
        SpinningAtEnemy
    }
    [SerializeField] CurrentState currentState;
    [SerializeField] int damage;
    [SerializeField] float firerate;
    [SerializeField] bool shootCooldown;
    void SetState(CurrentState state) // Method we use to change states in the state machine.
    {
        currentState = state;
    }
    // Start is called before the first frame update
    void Start()
    {
        SetState(CurrentState.SpinningAtEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 360 * Time.deltaTime);
        switch (currentState)
        {
            case CurrentState.Idling: // Idle Behaviour
                IdleBehavior();
                break;
            case CurrentState.SpinningAtEnemy:
                SpinBlades();
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
    void SpinBlades()
    {
        transform.Rotate(0, 0, 1080 * Time.deltaTime);
    }
    void OnTriggerStay2D(Collider2D other)
    {

        IEnumerator ShootCooldown()
        {
            shootCooldown = true;
            yield return new WaitForSeconds(firerate);
            shootCooldown = false;
        }
        if (shootCooldown == false)
        {
            Debug.Log("We are shooting the Enemy!");
            other.gameObject.GetComponent<EnemyController>().ReceiveDamage(damage);
            StartCoroutine(ShootCooldown());
        }
    }

}
