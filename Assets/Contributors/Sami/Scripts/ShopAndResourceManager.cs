using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopAndResourceManager : MonoBehaviour
{
    [SerializeField] GameObject atomizer;
    [SerializeField] GameObject shovelista;
    [SerializeField] GameObject mownlawer;

    [SerializeField] Vector2 mouseScreenPosition;
    [SerializeField] GameObject objectToBeBuilt;
    [SerializeField] Vector2 buildLocation;

    [SerializeField] bool buildMode;

    int atomizerPrice = 25;
    int shovelistaPrice = 10;
    int mownlawerPrice = 50;

    int buildCost;
    public int playerResources = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            buildMode = true;
            objectToBeBuilt = atomizer;
            buildCost = atomizerPrice;
            Debug.Log("Build Mode for Atomizer");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            buildMode = true;
            objectToBeBuilt = shovelista;
            buildCost = shovelistaPrice;
            Debug.Log("Build Mode for Shovelista");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            buildMode = true;
            objectToBeBuilt = mownlawer;
            buildCost = mownlawerPrice;
            Debug.Log("Build Mode for Mownlawer");
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && buildMode == true && playerResources >= buildCost)
        {
            Vector3 mousePos = Input.mousePosition;
            mouseScreenPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, Camera.main.nearClipPlane));
            buildLocation = mouseScreenPosition;
            Instantiate(objectToBeBuilt, buildLocation, transform.rotation);
            playerResources -= buildCost;
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            buildMode = false;
        }
    }
}
