using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HPUpdateScript : MonoBehaviour
{
    [SerializeField] TMP_Text HPText;
    [SerializeField] GameObject greenHouse;
    [SerializeField] int greenHouseHP;
    // Start is called before the first frame update
    void Start()
    {
        greenHouse = GameObject.Find("sprGreenhouse");
    }

    // Update is called once per frame
    void Update()
    {
        greenHouseHP = greenHouse.GetComponent<GreenHouseScript>().health;
        HPText.text = "Greenhouse Health = " + greenHouseHP.ToString();
    }
}
