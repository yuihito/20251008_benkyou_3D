using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String_20251022 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        /*| 型       | たとえ              | 特徴                 
          | -------- | ----------           | ------------------ 
          | `int`    | HPや攻撃力           | 数を使って計算できる         
          | `float`  | 移動速度・ジャンプ力 | 小数も扱える             
          | `string` | 名前・セリフ         | 文字列（"あいうえお"とか）を扱う  
          | `bool`   | 生きてるか死んでるか | 真(true)か偽(false)だけ 
          | `char`   | 一文字               | 例：'A', 'あ'         
          | `var`    | 自動判断             | コンパイラが右辺を見て型を決める   
*/
//varはこれらを自動で分けてくれる var a = 10;など　var b = "こんにちは"；のよな感じに

//varはあくまで書くのがめんどくさいからvarにしてるだけで結果はおんなじだ

//===============書き方！=====================
/*| やりたいこと     | 正しい書き方                                         | 説明    |
| ---------- | ---------------------------------------------- | ----- |
| 文字列として受け取る | `string s = Console.ReadLine();`               | これでOK |
| 整数として受け取る  | `int n = int.Parse(Console.ReadLine());`       | 数字に変換 |
| 小数として受け取る  | `double d = double.Parse(Console.ReadLine());` | 小数に変換 |
*/





//Console.readLine()こいつに例えば４７と入れると”４７”という文字列を受け取ることができる！
//この時点ではただの文字列数字ではない
//こうなるとSplit(' ')で空白で分けてくれるinput[0] 4  input[1] 7 という風に
//string[] input = これは配列して保存する４と７という文字が入る箱を用意してくれる
string[] input = Console.ReadLine().Split(' ');

//TextAは何でもない入れるやつそこに文字を入れる。
//いれた文字を数字に変える
//数字を入れる
string textA = input[0];
int numberA = int.Parse(textA);
int A = numberA;

string textB = input[1];
int numberB = int.Parse(textB);
int B = numberB;

int D = A - B;
int P = A * B;

Console.WriteLine($"{D} {P}");


//=== 値の入出力 ===
//これで入力して出力できる
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n);





}

// Update is called once per frame
void Update()
{

}
}
