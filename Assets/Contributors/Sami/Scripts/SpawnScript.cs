using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [SerializeField] public List<GameObject> NavPoints = new List<GameObject>();

    [SerializeField] GameObject bonbelion;
    [SerializeField] GameObject marchigold;
    [SerializeField] GameObject whactus;

    int waveCount = 0;
    float timeBetweenWaves = 15;
    bool waveCooldown;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            Instantiate(bonbelion, transform.position, transform.rotation, transform.parent = transform);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            Instantiate(marchigold, transform.position, transform.rotation, transform.parent = transform);
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            Instantiate(whactus, transform.position, transform.rotation, transform.parent = transform);
        }
            if (waveCooldown == false)
        {
            //StartCoroutine(StartWave());
        }
    }
    void SpawnWaves()
    {
        if (waveCount == 1)
        {

        }
        if (waveCount == 2)
        {

        }
        if (waveCount == 3)
        {

        }
        if (waveCount == 4)
        {

        }
        if (waveCount == 5)
        {

        }
    }
    void SpawnBonbelion()
    {
        Instantiate(bonbelion, transform.position, transform.rotation, transform.parent = transform);
    }
    void SpawnMarchigold()
    {
        Instantiate(marchigold, transform.position, transform.rotation, transform.parent = transform);
    }
    void SpawnWhactus()
    {
        Instantiate(whactus, transform.position, transform.rotation, transform.parent = transform);
    }
    public void AssignNavPointsToChildren(GameObject caller)
    {
        caller.GetComponent<MovementScript>().NavPoints[0] = NavPoints[0];
        caller.GetComponent<MovementScript>().NavPoints[1] = NavPoints[1];
        caller.GetComponent<MovementScript>().NavPoints[2] = NavPoints[2];
        caller.GetComponent<MovementScript>().NavPoints[3] = NavPoints[3];
        caller.GetComponent<MovementScript>().NavPoints[4] = NavPoints[4];
        caller.GetComponent<MovementScript>().NavPoints[5] = NavPoints[5];
        caller.GetComponent<MovementScript>().NavPoints[6] = NavPoints[6];
    }
    IEnumerator StartWave()
    {
        waveCooldown = true;
        SpawnBonbelion();
        yield return new WaitForSeconds(1);
        SpawnBonbelion();
        yield return new WaitForSeconds(1);
        SpawnBonbelion();
        yield return new WaitForSeconds(1);
        SpawnBonbelion();
        yield return new WaitForSeconds(1);
        SpawnBonbelion();
        yield return new WaitForSeconds(1);
        SpawnBonbelion();
        yield return new WaitForSeconds(1);
        SpawnBonbelion();
        yield return new WaitForSeconds(1);
        SpawnBonbelion();
        yield return new WaitForSeconds(1);
        SpawnBonbelion();
        yield return new WaitForSeconds(1);
        SpawnBonbelion();
        yield return new WaitForSeconds(1);
        SpawnBonbelion();
        yield return new WaitForSeconds(timeBetweenWaves);
        waveCount++;
        waveCooldown = false;
    }
}
