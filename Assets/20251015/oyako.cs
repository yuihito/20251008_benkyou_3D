using UnityEngine;
using UnityEngine.UI;

public class oyako : MonoBehaviour
{
    
    //�΂炵�����&Header���g������������̂ق����D����Ă�
    [Header("�e")]
    [Tooltip("�����ɐe�ɂ������������")]
    [SerializeField]
    Transform parent = null;

    [Header("�q")]
    [Tooltip("�����Ɏq�ɂ������������")]
    [SerializeField]
    Transform child = null;

    private bool ParentAndChild = true;

    /*
    //Label���g���������֗��c�[����LabelAttribute�����邱�Ƃɂ���Ďg����@�Ⴂ�͈�s�ɂȂ�inspector��
    [Label("�e")]
    [SerializeField]
    Transform parent = null;

    [Label("�q")]
    [SerializeField]
    Transform child = null;
    */

    /*
    //Header���g���������܂Ƃ܂�����@Header���o�������Ɋm�F�ł���
    [SerializeField, Header("�e")]
    Transform parent = null;

    [SerializeField, Header("�q")]
    Transform child = null;
    */

    /*
    //Tooltip���g���������܂Ƃ܂�����@Tooltip�̓J�[�\�������킹�Ȃ��ƌ����Ȃ�
    //�e
    [SerializeField, Tooltip("�e")]
    Transform parent = null;
    //�q
    [SerializeField, Tooltip("�q")]
    Transform child = null;
    */
    void Start()
    {
        //�ŏ��e�q
        if (parent != null && child != null )
        {
            child.SetParent(parent);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            SwitchParentAndChild();
        }
    }

    void SwitchParentAndChild()
    {
        if (child == null)
        {
            return;
        }
        if (ParentAndChild)
        {
            child.SetParent(null);
            ParentAndChild = false;

        }
        

    }

}