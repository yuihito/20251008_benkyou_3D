using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String_20251022 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        /*| �^       | ���Ƃ�              | ����                 
          | -------- | ----------           | ------------------ 
          | `int`    | HP��U����           | �����g���Čv�Z�ł���         
          | `float`  | �ړ����x�E�W�����v�� | ������������             
          | `string` | ���O�E�Z���t         | ������i"����������"�Ƃ��j������  
          | `bool`   | �����Ă邩����ł邩 | �^(true)���U(false)���� 
          | `char`   | �ꕶ��               | ��F'A', '��'         
          | `var`    | �������f             | �R���p�C�����E�ӂ����Č^�����߂�   
*/
        //var�͂����������ŕ����Ă���� var a = 10;�Ȃǁ@var b = "����ɂ���"�G�̂�Ȋ�����

        //var�͂����܂ŏ����̂��߂�ǂ���������var�ɂ��Ă邾���Ō��ʂ͂���Ȃ���

        //===============�������I=====================
        /*| ��肽������     | ������������                                         | ����    |
        | ---------- | ---------------------------------------------- | ----- |
        | ������Ƃ��Ď󂯎�� | `string s = Console.ReadLine();`               | �����OK |
        | �����Ƃ��Ď󂯎��  | `int n = int.Parse(Console.ReadLine());`       | �����ɕϊ� |
        | �����Ƃ��Ď󂯎��  | `double d = double.Parse(Console.ReadLine());` | �����ɕϊ� |
        */


        /*
         string s = Console.ReadLine();  // �Ⴆ�� "10" �����
        // s �̒��g�� �� "10" �i�������ۂ����Ǖ����I�j

        int n = int.Parse(s);           // "10" �� 10�i���l�ɕϊ��I�j
        Console.WriteLine(n + 5);       // 15 �ƕ\�������

                �I�I�܂�͕������琔���Ƃ��Ďg�������Ƃ��ɂ����g����������Parse
        */

        //======���ő����Ă���Ƃ��̌v�Z�̂���======
        /*       
        string line = Console.ReadLine().Trim();
        //Trim()����������̑O��ɂ���]���ȋ󔒂���s����菜����: " 149 825 262\n " �� "149 825 262"

        string[] number = line.Split(' ');
        //lineSplit(' ')������������󔒂ŋ�؂��Ĕz��ɕϊ������: "149 825 262".Split(' ') �� ["149", "825", "262"]
        //string[] number ���ʂ��i�[����ϐ��@number[0] �� "149"�����̔�

        int A = int.Parse(number[0]);
        int B = int.Parse(number[1]);
        int C = int.Parse(number[2]);

        int N = 0;
        N = N + A;      // N��A�𑫂�
        N = N * B;      // N��B��������
        N = N % C;      // N��C�Ŋ��������܂�

        Console.WriteLine(N);




        //===================== ���s =======================
        //Console.WriteLine($"{s_1}\n{s_2}");���̏������ŉ��s���Ă���� writeLine��2�񏑂��̂�����


        /*       // 1�s���󔒋�؂�ŕ�����
         *       ���œ͂��Ƃ��̂���
        string[] input = Console.ReadLine().Split(' ');

        string s_1 = input[0];
        string s_2 = input[1];

        Console.WriteLine(s_1);
        Console.WriteLine(s_2);
        */


        //Console.readLine()�����ɗႦ�΂S�V�Ɠ����Ɓh�S�V�h�Ƃ�����������󂯎�邱�Ƃ��ł���I
        //���̎��_�ł͂����̕����񐔎��ł͂Ȃ�
        //�����Ȃ��Split(' ')�ŋ󔒂ŕ����Ă����input[0] 4  input[1] 7 �Ƃ�������
        //string[] input = ����͔z�񂵂ĕۑ�����S�ƂV�Ƃ������������锠��p�ӂ��Ă����
        string[] input = Console.ReadLine().Split(' ');

//TextA�͉��ł��Ȃ�����������ɕ���������B
//���ꂽ�����𐔎��ɕς���
//����������
string textA = input[0];
int numberA = int.Parse(textA);
int A = numberA;

string textB = input[1];
int numberB = int.Parse(textB);
int B = numberB;

int D = A - B;
int P = A * B;

Console.WriteLine($"{D} {P}");


//=== �l�̓��o�� ===
//����œ��͂��ďo�͂ł���
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n);





}

// Update is called once per frame
void Update()
{

}
}
