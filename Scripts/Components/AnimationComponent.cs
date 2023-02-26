using System;
using UnityEngine;

public class AnimationComponent :MonoBehaviour
{
    public InputComponentBase InputComponent;
    [SerializeField] 
    private Animator animator;

    private void Update()
    {
        if (InputComponent.GetInputDirectionNormalized().magnitude > 0f)
        {
            // Using strings is very expensive... use hashes instead
            animator.Play("Walk");
        }
        else
        {
            animator.Play("Idle");
        }
    }
}