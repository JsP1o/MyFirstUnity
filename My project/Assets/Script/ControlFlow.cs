using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    int count; // 뽑기 횟수 카운트

    private void Awake()
    {
        count = 0; // 초기화
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
            count++; // count가 들어가야하는 자리
            // Debug.Log($"랜덤한 값은 : {randomValue} 입니다.");

            if (10 <= count)
            {
                Debug.Log("'카프카'를 뽑았다!");
                count = 0;
            }

            else if (randomValue <= 1) // 1 ~ 10
            {
                Debug.Log("'스커크'를 뽑았다!");
            }

            else if (randomValue <= 5) // 
            {
                Debug.Log("'마비카'를 뽑았다!");
            }

            else if (randomValue <= 15) // 
            {
                Debug.Log("'시틀라리'를 뽑았다!");
            }

            else if (randomValue <= 30) // 
            {
                Debug.Log("'실로닌'를 뽑았다!");
            }

            else
            {
                Debug.Log("맙소사, '치치'를 뽑아버렸다!");
            }

            number++;
        }
    }
}

        //for (int i = 0; i < 10; i++)
        //{
        //    int randomValue = Random.Range(1, 101);

        //    Debug.Log($"랜덤한 값은 : {randomValue} 입니다.");

        //    if (8 <= count)
        //    {
        //        Debug.Log("'스커크'를 뽑았다!");
        //        count = 0;
        //    }

        //    else if (randomValue <= 1) // 1 ~ 10
        //    {
        //        Debug.Log("'스커크'를 뽑았다!");
        //    }

        //    else if (randomValue <= 5) // 
        //    {
        //        Debug.Log("'마비카'를 뽑았다!");
        //    }

        //    else if (randomValue <= 15) // 
        //    {
        //        Debug.Log("'시틀라리'를 뽑았다!");
        //    }

        //    else if (randomValue <= 30) // 
        //    {
        //        Debug.Log("'실로닌'를 뽑았다!");
        //    }

        //    else
        //    {
        //        Debug.Log("맙소사, '치치'를 뽑아버렸다!");
        //    }



    //public void Gacha()
    //{
    //    int randomValue = Random.Range(1, 101); // 1 이상 100 미만의 랜덤한 값을 받아 오겠다.

    //    Debug.Log($"랜덤한 값은 : {randomValue} 입니다.");

    //    if (8 <= count) // == 보다 조금 더 안전한 방법, ==의 경우 버그가 일어나 81이 되어버리면 천장에 도달하지 못함
    //    {
    //        Debug.Log("'스커크'를 뽑았다!");
    //        count = 0;
    //    }


    //    else if (randomValue <= 1) // 1 ~ 10
    //    {
    //        Debug.Log("'스커크'를 뽑았다!");
    //    }

    //    else if (randomValue <= 5) // 
    //    {
    //        Debug.Log("'마비카'를 뽑았다!");
    //    }

    //    else if (randomValue <= 15) // 
    //    {
    //        Debug.Log("'시틀라리'를 뽑았다!");
    //    }

    //    else if (randomValue <= 30) // 
    //    {
    //        Debug.Log("'실로닌'를 뽑았다!");
    //    }

    //    else
    //    {
    //        Debug.Log("맙소사, '치치'를 뽑아버렸다!");
    //    }

    //    count++;
    //}

    // Switch 예시
    // 뽑기 시스템에 Switch를 활용한다면? 
    // 배너에 따라 각 캐릭터의 확률을 다르게 하고 싶다면?

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
    //                Debug.Log("'은색 머리'를 뽑았다!");
    //            }

    //            else if (randomValue <= 30)
    //            {
    //                Debug.Log("'파란 머리'를 뽑았다!");
    //            }

    //            else
    //            {
    //                Debug.Log("'검은 머리'를 뽑았다!");
    //            }
    //            break;

    //        case 1:
    //            if (randomValue <= 10)
    //            {
    //                Debug.Log("'회색 머리'를 뽑았다!");
    //            }

    //            else if (randomValue <= 30)
    //            {
    //                Debug.Log("'흰색 머리'를 뽑았다!");
    //            }

    //            else
    //            {
    //                Debug.Log("'주황 머리'를 뽑았다!");
    //            }
    //            break;

    //        case 2:
    //            if (randomValue <= 10)
    //            {
    //                Debug.Log("'갈색 머리'를 뽑았다!");
    //            }

    //            else if (randomValue <= 30)
    //            {
    //                Debug.Log("'노란 머리'를 뽑았다!");
    //            }

    //            else
    //            {
    //                Debug.Log("'잿빛 머리'를 뽑았다!");
    //            }
    //            break;

    //        case 3:
    //            if (randomValue <= 10)
    //            {
    //                Debug.Log("'대머리'를 뽑았다!");
    //            }

    //            else if (randomValue <= 30)
    //            {
    //                Debug.Log("'헤이아치 머리'를 뽑았다!");
    //            }

    //            else
    //            {
    //                Debug.Log("'변발 머리'를 뽑았다!");
    //            }
    //            break;

    //        default:
    //            break;
    //    }
    //}

