using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MoneyUpdater : MonoBehaviour
{
    [SerializeField] TMP_Text moneyText;
    [SerializeField] GameObject resourceScript;
    [SerializeField] int playerResources;
    // Start is called before the first frame update
    void Start()
    {
        resourceScript = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        playerResources = resourceScript.GetComponent<ShopAndResourceManager>().playerResources;
        moneyText.text = playerResources.ToString();
    }
}
