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

    //star += "��"; // ��
    //star += "��"; // ��ĭ
    //star += "\n"; // �ٹٲ�

    // ������ 1
    public void Phase1()
    {
        star = string.Empty;


        for (int i = 1; i < 6; i++) // �ٱ��� for���� ���ο��� ���� �ǹ�
        {
            for (int j = 0; j < i; j++) // ���� for���� �������� ������ �ǹ�
                // j(��)�� 0���� �����ؼ� i�� ������ ����(j < 1) �߰��ȴ�.
            {
                star += "��"; // ���� �Ѱ��� �߰��ϰڴ�.
            }
            star += "\n"; // �������� ������ �ٹٲ��� �ϰڴ�.
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
                star += "��";
            }

            for (int k = 0; k < 5 - i; k++) 
            {
                star += "��";
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
                star += "��";
            }

            for (int k = 0; k < 6 - i; k++) 
            {
                star += "��";
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
                star += "��";
            }
            star += "\n";
        }

        for (int i = 4; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                star += "��";
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
                star += "��";
            }

            for (int k = 0; k < 6 - i; k++) 
            {
                star += "��";
            }

            star += "\n";
        }

        for (int i = 1; i < 5; i++) 
        {
            for (int j = 0; j < i; j++) 
            {
                star += "��";
            }

            for (int k = 0; k < 5 - i; k++) 
            {
                star += "��";
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
                star += "��";
            }

            for (int k = 0; k < (2 * i) - 1; k++)
            {
                star += "��";
            }

            star += "\n";
        }

        for (int i = 4; i >= 1; i--)
        {
            for (int j = 5; j > i; j--) 
            {
                star += "��";
            }

            for (int k = 0; k < (2 * i) - 1; k++) 
            {
                star += "��";
            }

            star += "\n";
        }


        Debug.Log(star);
    }
}
