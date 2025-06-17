using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;
    private Vector2 moveInput;

    [Header("References")]
    private Rigidbody2D rb;
    private Camera mainCamera;

    [Header("Look")]
    private Vector2 mousePosition;

    private PlayerInput inputActions;

    void Awake()
    {
        inputActions = new PlayerInput();
    }

    void OnEnable()
    {
        inputActions.Enable();
        inputActions.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        inputActions.Player.Move.canceled += _ => moveInput = Vector2.zero;
        inputActions.Player.Look.performed += ctx => mousePosition = ctx.ReadValue<Vector2>();
    }

    void OnDisable()
    {
        inputActions.Disable();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;

        Vector2 worldMousePos = mainCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 lookDir = worldMousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
