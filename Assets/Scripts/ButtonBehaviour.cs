using System.Collections; //Testcomment
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    public enum buttonId
    { 
        wallChangeButton, backButton
    };

    public buttonId currentButtonId;

    private DisplayImage currentDisplay;

    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
      
    }

    void Update()
    {
        hideDisplay();
        display_button();
    }
    
    void hideDisplay()
    {
        if (currentDisplay.CurrentState == DisplayImage.state.normal && currentButtonId == buttonId.backButton)
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                                            GetComponent<Image>().color.b, 0);

            GetComponent<Button>().enabled = false;

            this.transform.SetSiblingIndex(0);
        }

        if (currentDisplay.CurrentState == DisplayImage.state.zoomed && currentButtonId == buttonId.wallChangeButton)
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                                                GetComponent<Image>().color.b, 0);

            GetComponent<Button>().enabled = false;

            this.transform.SetSiblingIndex(0);

        }

        if (currentDisplay.CurrentState == DisplayImage.state.changedView && currentButtonId == buttonId.wallChangeButton)
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                                                GetComponent<Image>().color.b, 0);

            GetComponent<Button>().enabled = false;

            this.transform.SetSiblingIndex(0);

        }

    }

    void display_button()
    {
        if (!(currentDisplay.CurrentState == DisplayImage.state.normal) && currentButtonId == buttonId.backButton)
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                                                GetComponent<Image>().color.b, 1);

            GetComponent<Button>().enabled = true;
        }

        if (currentDisplay.CurrentState == DisplayImage.state.normal && currentButtonId == buttonId.wallChangeButton)
        {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g,
                                                GetComponent<Image>().color.b, 1);

            GetComponent<Button>().enabled = true;

        }

     


    }

}
