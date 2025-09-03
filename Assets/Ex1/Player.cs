using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float velocity;
    public float rotationSpeed;

    private InputActions inputActions;
    private Vector2 moveInput;

    private void Awake()
    {
        inputActions = new InputActions();

        // Registrar os callbacks uma vez só
        inputActions.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        inputActions.Player.Move.canceled += ctx => moveInput = Vector2.zero;
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Update()
    {
        // Movimento para frente e para trás
        float moveAmount = moveInput.y * velocity * Time.deltaTime;
        transform.Translate(Vector3.forward * moveAmount);

        // Rotação para esquerda e direita
        float rotationAmount = moveInput.x * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationAmount);

    }
}
