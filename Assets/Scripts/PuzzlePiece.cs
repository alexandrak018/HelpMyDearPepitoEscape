using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PuzzlePiece : MonoBehaviour, IPointerClickHandler
{
    private GameObject puzzle;

    private Image changeSprite; 

    void Start()
    {
        puzzle = GameObject.Find("Puzzle");
    }

    void Update()
    {

    }

    void ChangeSprite(Image stSprite, Image ndSprite)
    {
        Sprite aux = stSprite.sprite;
        stSprite.sprite = ndSprite.sprite;
        ndSprite.sprite = aux;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (puzzle.GetComponent<PuzzleGame>().isCompleted == true)
        {
            return;
        }

        var puzzlePieces = FindObjectsOfType<PuzzlePiece>();

        foreach (PuzzlePiece puzzlePiece in puzzlePieces)
        {
            if (int.Parse(this.gameObject.name.ToString().Substring(this.gameObject.name.Length - 1)) ==
                int.Parse((puzzlePiece.gameObject.name.ToString().Substring(puzzlePiece.gameObject.name.Length - 1))) + 1
                ||
                int.Parse(this.gameObject.name.ToString().Substring(this.gameObject.name.Length - 1)) ==
                int.Parse((puzzlePiece.gameObject.name.ToString().Substring(puzzlePiece.gameObject.name.Length - 1))) - 1
                ||
                int.Parse(this.gameObject.name.ToString().Substring(this.gameObject.name.Length - 1)) ==
                int.Parse((puzzlePiece.gameObject.name.ToString().Substring(puzzlePiece.gameObject.name.Length - 1))) + 3
                ||
                int.Parse(this.gameObject.name.ToString().Substring(this.gameObject.name.Length - 1)) ==
                int.Parse((puzzlePiece.gameObject.name.ToString().Substring(puzzlePiece.gameObject.name.Length - 1))) - 3)
            {
                if (puzzlePiece.gameObject.GetComponent<Image>().sprite.name == "tinkerbell_8")
                {
                    changeSprite = puzzlePiece.GetComponent<Image>();
                    ChangeSprite(GetComponent<Image>(), changeSprite);
                }
            }
        }


    }

}
