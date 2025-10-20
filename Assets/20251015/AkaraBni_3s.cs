using Unity.VisualScripting;
using UnityEngine;

public class AkaraBni_3s : MonoBehaviour
{
    [Header("点A")]
    [Tooltip("ここに点Aにしたいやつを入れる")]
    [SerializeField]
    Transform pointA;

    [Header("点B")]
    [Tooltip("ここに点Bにしたいやつを入れる")]
    [SerializeField]
    Transform pointB;

    [Header("移動時間")]
    [Tooltip("これは移動するのにかかる時間である")]
    [SerializeField]
    float LerpTime = 3f;

    private float CurrentLeepTime;  //経過時間の記録
    private bool isLerping;         //移動中かどうか

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isLerping = true;       //スイッチのON
            CurrentLeepTime = 0;    //経過時間のリセット
        }

        if (isLerping)
        {
            CurrentLeepTime += Time.deltaTime;        //経過時間を増やす

            //指定時間たったら到着
            if (CurrentLeepTime >= LerpTime)
            {
                CurrentLeepTime = LerpTime;            //経過時間のstopper
                isLerping = false;                     //スイッチのOFF
            }

            float perc = CurrentLeepTime / LerpTime;   //進行率

            //点Aと点Bの間を補間　percの位置に移動
            transform.position = Vector3.Lerp(pointA.position, pointB.position, perc);
        }

    }
}
