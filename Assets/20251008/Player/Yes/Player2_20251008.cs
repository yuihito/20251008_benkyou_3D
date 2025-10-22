using UnityEngine;

public class Player2_20251008 : MonoBehaviour
{
    [SerializeField] float speed = 1;//[SerializeField]これはパブリックではないプライベートに分類しかしunityに表記される
    private Vector3 startPos;//Playerの初期位置の保存
    private Vector3 movement;//箱
    private Transform myTransform;//Transformを先に取得

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
        //移動
        movement.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        movement.y = 0;
        movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //信仰方向正面化
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (direction.sqrMagnitude > 0.001f)
        {
            myTransform.rotation = Quaternion.LookRotation(direction, Vector3.up);
        }


        myTransform.Translate(movement, Space.World);

        //floatなし
        /*
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),　0,　Input.GetAxis("Vertical")) * speed * Time.deltaTime;

        transform.Translate(movement, Space.World);*/


        //floatを使ったやつ
        /* //左右キー
         float horizontalInput = Input.GetAxis("Horizontal");
         //上下キー
         float verticalInput = Input.GetAxis("Vertical");
         //移動量の計算
         Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime;
         //位置を変更
         transform.position += movement;*/


    }
}
