using UnityEngine;
using DG.Tweening;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class MovementControl : MonoBehaviour
{
    //movement
    private CharacterController characterController;
    [SerializeField] private float speed;

    //sprint
    private float walkSpeed;
    private float runSpeed = 5f;
    private Camera cam;
    private bool isRunning=false;

    [SerializeField] private Volume volume;
    private ChromaticAberration chromatic;


    //yercekimi
    private float gravity = -9.8f;
    private Vector3 velocity;

    [SerializeField] private Transform groundPosition;
    [SerializeField] private bool isGrounded;
    private float groundDistance = .4f;
    [SerializeField] private LayerMask groundMask;

    void Start()
    {
        walkSpeed = speed;
        cam = Camera.main;
        volume.profile.TryGet(out chromatic);

        characterController = GetComponent<CharacterController>();
    }


    void Update()
    {
        Move();
        Gravity();
        Sprint();
    }
    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = transform.right * horizontal + transform.forward * vertical;
        characterController.Move(direction * speed * Time.deltaTime);
    }
    private void Gravity()
    {
        isGrounded = Physics.CheckSphere(groundPosition.position, groundDistance, groundMask);
        velocity.y += gravity * Time.deltaTime;
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        characterController.Move(velocity * Time.deltaTime);
    }
    private void Sprint()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRunning = true;
            DOTween.To(() => speed, x => speed = x, runSpeed, 3);
            DOTween.To(() => chromatic.intensity.value, x => chromatic.intensity.value = x, 1, 3);
            cam.DOFieldOfView(70, 3);
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isRunning = false;
            DOTween.To(() => speed, x => speed = x, walkSpeed, 3);
            DOTween.To(() => chromatic.intensity.value, x => chromatic.intensity.value = x, 0, 3);
            cam.DOFieldOfView(60, 3);
        }
    }
}
