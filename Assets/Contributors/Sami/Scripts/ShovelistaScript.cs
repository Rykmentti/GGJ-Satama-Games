using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelistaScript : MonoBehaviour
{
    enum CurrentState
    {
        Idling,
        ShootingAtEnemy
    }
    [SerializeField] CurrentState currentState;
    [SerializeField] GameObject currentTarget;
    [SerializeField] GameObject shovelistaProjectile;
    [SerializeField] GameObject detector;
    [SerializeField] float firerate;
    [SerializeField] bool shootCooldown;
    void SetState(CurrentState state) // Method we use to change states in the state machine.
    {
        currentState = state;
    }
    // Start is called before the first frame update
    void Start()
    {
        SetState(CurrentState.ShootingAtEnemy);
    }

    // Update is called once per frame
    void Update()
    {
        currentTarget = detector.GetComponent<DetectorScript>().detectorTarget;
        switch (currentState)
        {
            case CurrentState.Idling: // Idle Behaviour
                IdleBehavior();
                break;
            case CurrentState.ShootingAtEnemy:
                ShootAtEnemy();
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
    void ShootAtEnemy()
    {
        PointAtEnemy();
        IEnumerator ShootCooldown()
        {
            shootCooldown = true;
            yield return new WaitForSeconds(firerate);
            shootCooldown = false;
        }
        if (currentTarget == null)
        {

        }
        if (currentTarget != null && shootCooldown == false)
        {
            Debug.Log("We are shooting the Enemy!");
            SpawnProjectile();
            StartCoroutine(ShootCooldown());
        }

    }
    void PointAtEnemy()
    {
        {
            float targetPosX = currentTarget.transform.position.x;
            float targetPosY = currentTarget.transform.position.y;
            float selfPosX = transform.position.x;
            float selfPosY = transform.position.y;

            Vector2 Point_1 = new Vector2(targetPosX, targetPosY);
            Vector2 Point_2 = new Vector2(selfPosX, selfPosY);
            float rotation = Mathf.Atan2(Point_2.y - Point_1.y, Point_2.x - Point_1.x) * Mathf.Rad2Deg;
            Vector3 turretStartRotation = new Vector3(0f, 0f, rotation + 90);
            Quaternion quaternion = Quaternion.Euler(turretStartRotation);
            transform.rotation = quaternion;
        }
    }
    void SpawnProjectile()
    {
        Instantiate(shovelistaProjectile, transform.position, transform.rotation);
    }
}
