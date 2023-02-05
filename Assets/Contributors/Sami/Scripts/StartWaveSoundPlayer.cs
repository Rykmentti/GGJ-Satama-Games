using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWaveSoundPlayer : MonoBehaviour
{
    [SerializeField] AudioClip wave1Audio;
    [SerializeField] AudioClip wave2Audio;
    [SerializeField] AudioClip wave3Audio;
    [SerializeField] AudioClip wave4Audio;
    [SerializeField] AudioClip wave5Audio;
    [SerializeField] AudioClip bombelionArrives;
    [SerializeField] AudioClip marchigoldArrives;
    [SerializeField] AudioClip whacktusArrives;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSoundCycle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayWave1Sound()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(wave1Audio);
    }
    public void PlayWave2Sound()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(wave2Audio);
    }
    public void PlayWave3Sound()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(wave3Audio);
    }
    public void PlayWave4Sound()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(wave4Audio);
    }
    public void PlayWave5Sound()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(wave5Audio);
    }

    void PlayBonbelionSound()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(bombelionArrives);
    }
    void PlayMarchigoldSound()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(marchigoldArrives);
    }
    void PlayWhacktusSound()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(whacktusArrives);
    }

    IEnumerator StartSoundCycle()
    {
        yield return new WaitForSeconds(5);
        PlayWave1Sound();
        yield return new WaitForSeconds(2);
        PlayBonbelionSound();
        yield return new WaitForSeconds(3);
        yield return new WaitForSeconds(15);
        PlayWave2Sound();
        yield return new WaitForSeconds(2);
        PlayMarchigoldSound();
        yield return new WaitForSeconds(3);
        yield return new WaitForSeconds(15);
        PlayWave3Sound();
        yield return new WaitForSeconds(3);
        PlayWhacktusSound();
        yield return new WaitForSeconds(2);
        yield return new WaitForSeconds(15);
        PlayWave5Sound();
    }
}
