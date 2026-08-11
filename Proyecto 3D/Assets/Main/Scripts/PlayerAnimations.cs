using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnimations : MonoBehaviour
{
    [SerializeField] private PlayerController controller;
    [SerializeField] private Animator animator;

    private static readonly int IsRunningParameter
        = Animator.StringToHash("IsRunning");

    void Update()
    {
        updateMovementAnimation();
    }

    private void updateMovementAnimation()
    {
        bool isRunning = controller.MoveValue.sqrMagnitude > 0.01f;

        animator.SetBool(IsRunningParameter, isRunning);
    }

}