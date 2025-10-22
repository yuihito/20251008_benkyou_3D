using UnityEngine;
using UnityEngine.UI;

public class oyako : MonoBehaviour
{
    
    //ばらしたやつ&Headerを使ったやつこっちのほうが好かれてる
    [Header("親")]
    [Tooltip("ここに親にしたいやつを入れる")]
    [SerializeField]
    Transform parent = null;

    [Header("子")]
    [Tooltip("ここに子にしたいやつを入れる")]
    [SerializeField]
    Transform child = null;

    private bool ParentAndChild = true;

    /*
    //Labelを使ったやり方便利ツールのLabelAttributeを入れることによって使える　違いは一行になるinspectorで
    [Label("親")]
    [SerializeField]
    Transform parent = null;

    [Label("子")]
    [SerializeField]
    Transform child = null;
    */

    /*
    //Headerを使ったやり方まとまったやつ　Header見出しすぐに確認できる
    [SerializeField, Header("親")]
    Transform parent = null;

    [SerializeField, Header("子")]
    Transform child = null;
    */

    /*
    //Tooltipを使ったやり方まとまったやつ　Tooltipはカーソルを合わせないと見えない
    //親
    [SerializeField, Tooltip("親")]
    Transform parent = null;
    //子
    [SerializeField, Tooltip("子")]
    Transform child = null;
    */
    void Start()
    {
        //最初親子
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