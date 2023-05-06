using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject decalPrefab;
    public AudioSource fireSound;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(
                Camera.main.ViewportPointToRay(
                    new Vector3(0.5f, 0.5f, 0)), 
                    out hit))
            {
                GameObject decal = Instantiate(decalPrefab,
                hit.point + hit.normal * 0.01f, Quaternion.FromToRotation(
                    Vector3.forward, -hit.normal));

                if (decal != null && fireSound != null)
                {
                    fireSound.Play();
                }
            }
        }
    }
}