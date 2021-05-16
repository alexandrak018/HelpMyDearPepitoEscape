using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageObject : MonoBehaviour
{
    private DisplayImage currentDisplay;

    public GameObject[] objToManage;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();

    }

    void Update()
    {
        manageObj();
    }

    void manageObj()
    {
        for (int idx = 0; idx < objToManage.Length; idx++)
        {
            if (objToManage[idx].name == currentDisplay.GetComponent<SpriteRenderer>().sprite.name)
            {
                objToManage[idx].SetActive(true);

            }
            else 
            {
                objToManage[idx].SetActive(false);
            }
        }
    }
}
