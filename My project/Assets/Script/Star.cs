using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Star : MonoBehaviour
{
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
        Phase6();
    }

    //star += "★"; // 별
    //star += "　"; // 빈칸
    //star += "\n"; // 줄바꿈

    // 페이즈 1
    public void Phase1()
    {
        star = string.Empty;


        for (int i = 1; i < 6; i++) // 바깥쪽 for문은 세로열의 줄을 의미
        {
            for (int j = 0; j < i; j++) // 안쪽 for문은 가로줄의 개수를 의미
                // j(별)은 0부터 시작해서 i가 끝날때 까지(j < 1) 추가된다.
            {
                star += "★"; // 별을 한개씩 추가하겠다.
            }
            star += "\n"; // 가로줄이 끝나면 줄바꿈을 하겠다.
        }
        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        for (int i = 0; i < 5; i++) 
        {
            for (int j = 0; j < i; j++) 
            {
                star += "　";
            }

            for (int k = 0; k < 5 - i; k++) 
            {
                star += "★";
            }

            star += "\n";
        }

        Debug.Log(star);

    }

    public void Phase3()
    {
        star = string.Empty;

        for (int i = 5; i >= 1; i--) 
        {
            for (int j = 0; j < i; j++) 
            {
                star += "　";
            }

            for (int k = 0; k < 6 - i; k++) 
            {
                star += "★";
            }

            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        for (int i = 1; i < 6; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "★";
            }
            star += "\n";
        }

        for (int i = 4; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                star += "★";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        for (int i = 5; i >= 1; i--) 
        {
            for (int j = 1; j < i; j++) 
            {
                star += "　";
            }

            for (int k = 0; k < 6 - i; k++) 
            {
                star += "★";
            }

            star += "\n";
        }

        for (int i = 1; i < 5; i++) 
        {
            for (int j = 0; j < i; j++) 
            {
                star += "　";
            }

            for (int k = 0; k < 5 - i; k++) 
            {
                star += "★";
            }

            star += "\n";
        }

        Debug.Log(star);
    }

    public void Phase6()
    {
        star = string.Empty;

        for (int i = 1; i < 6; i++) 
        {
            for (int j = 5; j > i; j--) 
            {
                star += "　";
            }

            for (int k = 0; k < (2 * i) - 1; k++)
            {
                star += "★";
            }

            star += "\n";
        }

        for (int i = 4; i >= 1; i--)
        {
            for (int j = 5; j > i; j--) 
            {
                star += "　";
            }

            for (int k = 0; k < (2 * i) - 1; k++) 
            {
                star += "★";
            }

            star += "\n";
        }


        Debug.Log(star);
    }
}
