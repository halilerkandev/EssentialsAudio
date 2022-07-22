using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    Animator animator;

    private bool isL1 = true;
    private bool isL2 = false;
    private bool isL3 = false;
    private bool isL4 = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {
        animator.SetFloat("Speed", 1);
        animator.Update(1.5f * Time.deltaTime);

        if (animator.targetPosition.x > 6 && isL1)
        {
            transform.position = new Vector3(6, 0, -5);
            transform.Rotate(Vector3.up, -90);
            isL2 = true;
            isL1 = false;
        }

        if(animator.targetPosition.z > 6 && isL2) {
            transform.position = new Vector3(6, 0, 6);
            transform.Rotate(Vector3.up, -90);
            isL3 = true;
            isL2 = false;
        }

        if (animator.targetPosition.x < -6 && isL3)
        {
            transform.position = new Vector3(-6, 0, 6);
            transform.Rotate(Vector3.up, -90);
            isL4 = true;
            isL3 = false;
        }

        if (animator.targetPosition.z < -5 && isL4)
        {
            transform.position = new Vector3(-6, 0, -5);
            transform.Rotate(Vector3.up, -90);
            isL1 = true;
            isL4 = false;
        }

        
    }
}
