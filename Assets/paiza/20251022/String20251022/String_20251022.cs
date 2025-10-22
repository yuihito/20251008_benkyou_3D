using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class String_20251022 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Console.readLine()‚±‚¢‚Â‚É—á‚¦‚Î‚S‚V‚Æ“ü‚ê‚é‚Æh‚S‚Vh‚Æ‚¢‚¤•¶š—ñ‚ğó‚¯æ‚é‚±‚Æ‚ª‚Å‚«‚éI
        //‚±‚Ì“_‚Å‚Í‚½‚¾‚Ì•¶š—ñ”š‚Å‚Í‚È‚¢
        //‚±‚¤‚È‚é‚ÆSplit(' ')‚Å‹ó”’‚Å•ª‚¯‚Ä‚­‚ê‚éinput[0] 4  input[1] 7 ‚Æ‚¢‚¤•—‚É
        //string[] input = ‚±‚ê‚Í”z—ñ‚µ‚Ä•Û‘¶‚·‚é‚S‚Æ‚V‚Æ‚¢‚¤•¶š‚ª“ü‚é” ‚ğ—pˆÓ‚µ‚Ä‚­‚ê‚é
        string[] input = Console.ReadLine().Split(' ');

        //TextA‚Í‰½‚Å‚à‚È‚¢“ü‚ê‚é‚â‚Â‚»‚±‚É•¶š‚ğ“ü‚ê‚éB
        //‚¢‚ê‚½•¶š‚ğ”š‚É•Ï‚¦‚é
        //”š‚ğ“ü‚ê‚é
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
