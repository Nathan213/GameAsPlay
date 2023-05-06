using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public float speed = 5f;
    private Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myAnimator.SetTrigger("Hello");
            myAnimator.Play("Aerial Evade");
        }
        if (Input.GetKey(KeyCode.W)) {
             transform.Translate(Vector3.forward * speed * Time.deltaTime);
            myAnimator.SetTrigger("Run");
            myAnimator.Play("Run");
        
    }
     if (Input.GetKeyUp(KeyCode.W))
        {
           myAnimator.ResetTrigger("Run");
           myAnimator.Play("Idle");
        }

        if (Input.GetKey(KeyCode.A)) {
         myAnimator.ResetTrigger("Run");
            myAnimator.SetTrigger("Left");
            myAnimator.Play("Left");
        
    }
     if (Input.GetKeyUp(KeyCode.A))
        {
           myAnimator.ResetTrigger("Left");
           myAnimator.Play("Idle");
        }

        if (Input.GetKey(KeyCode.D)) {
         myAnimator.ResetTrigger("Run");
            myAnimator.SetTrigger("Right");
            myAnimator.Play("Right");
        
    }
     if (Input.GetKeyUp(KeyCode.D))
        {
           myAnimator.ResetTrigger("Right");
           myAnimator.Play("Idle");
        }
      if (Input.GetKeyDown(KeyCode.Space))
        {
         myAnimator.ResetTrigger("Run");
         myAnimator.SetTrigger("Jump");
            myAnimator.Play("Jump");
        }
}
}