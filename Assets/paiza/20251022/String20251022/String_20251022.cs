using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String_20251022 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
