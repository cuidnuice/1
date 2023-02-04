using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAction : MonoBehaviour
{
    public Animator animator;

    public void kick()
    {
        animator.Play("Mma kick");
    }

    public void Running()
    {
        animator.Play("Running");
    }
}
