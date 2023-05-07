using UnityEngine;

public partial class Movement : MonoBehaviour
{
    [SerializeField]
    private float rotationalSpeed;

    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private float jumpForce = 5f;

    [SerializeField]
    private LayerMask groundLayer;

    [SerializeField]
    private float groundCheckDistance = 0.2f;
    private Camera cam;
    private float mouseX;
    private float mouseY;
    private float vertical;
    private float horizontal;
    private bool jump;
    private bool isFirstPerson;
    private Animator anim;
    private Rigidbody rb;
    private bool grounded;
    private float cameraRotationSpeed = 2f;


    private readonly int speedHash = Animator.StringToHash("Speed");
    private readonly int jumpHash = Animator.StringToHash("Jump");

    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
       
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        jump = Input.GetButtonDown("Jump");
        mouseX = Input.GetAxis("Mouse X") * cameraRotationSpeed;
        mouseY = Input.GetAxis("Mouse Y") * cameraRotationSpeed;
        if (jump && grounded && !anim.GetCurrentAnimatorStateInfo(0).IsName("BaseLayer.Jump"))
        {
            anim.SetTrigger(jumpHash);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        transform.Rotate(0,mouseX,0);

    }

    private void FixedUpdate()
    {
        grounded = IsGrounded();
        anim.SetFloat(speedHash, vertical);

        var trans = transform;
        rb.MovePosition(trans.position + vertical * moveSpeed * Time.fixedDeltaTime * trans.forward);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0f, horizontal * rotationalSpeed, 0f)));
    }
    
    private bool IsGrounded()
    {
        RaycastHit hit;
        float distance = GetComponent<Collider>().bounds.extents.y + groundCheckDistance;
        Vector3 dir = new Vector3(0, -1);

        if (Physics.Raycast(transform.position, dir, out hit, distance, groundLayer))
        {
            return true;
        }
        return false;
    }
}