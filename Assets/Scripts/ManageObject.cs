using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageObject : MonoBehaviour
{
    private DisplayImage currentDisplay;

    public GameObject[] objToManage;
    public GameObject[] uiRenderObj;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        renderUI();

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

    void renderUI()
    {
        for (int idx = 0; idx < uiRenderObj.Length; idx++)
        {
            uiRenderObj[idx].SetActive(false);
        }
    }

}
