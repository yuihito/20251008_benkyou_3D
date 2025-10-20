using Unity.VisualScripting;
using UnityEngine;

public class AkaraBni_3s : MonoBehaviour
{
    [Header("�_A")]
    [Tooltip("�����ɓ_A�ɂ������������")]
    [SerializeField]
    Transform pointA;

    [Header("�_B")]
    [Tooltip("�����ɓ_B�ɂ������������")]
    [SerializeField]
    Transform pointB;

    [Header("�ړ�����")]
    [Tooltip("����͈ړ�����̂ɂ����鎞�Ԃł���")]
    [SerializeField]
    float LerpTime = 3f;

    private float CurrentLeepTime;  //�o�ߎ��Ԃ̋L�^
    private bool isLerping;         //�ړ������ǂ���

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isLerping = true;       //�X�C�b�`��ON
            CurrentLeepTime = 0;    //�o�ߎ��Ԃ̃��Z�b�g
        }

        if (isLerping)
        {
            CurrentLeepTime += Time.deltaTime;        //�o�ߎ��Ԃ𑝂₷

            //�w�莞�Ԃ������瓞��
            if (CurrentLeepTime >= LerpTime)
            {
                CurrentLeepTime = LerpTime;            //�o�ߎ��Ԃ�stopper
                isLerping = false;                     //�X�C�b�`��OFF
            }

            float perc = CurrentLeepTime / LerpTime;   //�i�s��

            //�_A�Ɠ_B�̊Ԃ��ԁ@perc�̈ʒu�Ɉړ�
            transform.position = Vector3.Lerp(pointA.position, pointB.position, perc);
        }

    }
}
