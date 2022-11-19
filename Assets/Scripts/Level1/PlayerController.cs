using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;

    public Animator animator;

    void Start()
    {
        animator.SetBool("Aiming", false);
		animator.SetFloat ("Speed", 0f);
    }
}
