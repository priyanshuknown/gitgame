using UnityEngine;

namespace YourGameNamespace
{
    public class PlayerController : MonoBehaviour
    {
        public float movementSpeed = 5f;      // Speed of movement
        public float jumpHeight = 2f;         // Height of the jump
        public float gravity = -9.81f;        // Gravity value
        private Vector3 velocity;              // Current velocity
        private bool isGrounded;               // Is player grounded
        private CharacterController controller; // Character controller component
        private Animator animator;              // Animator component

        void Start()
        {
            controller = GetComponent<CharacterController>();
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            // Check if player is grounded
            isGrounded = controller.isGrounded;

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = 0f; // Reset vertical velocity when grounded
            }

            // Handle movement input
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");
            Vector3 move = transform.right * moveX + transform.forward * moveZ;
            controller.Move(move * movementSpeed * Time.deltaTime);

            // Trigger the movement animation
            animator.SetFloat("Speed", move.magnitude);

            // Handle jumping
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                velocity.y += Mathf.Sqrt(jumpHeight * -2f * gravity);
                animator.SetTrigger("Jump");
            }

            // Apply gravity
            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
        }
    }
}