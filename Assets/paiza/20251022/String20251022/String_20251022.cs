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
