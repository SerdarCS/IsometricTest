using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour {

    //Script to handle inputs to control the player

    private PlayerMovement playerMovement;

    //Stop:0
    //Left:1
    //Right:2
    //Up:3
    //Down:4
    private int curDir = 0;

    private void Awake() {
        playerMovement = GetComponent<PlayerMovement>();
        if (playerMovement == null) {
            Debug.LogError("Player Movement script not found");
        }
    }

    public void SetDirection(int dir) {
        curDir = dir;
    }

    private void Update() {
        if (playerMovement == null) {
            return;
        }

        switch (curDir) {
            case 0:
                playerMovement.SetCurMoveDir(new Vector2(0, 0));
                break;
            case 1:
                playerMovement.SetCurMoveDir(new Vector2(-1, 0));
                break;
            case 2:
                playerMovement.SetCurMoveDir(new Vector2(1, 0));
                break;
            case 3:
                playerMovement.SetCurMoveDir(new Vector2(0, 1));
                break;
            case 4:
                playerMovement.SetCurMoveDir(new Vector2(0, -1));
                break;
        }
    }
}
