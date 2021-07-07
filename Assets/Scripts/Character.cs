using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Touchable {

    //Script that handles character actions

    public GameObject dialogBox;

    public string dialog;

    public override void OnTouchDown() {
        if (dialogBox == null) {
            return;
        }
        dialogBox.SetActive(true);
        dialogBox.GetComponentInChildren<TextMesh>().text = dialog;
    }
}
