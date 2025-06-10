using System.Collections;
using System.Collections.Generic;
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
    }

    // 페이즈 1
    public void Phase1()
    {
        // 1. string.Empty
        // string 변수의 값을 초기화 합니다.
        star = string.Empty;

        // 2. 별, 빈칸, 줄바꿈 추가하기
        // Debug.Log를 사용하여 콘솔창에 출력합니다
        star += "★"; // 별
        star += "　"; // 빈칸
        star += "\n"; // 줄바꿈

        for (int i = 0; i < 5; i++)
        {
            for(int j = 0; j < i + 1; j++)
            {

            }
        }
        

        // 3. Debug.Log("");
        // Debug.Log를 사용하여 콘솔창에 출력합니다
        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // 페이즈 2


        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // 페이즈 3


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // 페이즈 4


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // 페이즈 5


        Debug.Log(star);
    }
}
