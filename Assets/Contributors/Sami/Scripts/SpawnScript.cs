using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [SerializeField] public List<GameObject> NavPoints = new List<GameObject>();

    [SerializeField] GameObject startWaveAudioPlayer;
    [SerializeField] GameObject resourceScript;
    [SerializeField] GameObject StartWaveSoundPlayer;
    [SerializeField] GameObject StartWaveSoundEffectPlayer;
    [SerializeField] GameObject bonbelion;
    [SerializeField] GameObject marchigold;
    [SerializeField] GameObject whactus;

    int waveCount = 0;
    float timeBetweenWaves = 20;
    bool waveCooldown;
    // Start is called before the first frame update
    void Start()
    {
        StartWaveSoundPlayer = GameObject.Find("StartWaveSoundPlayer");
        StartWaveSoundEffectPlayer = GameObject.Find("StarWaveSoundEffectPlayer");
        resourceScript = GameObject.Find("Canvas");
        StartCoroutine(SpawnWaves());
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
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(5);
        StartCoroutine(StartWave1());
        yield return new WaitForSeconds(timeBetweenWaves);
        StartCoroutine(StartWave2());
        yield return new WaitForSeconds(timeBetweenWaves);
        StartCoroutine(StartWave3());
        yield return new WaitForSeconds(timeBetweenWaves);
        StartCoroutine(StartWave4());
        yield return new WaitForSeconds(timeBetweenWaves);
        StartCoroutine(StartWave5());
        Debug.Log("All Waves have spawned");
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
    IEnumerator StartWave1()
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
        yield return new WaitForSeconds(1);
        resourceScript.GetComponent<ShopAndResourceManager>().playerResources += 50;
        yield return new WaitForSeconds(1);
        waveCount++;
        waveCooldown = false;
    }
    IEnumerator StartWave2()
    {
        waveCooldown = true;
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        resourceScript.GetComponent<ShopAndResourceManager>().playerResources += 50;
        yield return new WaitForSeconds(1);
        waveCount++;
        waveCooldown = false;
    }
    IEnumerator StartWave3()
    {
        waveCooldown = true;
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        resourceScript.GetComponent<ShopAndResourceManager>().playerResources += 150;
        yield return new WaitForSeconds(1);
        waveCount++;
        waveCooldown = false;
    }
    IEnumerator StartWave4()
    {
        waveCooldown = true;
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
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
        yield return new WaitForSeconds(1);
        SpawnBonbelion();
        yield return new WaitForSeconds(1);
        resourceScript.GetComponent<ShopAndResourceManager>().playerResources += 250;
        yield return new WaitForSeconds(1);
        waveCount++;
        waveCooldown = false;
    }
    IEnumerator StartWave5()
    {
        waveCooldown = true;
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnWhactus();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        SpawnMarchigold();
        yield return new WaitForSeconds(1);
        waveCount++;
        waveCooldown = false;
    }
}
