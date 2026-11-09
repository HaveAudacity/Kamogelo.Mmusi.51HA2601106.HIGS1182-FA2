using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;   // Cached once so we don't call GetComponent every frame

    void Awake()
    {
        animator = GetComponent<Animator>();

        // Safety check: warns us clearly if the Animator is missing instead of crashing later
        if (animator == null)
        {
            Debug.LogError("AnimationController: no Animator found on " + gameObject.name);
        }
    }

    // Switches between the idle and moving animations
    public void SetMoving(bool isMoving)
    {
        animator.SetBool("isMoving", isMoving);
    }

    // Plays the shoot animation once
    public void TriggerShoot()
    {
        animator.SetTrigger("Shoot");
        Debug.Log("Ship shoot animation triggered");
    }

    // Plays the hit/death animation once
    public void TriggerDie()
    {
        animator.SetTrigger("Die");
        Debug.Log("Ship death animation triggered");
    }
}