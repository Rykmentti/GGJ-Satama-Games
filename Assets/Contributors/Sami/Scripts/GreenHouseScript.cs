using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GreenHouseScript : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] Image fadeOutScreen;
    [SerializeField] GameObject loseText;
    bool onlyExecuteOnce;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeIn());
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0 && onlyExecuteOnce == false)
        {
            onlyExecuteOnce = true;
            Debug.Log("You lose!");
            StartCoroutine(FadeOut());
            loseText.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherGameObject = collision.gameObject;
        health -= otherGameObject.GetComponent<EnemyController>().health;
        Destroy(otherGameObject);
    }
    public IEnumerator FadeIn()
    {

        GameObject fadeScreen = new GameObject();
        fadeScreen.name = "Fade Screen";
        fadeScreen.AddComponent<Canvas>();
        Canvas fadeScreenCanvas = fadeScreen.GetComponent<Canvas>();
        fadeScreenCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
        fadeScreenCanvas.sortingOrder = 1000;
        fadeScreen.AddComponent<CanvasScaler>();
        fadeScreen.AddComponent<GraphicRaycaster>();
        fadeScreen.AddComponent<Image>();
        Image fadeScreenImage = fadeScreen.GetComponent<Image>();

        fadeScreenImage.color = new Color(0, 0, 0, 1);
        for (float i = 1; i > 0; i -= (float)0.01)
        {
            fadeScreenImage.color = new Color(0, 0, 0, i);
            Debug.Log("transparency is = " + i);
            yield return new WaitForSeconds(.01f);
        }
        Destroy(fadeScreen);
    }
    public IEnumerator FadeOut()
    {

        GameObject fadeScreen = new GameObject();
        fadeScreen.name = "Fade Screen";
        fadeScreen.AddComponent<Canvas>();
        Canvas fadeScreenCanvas = fadeScreen.GetComponent<Canvas>();
        fadeScreenCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
        fadeScreenCanvas.sortingOrder = 1000;
        fadeScreen.AddComponent<CanvasScaler>();
        fadeScreen.AddComponent<GraphicRaycaster>();
        fadeScreen.AddComponent<Image>();
        Image fadeScreenImage = fadeScreen.GetComponent<Image>();
        fadeScreenImage.color = new Color(0, 0, 0, 0);
        for (float i = 0; i < 1; i += (float)0.01)
        {
            fadeScreenImage.color = new Color(0, 0, 0, i);
            Debug.Log("transparency is = " + i);
            yield return new WaitForSeconds(.01f);
        }
        // Jos käytät tätä FadeOut Ienumeraattoria lopettamaan scenen, niin lisää tähän kohtaan koodi SceneManager funktio > SceneManager.LoadScene("haluamasi scene path");
        // Muista lisätä build settingsin scene in build listalle.
    }
}
