using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    int count; // �̱� Ƚ�� ī��Ʈ

    private void Awake()
    {
        count = 0; // �ʱ�ȭ
    }

    void Start()
    {

    }

    public void Gacha()
    {
        int number = 1;
        while (number <= 10)
        {
            int randomValue = Random.Range(1, 101);
            count++; // count�� �����ϴ� �ڸ�
            // Debug.Log($"������ ���� : {randomValue} �Դϴ�.");

            if (10 <= count)
            {
                Debug.Log("'ī��ī'�� �̾Ҵ�!");
                count = 0;
            }

            else if (randomValue <= 1) // 1 ~ 10
            {
                Debug.Log("'��Ŀũ'�� �̾Ҵ�!");
            }

            else if (randomValue <= 5) // 
            {
                Debug.Log("'����ī'�� �̾Ҵ�!");
            }

            else if (randomValue <= 15) // 
            {
                Debug.Log("'��Ʋ��'�� �̾Ҵ�!");
            }

            else if (randomValue <= 30) // 
            {
                Debug.Log("'�Ƿδ�'�� �̾Ҵ�!");
            }

            else
            {
                Debug.Log("���һ�, 'ġġ'�� �̾ƹ��ȴ�!");
            }

            number++;
        }
    }
}

        //for (int i = 0; i < 10; i++)
        //{
        //    int randomValue = Random.Range(1, 101);

        //    Debug.Log($"������ ���� : {randomValue} �Դϴ�.");

        //    if (8 <= count)
        //    {
        //        Debug.Log("'��Ŀũ'�� �̾Ҵ�!");
        //        count = 0;
        //    }

        //    else if (randomValue <= 1) // 1 ~ 10
        //    {
        //        Debug.Log("'��Ŀũ'�� �̾Ҵ�!");
        //    }

        //    else if (randomValue <= 5) // 
        //    {
        //        Debug.Log("'����ī'�� �̾Ҵ�!");
        //    }

        //    else if (randomValue <= 15) // 
        //    {
        //        Debug.Log("'��Ʋ��'�� �̾Ҵ�!");
        //    }

        //    else if (randomValue <= 30) // 
        //    {
        //        Debug.Log("'�Ƿδ�'�� �̾Ҵ�!");
        //    }

        //    else
        //    {
        //        Debug.Log("���һ�, 'ġġ'�� �̾ƹ��ȴ�!");
        //    }



    //public void Gacha()
    //{
    //    int randomValue = Random.Range(1, 101); // 1 �̻� 100 �̸��� ������ ���� �޾� ���ڴ�.

    //    Debug.Log($"������ ���� : {randomValue} �Դϴ�.");

    //    if (8 <= count) // == ���� ���� �� ������ ���, ==�� ��� ���װ� �Ͼ 81�� �Ǿ������ õ�忡 �������� ����
    //    {
    //        Debug.Log("'��Ŀũ'�� �̾Ҵ�!");
    //        count = 0;
    //    }


    //    else if (randomValue <= 1) // 1 ~ 10
    //    {
    //        Debug.Log("'��Ŀũ'�� �̾Ҵ�!");
    //    }

    //    else if (randomValue <= 5) // 
    //    {
    //        Debug.Log("'����ī'�� �̾Ҵ�!");
    //    }

    //    else if (randomValue <= 15) // 
    //    {
    //        Debug.Log("'��Ʋ��'�� �̾Ҵ�!");
    //    }

    //    else if (randomValue <= 30) // 
    //    {
    //        Debug.Log("'�Ƿδ�'�� �̾Ҵ�!");
    //    }

    //    else
    //    {
    //        Debug.Log("���һ�, 'ġġ'�� �̾ƹ��ȴ�!");
    //    }

    //    count++;
    //}

    // Switch ����
    // �̱� �ý��ۿ� Switch�� Ȱ���Ѵٸ�? 
    // ��ʿ� ���� �� ĳ������ Ȯ���� �ٸ��� �ϰ� �ʹٸ�?

    //public int selectNumber = 1;
    //public void GachaSwitch()
    //{
    //    int randomValue = Random.Range(1, 101);
    //    // int selectNumber = 0;

    //    switch (selectNumber)
    //    {
    //        case 0:
    //            if (randomValue <= 10)
    //            {
    //                Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
    //            }

    //            else if (randomValue <= 30)
    //            {
    //                Debug.Log("'�Ķ� �Ӹ�'�� �̾Ҵ�!");
    //            }

    //            else
    //            {
    //                Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
    //            }
    //            break;

    //        case 1:
    //            if (randomValue <= 10)
    //            {
    //                Debug.Log("'ȸ�� �Ӹ�'�� �̾Ҵ�!");
    //            }

    //            else if (randomValue <= 30)
    //            {
    //                Debug.Log("'��� �Ӹ�'�� �̾Ҵ�!");
    //            }

    //            else
    //            {
    //                Debug.Log("'��Ȳ �Ӹ�'�� �̾Ҵ�!");
    //            }
    //            break;

    //        case 2:
    //            if (randomValue <= 10)
    //            {
    //                Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
    //            }

    //            else if (randomValue <= 30)
    //            {
    //                Debug.Log("'��� �Ӹ�'�� �̾Ҵ�!");
    //            }

    //            else
    //            {
    //                Debug.Log("'��� �Ӹ�'�� �̾Ҵ�!");
    //            }
    //            break;

    //        case 3:
    //            if (randomValue <= 10)
    //            {
    //                Debug.Log("'��Ӹ�'�� �̾Ҵ�!");
    //            }

    //            else if (randomValue <= 30)
    //            {
    //                Debug.Log("'���̾�ġ �Ӹ�'�� �̾Ҵ�!");
    //            }

    //            else
    //            {
    //                Debug.Log("'���� �Ӹ�'�� �̾Ҵ�!");
    //            }
    //            break;

    //        default:
    //            break;
    //    }
    //}

