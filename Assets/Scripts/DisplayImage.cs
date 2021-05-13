using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImage : MonoBehaviour
{

    public enum state
    { 
        normal, zoomed
    };

    public state CurrentState { get; set; }

    public int CurrentWall
    {
        get
        {
            return currentWall;
        }

        set
        {
            if (value == 5)
                currentWall = 1;
            else if (value == 0)
                currentWall = 4;
            else
                currentWall = value;
        }

    }

    private int currentWall;
    private int prevWall;

    void Start()
    {
        prevWall = 0;
        currentWall = 1;
    }

    void Update()
    {
        if (currentWall != prevWall)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/wall" + currentWall.ToString());
        }

        prevWall = currentWall;

    }
}
