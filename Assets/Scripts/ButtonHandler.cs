using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonHandler : MonoBehaviour
{
    private DisplayImage currentDisplay;
    private float initialCamSize;
    private Vector3 initialCamPos;


    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        initialCamSize = Camera.main.orthographicSize;
        initialCamPos = Camera.main.transform.position;
    }

    public void RightArrow()
    {
        currentDisplay.CurrentWall++;
    }

    public void LeftArrow()
    {
        currentDisplay.CurrentWall--;
    }

    public void zoomReturn()
    {
        GameObject.Find("displayImage").GetComponent<DisplayImage>().CurrentState = DisplayImage.state.normal;
        var zoomInObjects = FindObjectsOfType<ZoomInObject>();
        foreach(var zoomInObject in zoomInObjects)
        {
            zoomInObject.gameObject.layer = 0;
        }

        Camera.main.orthographicSize = initialCamSize;
        Camera.main.transform.position = initialCamPos;

    }

}


