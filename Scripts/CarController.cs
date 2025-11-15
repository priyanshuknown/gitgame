using UnityEngine;

public class CarController : MonoBehaviour
{
    public float acceleration = 5f;
    public float steering = 2f;
    public float maxSpeed = 20f;
    private float currentSpeed = 0f;

    private Camera mainCamera;
    private bool isReverse = false;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        // Accelerate and brake
        if (Input.GetKey(KeyCode.W))
        {
            currentSpeed += acceleration * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            currentSpeed -= acceleration * Time.deltaTime;
        }

        // Clamp max speed
        currentSpeed = Mathf.Clamp(currentSpeed, -maxSpeed, maxSpeed);

        // Steering
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -steering, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, steering, 0);
        }

        // Move the car
        transform.Translate(0, 0, currentSpeed * Time.deltaTime);

        // Switch camera (this is a simple toggle)
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
    }

    private void SwitchCamera()
    {
        if (mainCamera != null)
        {
            // Here we can add logic to switch cameras or simply toggle visibility
            mainCamera.gameObject.SetActive(!mainCamera.gameObject.activeSelf);
        }
    }
}