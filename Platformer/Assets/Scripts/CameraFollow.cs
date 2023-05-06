using System.Collections;
using System.Collections.Generic;


using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = player.position + offset;
        transform.rotation = Quaternion.Euler(20f, 0f, 0f); // lock rotation to (0,0,0)
    }
}
