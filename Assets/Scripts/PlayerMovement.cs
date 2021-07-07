using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour {

    //Script to handle player movement

    private Rigidbody rb;

    public float moveSpeed = 1;
    public float maxSpeed = 1;

    private Vector2 curMoveDir = new Vector2();

    private void Awake() {
        rb = GetComponent<Rigidbody>();
        if (rb == null) {
            Debug.LogError("Rigidbody not found");
        }
    }

    public void SetCurMoveDir(Vector2 dir) {
        curMoveDir = dir;
    }

    private void FixedUpdate() {
        if (rb == null) {
            return;
        }
        float forceMultiplier = Mathf.Sqrt((rb.velocity.x * rb.velocity.x) + (rb.velocity.z * rb.velocity.z)) / maxSpeed;
        forceMultiplier = 1 - (forceMultiplier * forceMultiplier);
        rb.AddForce(new Vector3(curMoveDir.x, 0, curMoveDir.y) * moveSpeed * Time.fixedDeltaTime * 1000 * forceMultiplier);
    }
}
