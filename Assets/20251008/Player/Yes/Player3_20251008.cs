using UnityEngine;

public class Player3_20251008 : MonoBehaviour
{
    [SerializeField] private float speed = 2f;       // 横移動速度
    [SerializeField] private float jumpForce = 5f;   // ジャンプ力

    private Transform myTransform;    // Transform
    private Rigidbody rb;             // Rigidbody
    private bool isGrounded = false;  // 地面判定

    private void Start()
    {
        myTransform = transform;
        rb = GetComponent<Rigidbody>();

        rb.useGravity = true;
        rb.isKinematic = false;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    private void Update()
    {
        // 横移動（Transformで軽量化）
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 horizontalMove = new Vector3(h, 0, v) * speed * Time.deltaTime;
        myTransform.Translate(horizontalMove, Space.World);

        // 移動方向に正面を向く
        Vector3 direction = new Vector3(h, 0, v);
        if (direction.sqrMagnitude > 0.001f)
        {
            myTransform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }

        // ジャンプ
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    // 地面判定
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
