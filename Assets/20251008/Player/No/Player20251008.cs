using UnityEngine;

public class Player20251008 : MonoBehaviour
{
    public Rigidbody _rb = null;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) move += Vector3.forward;
        if (Input.GetKey(KeyCode.S)) move += Vector3.back;
        if (Input.GetKey(KeyCode.A)) move += Vector3.left;
        if (Input.GetKey(KeyCode.D)) move += Vector3.right;

        transform.position += move * 0.05f;
    }
}
