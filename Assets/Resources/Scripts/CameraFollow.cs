using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform player;

    void LateUpdate () 
    {
        transform.position = new Vector3 (player.position.x + 6, 0, -10); // Camera follows the player but 6 to the right
    }
}