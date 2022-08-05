using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputKeyboards : MonoBehaviour
{
    [SerializeField] private PhysicsMovement _movement;
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        _movement.Move(new Vector3(-vertical, 0, horizontal));
    }
}
