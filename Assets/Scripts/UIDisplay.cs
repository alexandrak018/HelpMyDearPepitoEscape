using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIDisplay : MonoBehaviour, I_Interactable
{
    public GameObject displayObj;

    public void Interaction(DisplayImage currentDisplay)
    {
        displayObj.SetActive(true);
    
    }
}
