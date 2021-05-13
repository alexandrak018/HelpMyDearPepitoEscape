using System.Collections;
using UnityEngine;

public class ZoomInObject : MonoBehaviour, I_Interactable
   {

    public float zoomRatio = .5f;
    public void Interaction(DisplayImage currentDisplay)
    {
        Camera.main.orthographicSize *= zoomRatio;
        Camera.main.transform.position = new Vector3(this.transform.position.x, this.transform.position.y,
            Camera.main.transform.position.z);

        gameObject.layer = 2;

        currentDisplay.CurrentState = DisplayImage.state.zoomed;

        constraintCamera();
    }

    void constraintCamera()
    {
        var height = Camera.main.orthographicSize;
        var width = height * Camera.main.aspect;

        var cameraBounds = GameObject.Find("cameraBounds");

        if (Camera.main.transform.position.x + width > cameraBounds.transform.position.x + cameraBounds.GetComponent<BoxCollider2D>().size.x / 2)
        {
            Camera.main.transform.position += new Vector3(cameraBounds.transform.position.x + cameraBounds.GetComponent<BoxCollider2D>().size.x / 2 -
                (Camera.main.transform.position.x + width), 0, 0);
        }

        if (Camera.main.transform.position.x - width < cameraBounds.transform.position.x - cameraBounds.GetComponent<BoxCollider2D>().size.x / 2)
        {
            Camera.main.transform.position += new Vector3(cameraBounds.transform.position.x - cameraBounds.GetComponent<BoxCollider2D>().size.x / 2 -
                (Camera.main.transform.position.x - width), 0, 0);
        }

        if (Camera.main.transform.position.y + height > cameraBounds.transform.position.y + cameraBounds.GetComponent<BoxCollider2D>().size.y / 2)
        {
            Camera.main.transform.position += new Vector3(0, cameraBounds.transform.position.y + cameraBounds.GetComponent<BoxCollider2D>().size.y / 2 -
                (Camera.main.transform.position.y + height), 0);
        }

        if (Camera.main.transform.position.y - height < cameraBounds.transform.position.y - cameraBounds.GetComponent<BoxCollider2D>().size.y / 2)
        {
            Camera.main.transform.position += new Vector3(0, cameraBounds.transform.position.y - cameraBounds.GetComponent<BoxCollider2D>().size.y / 2 -
                (Camera.main.transform.position.y - height), 0);
        }
    }  
    //henlo

   }