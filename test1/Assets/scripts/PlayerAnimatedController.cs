using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatedController : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce = 200f;
    public bool ground;
    public float rotationSpeed = 10f;

    private float animationSpeed;

    public Rigidbody rb;
    public Animator animator;
    private void GetInput()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");


    }
    // Update is called once per frame
    void Update()
    {
        animationSpeed = 0f;
        GetInput();
        animator.SetFloat("speed", animationSpeed);
    }

}
