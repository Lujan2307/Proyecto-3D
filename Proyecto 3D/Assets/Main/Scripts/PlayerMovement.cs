using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerController playercontroller;
    [SerializeField] private float velocity = 5f;
    [SerializeField] private Rigidbody rb;


    void FixedUpdate()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        Vector2 PlayerInputs = playercontroller.MoveValue;
        Vector3 playerDirection = new Vector3(PlayerInputs.x, 0f, PlayerInputs.y);

        rb.linearVelocity = playerDirection * velocity;
        Debug.Log("MOVER");
        Debug.Log("DIRECCION: " + playerDirection);
        Debug.Log("VELOCIDAD : " + velocity);

    }

    private void Rotate()
    {
        Vector2 playerInputs = playercontroller.MoveValue;

        if (playerInputs.sqrMagnitude <= 0.01f)
        {
            return;
        }

        Vector3 direction = new Vector3(
            playerInputs.x,
            0f,
            playerInputs.y
            );

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        rb.rotation = targetRotation;
    }
}