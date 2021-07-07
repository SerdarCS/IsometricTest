using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour {

    //Script to handle touch events and invoke touchable objects

    private void Update() {
        if (Application.isEditor) {
            EditorMode();
            return;
        }
        if (Input.touchCount <= 0) {
            return;
        }
        if (Input.GetTouch(0).phase == TouchPhase.Began) {
            RaycastFromScreenPosition(Input.GetTouch(0).position);
        }
    }

    private void EditorMode() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastFromScreenPosition(Input.mousePosition);
        }
    }

    private void RaycastFromScreenPosition(Vector2 pos) {
        Ray ray = Camera.main.ScreenPointToRay(pos);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 20)) {
            Touchable touchable = hit.collider.GetComponentInChildren<Touchable>();
            if (touchable != null) {
                touchable.OnTouchDown();
            }
        }
    }
}
