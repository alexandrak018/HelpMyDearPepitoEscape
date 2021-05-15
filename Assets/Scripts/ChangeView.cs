using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour, I_Interactable { 

    public string SpriteName;


    public void Interaction(DisplayImage currentDisplay) {
        currentDisplay.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/" + SpriteName);
        currentDisplay.CurrentState = DisplayImage.state.changedView;
    }


}
