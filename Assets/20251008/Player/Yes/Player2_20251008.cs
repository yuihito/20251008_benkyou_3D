using UnityEngine;

public class Player2_20251008 : MonoBehaviour
{
    [SerializeField] float speed = 1;//[SerializeField]����̓p�u���b�N�ł͂Ȃ��v���C�x�[�g�ɕ��ނ�����unity�ɕ\�L�����
    private Vector3 startPos;//Player�̏����ʒu�̕ۑ�
    private Vector3 movement;//��
    private Transform myTransform;//Transform���Ɏ擾

    private void Start()
    {
        myTransform = transform;
        startPos = new Vector3(0, 0, 0);
        transform.position = startPos;

        speed = 2f;
    }
    // Update is called once per frame
    void Update()
    {
        //�ړ�
        movement.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        movement.y = 0;
        movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //�M�������ʉ�
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (direction.sqrMagnitude > 0.001f)
        {
            myTransform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }


        myTransform.Translate(movement, Space.World);

        //float�Ȃ�
        /*
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),�@0,�@Input.GetAxis("Vertical")) * speed * Time.deltaTime;

        transform.Translate(movement, Space.World);*/


        //float���g�������
        /* //���E�L�[
         float horizontalInput = Input.GetAxis("Horizontal");
         //�㉺�L�[
         float verticalInput = Input.GetAxis("Vertical");
         //�ړ��ʂ̌v�Z
         Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime;
         //�ʒu��ύX
         transform.position += movement;*/


    }
}
