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

    // ������ 1
    public void Phase1()
    {
        // 1. string.Empty
        // string ������ ���� �ʱ�ȭ �մϴ�.
        star = string.Empty;

        // 2. ��, ��ĭ, �ٹٲ� �߰��ϱ�
        // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
        star += "��"; // ��
        star += "��"; // ��ĭ
        star += "\n"; // �ٹٲ�

        for (int i = 0; i < 5; i++)
        {
            for(int j = 0; j < i + 1; j++)
            {

            }
        }
        

        // 3. Debug.Log("");
        // Debug.Log�� ����Ͽ� �ܼ�â�� ����մϴ�
        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        // ������ 2


        Debug.Log(star);
    }

    public void Phase3()
    {
        star = string.Empty;

        // ������ 3


        Debug.Log(star);
    }

    public void Phase4()
    {
        star = string.Empty;

        // ������ 4


        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        // ������ 5


        Debug.Log(star);
    }
}
