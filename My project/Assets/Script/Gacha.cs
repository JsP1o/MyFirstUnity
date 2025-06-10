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

    // ���� ����
    int count;
    int currentGacha = 1; // ���� ���õ� ���� Ÿ�� (1, 2, 3 ��), �⺻�� 1

    [Header("Gacha Images1")]
    [SerializeField] Sprite image1_1;
    [SerializeField] Sprite image1_2;
    [SerializeField] Sprite image1_3;
    [SerializeField] Sprite image1_4;
    [SerializeField] Sprite image1_5;
    [SerializeField] Sprite image1_6;

    [Header("Gacha Images2")]
    [SerializeField] Sprite image2_1;
    [SerializeField] Sprite image2_2;
    [SerializeField] Sprite image2_3;
    [SerializeField] Sprite image2_4;
    [SerializeField] Sprite image2_5;
    [SerializeField] Sprite image2_6;

    [Header("Gacha Images3")]
    [SerializeField] Sprite image3_1;
    [SerializeField] Sprite image3_2;
    [SerializeField] Sprite image3_3;
    [SerializeField] Sprite image3_4;
    [SerializeField] Sprite image3_5;
    [SerializeField] Sprite image3_6;

    private void Awake()
    {

        if (gachaLogText != null)
        {
            gachaLogText.text = "�̱� ����� ���⿡ ǥ�õ˴ϴ�.\n";
        }
        count = 0; // �ʱ�ȭ   
    }

    public void selectGacha(int type)
    {
        currentGacha = type;
        Debug.Log($"���� ���õ� ���� Ÿ��: {currentGacha}");
    }

    public void GachaButton()
    {
        Debug.Log($"--- {currentGacha} Type �̱� 10ȸ ���� ---");
        if (gachaLogText != null)
        {
            gachaLogText.text = "";
        }

        int gachaNumber = 0;
        while (gachaNumber < 10)
        {
            int randomValue = Random.Range(1, 101);
            count++;

            //string characterName = "";
            Sprite characterSprite = null;

            switch (currentGacha)
            {
                case 1: // 1�� Ÿ�� ����

                    if (10 <= count)
                    {
                        //characterName = "special";
                        characterSprite = image1_6;
                        Debug.Log("10ȸ ���� ��÷�ƴ�!");
                        count = 0;

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#EA0000>�� 10ȸ �̱� ���ʽ� ��÷! ��</color>\n";
                        }
                    }

                    else if (randomValue <= 1)
                    {
                        //characterName = "1%";
                        characterSprite = image1_1;
                        Debug.Log("1%�� ��÷�ƴ�!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#FFC000> 1%�� ��÷ �ƴ�! </color>\n";
                        }
                    }

                    else if (randomValue <= 5)
                    {
                        //characterName = "4%";
                        characterSprite = image1_2;
                        Debug.Log("4%�� ��÷�ƴ�!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#5601FF> 4%�� ��÷ �ƴ�! </color>\n";
                        }
                    }

                    else if (randomValue <= 15)
                    {
                        //characterName = "10%";
                        characterSprite = image1_3;
                        Debug.Log("10%�� ��÷�ƴ�!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#FA0686> 10%�� ��÷ �ƴ�! </color>\n";
                        }
                    }

                    else if (randomValue <= 30)
                    {
                        //characterName = "15%";
                        characterSprite = image1_4;
                        Debug.Log("15%�� ��÷�ƴ�!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#4ABC44> 15%�� ��÷ �ƴ�! </color>\n";
                        }
                    }

                    else
                    {
                        //characterName = "��";
                        characterSprite = image1_5;
                        Debug.Log("��!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#808080> ��! </color>\n";
                        }
                    }
                    break;

                case 2:
                    {
                    if (10 <= count)
                    {
                        //characterName = "special";
                        characterSprite = image2_6;
                        Debug.Log("10ȸ ���� ��÷�ƴ�!");
                        count = 0;

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#EA0000>�� 10ȸ �̱� ���ʽ� ��÷! ��</color>\n";
                        }
                    }

                    else if (randomValue <= 1)
                    {
                        //characterName = "1%";
                        characterSprite = image2_1;
                        Debug.Log("1%�� ��÷�ƴ�!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#FFC000> 1%�� ��÷ �ƴ�! </color>\n";
                        }
                    }

                    else if (randomValue <= 5)
                    {
                        //characterName = "4%";
                        characterSprite = image2_2;
                        Debug.Log("4%�� ��÷�ƴ�!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#5601FF> 4%�� ��÷ �ƴ�! </color>\n";
                        }
                    }

                    else if (randomValue <= 15)
                    {
                        //characterName = "10%";
                        characterSprite = image2_3;
                        Debug.Log("10%�� ��÷�ƴ�!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#FA0686> 10%�� ��÷ �ƴ�! </color>\n";
                        }
                    }

                    else if (randomValue <= 30)
                    {
                        //characterName = "15%";
                        characterSprite = image2_4;
                        Debug.Log("15%�� ��÷�ƴ�!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#4ABC44> 15%�� ��÷ �ƴ�! </color>\n";
                        }
                    }

                    else
                    {
                        //characterName = "��";
                        characterSprite = image2_5;
                        Debug.Log("��!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#808080> ��! </color>\n";
                        }
                    }
                    break;
                }

                case 3:
                    {
                    if (10 <= count)
                    {
                        //characterName = "special";
                        characterSprite = image3_6;
                        Debug.Log("10ȸ ���� ��÷�ƴ�!");
                        count = 0;

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#EA0000>�� 10ȸ �̱� ���ʽ� ��÷! ��</color>\n";
                        }
                    }

                    else if (randomValue <= 1)
                    {
                        //characterName = "1%";
                        characterSprite = image3_1;
                        Debug.Log("1%�� ��÷�ƴ�!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#FFC000> 1%�� ��÷ �ƴ�! </color>\n";
                        }
                    }

                    else if (randomValue <= 5)
                    {
                        //characterName = "4%";
                        characterSprite = image3_2;
                        Debug.Log("4%�� ��÷�ƴ�!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#5601FF> 4%�� ��÷ �ƴ�! </color>\n";
                        }
                    }

                    else if (randomValue <= 15)
                    {
                        //characterName = "10%";
                        characterSprite = image3_3;
                        Debug.Log("10%�� ��÷�ƴ�!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#FA0686> 10%�� ��÷ �ƴ�! </color>\n";
                        }
                    }

                    else if (randomValue <= 30)
                    {
                        //characterName = "15%";
                        characterSprite = image3_4;
                        Debug.Log("15%�� ��÷�ƴ�!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#4ABC44> 15%�� ��÷ �ƴ�! </color>\n";
                        }
                    }

                    else
                    {
                        //characterName = "��";
                        characterSprite = image3_5;
                        Debug.Log("��!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#808080> ��! </color>\n";
                        }
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
            Debug.Log("�̹��� ����");
        }
        Debug.Log($"--- {currentGacha} Type �̱� ���� ---");
        gachaNumber++;
        }
    }
}
