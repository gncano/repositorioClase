using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    public CharacterController controller;
    [SerializeField] private float velocityY;
    public float jumpHeight = 3f;
    public float gravity = -9.81f;
    int jumpCounter = 0;

    void Update()
    {
        float inputVertical = Input.GetAxis("Vertical");
        float inputHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = transform.right * inputHorizontal + transform.forward * inputVertical;
        movement *= moveSpeed * Time.deltaTime;

        controller.Move(movement);

        Jump();
        Run();
    }

    private void Run()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed *= 2f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed /= 2f;
        }
    }

    private void Jump()
    {
        if (controller.isGrounded)
        {
            jumpCounter = 0;
        }

        if (Input.GetKeyDown(KeyCode.Space) && jumpCounter < 2)
        {
            velocityY = Mathf.Sqrt(jumpHeight * -2f * gravity);
            jumpCounter++;
        }
        velocityY += gravity * Time.deltaTime;

        Vector3 move = new Vector3(0, velocityY, 0);
        controller.Move(move * Time.deltaTime);
    }
}
