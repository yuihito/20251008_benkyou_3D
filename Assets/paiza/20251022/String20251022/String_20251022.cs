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


        /*
         string s = Console.ReadLine();  // 例えば "10" を入力
        // s の中身は → "10" （数字っぽいけど文字！）

        int n = int.Parse(s);           // "10" → 10（数値に変換！）
        Console.WriteLine(n + 5);       // 15 と表示される

                ！！つまりは文字から数字として使いたいときにだけ使う感じだねParse
        */

        //======一列で送られてくるときの計算のやり方======
        /*       
        string line = Console.ReadLine().Trim();
        //Trim()役割文字列の前後にある余分な空白や改行を取り除く例: " 149 825 262\n " → "149 825 262"

        string[] number = line.Split(' ');
        //lineSplit(' ')役割文字列を空白で区切って配列に変換する例: "149 825 262".Split(' ') → ["149", "825", "262"]
        //string[] number 結果を格納する変数　number[0] → "149"ただの箱

        int A = int.Parse(number[0]);
        int B = int.Parse(number[1]);
        int C = int.Parse(number[2]);

        int N = 0;
        N = N + A;      // NにAを足す
        N = N * B;      // NにBをかける
        N = N % C;      // NをCで割ったあまり

        Console.WriteLine(N);




        //===================== 改行 =======================
        //Console.WriteLine($"{s_1}\n{s_2}");この書き方で改行してくれる writeLineを2回書くのもあり


        /*       // 1行を空白区切りで分ける
         *       一列で届くときのやり方
        string[] input = Console.ReadLine().Split(' ');

        string s_1 = input[0];
        string s_2 = input[1];

        Console.WriteLine(s_1);
        Console.WriteLine(s_2);
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
