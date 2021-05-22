using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PuzzleGame : MonoBehaviour
{
    public bool isCompleted { get;  private set; }

    private GameObject displayImage;

    void Start()
    {
        displayImage = GameObject.Find("displayImage");
    }

     void Update()
    {
        
        if (finishedPuzzle())
        {
            Debug.Log("Puzzle done");
        }

        hideDisplay();
    }

    void hideDisplay() 
    {
        if (Input.GetMouseButton(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            this.gameObject.SetActive(false);
        }

        if (displayImage.GetComponent<DisplayImage>().CurrentState == DisplayImage.state.normal)
        {
            this.gameObject.SetActive(false);
        }


    }

    bool finishedPuzzle()
    {
        if (isCompleted) 
            return true;

        isCompleted = true;

        var puzzlePieces = FindObjectsOfType<PuzzlePiece>();

        foreach (PuzzlePiece puzzlePiece in puzzlePieces)
        {
            if (!(int.Parse(puzzlePiece.gameObject.name.ToString().Substring(puzzlePiece.gameObject.name.Length - 1)) ==
                int.Parse(puzzlePiece.gameObject.GetComponent<Image>().sprite.name.ToString().Substring(puzzlePiece.gameObject.GetComponent<Image>().sprite.name.Length - 1))))
            {
                isCompleted = false;
            }
        }

        return isCompleted;
    }


}
