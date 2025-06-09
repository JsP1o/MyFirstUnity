using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.ComponentModel.Design;
using UnityEngine.UI;

public class Gacha : MonoBehaviour
{
    [Header("UI Reference")]
    [SerializeField] Image[] gachaImageSlot;
    [SerializeField] TextMeshProUGUI gachaLogText;
    // public TextMeshProUGUI Txt_Gacha;

    // 가차 로직
    int count;
    int currentGacha = 1; // 현재 선택된 가차 타입 (1, 2, 3 등), 기본값 1

    [Header("Gacha Images1")]
    [SerializeField] Sprite image1_1;
    [SerializeField] Sprite image1_2;
    [SerializeField] Sprite image1_3;
    [SerializeField] Sprite image1_4;
    [SerializeField] Sprite image1_5;

    [Header("Gacha Images2")]
    [SerializeField] Sprite image2_1;
    [SerializeField] Sprite image2_2;
    [SerializeField] Sprite image2_3;
    [SerializeField] Sprite image2_4;
    [SerializeField] Sprite image2_5;

    [Header("Gacha Images3")]
    [SerializeField] Sprite image3_1;
    [SerializeField] Sprite image3_2;
    [SerializeField] Sprite image3_3;
    [SerializeField] Sprite image3_4;
    [SerializeField] Sprite image3_5;

    private void Awake()
    {

        if (gachaLogText != null)
        {
            gachaLogText.text = "가차 기록이 여기에 표시됩니다.\n";
        }
        count = 0; // 초기화   
    }

    public void selectGacha(int type)
    {
        currentGacha = type;
        Debug.Log($"현재 선택된 가차 타입: {currentGacha}");
    }

    public void GachaButton()
    {
        Debug.Log($"--- {currentGacha} Type 가차 10회 시작 ---");
        if (gachaLogText != null)
        {
            gachaLogText.text = "";
        }

        int gachaNumber = 0;
        while (gachaNumber < 10)
        {
            int randomValue = Random.Range(1, 101);
            count++;

            string chracterName = "";
            Sprite characterSprite = null;

            switch (currentGacha)
            {
                case 1: // 1번 타입 가차

                    if (10 <= count)
                    {
                        chracterName = "1%";
                        characterSprite = image1_1;
                        Debug.Log("10회 보상에 당첨됐다!");
                        count = 0;
                    }

                    else if (randomValue <= 1)
                    {
                        chracterName = "1%";
                        characterSprite = image1_1;
                        Debug.Log("1%에 당첨됐다!");
                    }

                    else if (randomValue <= 5)
                    {
                        chracterName = "4%";
                        characterSprite = image1_2;
                        Debug.Log("4%에 당첨됐다!");
                    }

                    else if (randomValue <= 15)
                    {
                        chracterName = "10%";
                        characterSprite = image1_3;
                        Debug.Log("10%에 당첨됐다!");
                    }

                    else if (randomValue <= 30)
                    {
                        chracterName = "15%";
                        characterSprite = image1_4;
                        Debug.Log("15%에 당첨됐다!");
                    }

                    else
                    {
                        chracterName = "꽝";
                        characterSprite = image1_5;
                        Debug.Log("꽝!");
                    }
                    break;

                case 2:
                    {
                        if (10 <= count)
                        {
                            chracterName = "1%";
                            characterSprite = image2_1;
                            Debug.Log("10회 보상에 당첨됐다!");
                            count = 0;
                        }

                        else if (randomValue <= 1)
                        {
                            chracterName = "1%";
                            characterSprite = image2_1;
                            Debug.Log("1%에 당첨됐다!");
                        }

                        else if (randomValue <= 5)
                        {
                            chracterName = "4%";
                            characterSprite = image2_2;
                            Debug.Log("4%에 당첨됐다!");
                        }

                        else if (randomValue <= 15)
                        {
                            chracterName = "10%";
                            characterSprite = image2_3;
                            Debug.Log("10%에 당첨됐다!");
                        }

                        else if (randomValue <= 30)
                        {
                            chracterName = "15%";
                            characterSprite = image2_4;
                            Debug.Log("15%에 당첨됐다!");
                        }

                        else
                        {
                            chracterName = "꽝";
                            characterSprite = image2_5;
                            Debug.Log("꽝!");
                        }
                        break;
                    }

                case 3:
                    {
                        if (10 <= count)
                        {
                            chracterName = "1%";
                            characterSprite = image3_1;
                            Debug.Log("10회 보상에 당첨됐다!");
                            count = 0;
                        }

                        else if (randomValue <= 1)
                        {
                            chracterName = "1%";
                            characterSprite = image3_1;
                            Debug.Log("1%에 당첨됐다!");
                        }

                        else if (randomValue <= 5)
                        {
                            chracterName = "4%";
                            characterSprite = image3_2;
                            Debug.Log("4%에 당첨됐다!");
                        }

                        else if (randomValue <= 15)
                        {
                            chracterName = "10%";
                            characterSprite = image3_3;
                            Debug.Log("10%에 당첨됐다!");
                        }

                        else if (randomValue <= 30)
                        {
                            chracterName = "15%";
                            characterSprite = image3_4;
                            Debug.Log("15%에 당첨됐다!");
                        }

                        else
                        {
                            chracterName = "꽝";
                            characterSprite = image3_5;
                            Debug.Log("꽝!");
                        }
                        break;
                    }
            }

        if (gachaImageSlot != null && gachaNumber < gachaImageSlot.Length && gachaImageSlot[gachaNumber] != null)
        {
            gachaImageSlot[gachaNumber].sprite = characterSprite;
        }

        else
        {
            Debug.Log("가차 이미지 슬롯이 비어있거나 인덱스가 범위를 벗어났습니다.");
        }
        Debug.Log($"--- {currentGacha} Type 가차 종료 ---");
        gachaNumber++;

        if (gachaLogText != null)
        {
            gachaLogText.text += $"{chracterName}을(를) 뽑았습니다.\n";
        }
        else
        {
            Debug.Log("가차 기록 텍스트가 할당되지 않았습니다.");
        }

        }
    }
}
