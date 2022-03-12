using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Detector : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player_tag"))
        {
            animator.SetBool("isBlinking", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player_tag"))
        {
            animator.SetBool("isBlinking", false);
        }
    }
}
