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

    // °¡Â÷ ·ÎÁ÷
    int count;
    int currentGacha = 1; // ÇöÀç ¼±ÅÃµÈ °¡Â÷ Å¸ÀÔ (1, 2, 3 µî), ±âº»°ª 1

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
            gachaLogText.text = "»Ì±â ±â·ÏÀÌ ¿©±â¿¡ Ç¥½ÃµË´Ï´Ù.\n";
        }
        count = 0; // ÃÊ±âÈ­   
    }

    public void selectGacha(int type)
    {
        currentGacha = type;
        Debug.Log($"ÇöÀç ¼±ÅÃµÈ °¡Â÷ Å¸ÀÔ: {currentGacha}");
    }

    public void GachaButton()
    {
        Debug.Log($"--- {currentGacha} Type »Ì±â 10È¸ ½ÃÀÛ ---");
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
                case 1: // 1¹ø Å¸ÀÔ °¡Â÷

                    if (10 <= count)
                    {
                        //characterName = "special";
                        characterSprite = image1_6;
                        Debug.Log("10È¸ º¸»ó¿¡ ´çÃ·µÆ´Ù!");
                        count = 0;

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#EA0000>¡Ú 10È¸ »Ì±â º¸³Ê½º ´çÃ·! ¡Ú</color>\n";
                        }
                    }

                    else if (randomValue <= 1)
                    {
                        //characterName = "1%";
                        characterSprite = image1_1;
                        Debug.Log("1%¿¡ ´çÃ·µÆ´Ù!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#FFC000> 1%¿¡ ´çÃ· µÆ´Ù! </color>\n";
                        }
                    }

                    else if (randomValue <= 5)
                    {
                        //characterName = "4%";
                        characterSprite = image1_2;
                        Debug.Log("4%¿¡ ´çÃ·µÆ´Ù!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#5601FF> 4%¿¡ ´çÃ· µÆ´Ù! </color>\n";
                        }
                    }

                    else if (randomValue <= 15)
                    {
                        //characterName = "10%";
                        characterSprite = image1_3;
                        Debug.Log("10%¿¡ ´çÃ·µÆ´Ù!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#FA0686> 10%¿¡ ´çÃ· µÆ´Ù! </color>\n";
                        }
                    }

                    else if (randomValue <= 30)
                    {
                        //characterName = "15%";
                        characterSprite = image1_4;
                        Debug.Log("15%¿¡ ´çÃ·µÆ´Ù!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#4ABC44> 15%¿¡ ´çÃ· µÆ´Ù! </color>\n";
                        }
                    }

                    else
                    {
                        //characterName = "²Î";
                        characterSprite = image1_5;
                        Debug.Log("²Î!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#808080> ²Î! </color>\n";
                        }
                    }
                    break;

                case 2:
                    {
                    if (10 <= count)
                    {
                        //characterName = "special";
                        characterSprite = image2_6;
                        Debug.Log("10È¸ º¸»ó¿¡ ´çÃ·µÆ´Ù!");
                        count = 0;

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#EA0000>¡Ú 10È¸ »Ì±â º¸³Ê½º ´çÃ·! ¡Ú</color>\n";
                        }
                    }

                    else if (randomValue <= 1)
                    {
                        //characterName = "1%";
                        characterSprite = image2_1;
                        Debug.Log("1%¿¡ ´çÃ·µÆ´Ù!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#FFC000> 1%¿¡ ´çÃ· µÆ´Ù! </color>\n";
                        }
                    }

                    else if (randomValue <= 5)
                    {
                        //characterName = "4%";
                        characterSprite = image2_2;
                        Debug.Log("4%¿¡ ´çÃ·µÆ´Ù!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#5601FF> 4%¿¡ ´çÃ· µÆ´Ù! </color>\n";
                        }
                    }

                    else if (randomValue <= 15)
                    {
                        //characterName = "10%";
                        characterSprite = image2_3;
                        Debug.Log("10%¿¡ ´çÃ·µÆ´Ù!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#FA0686> 10%¿¡ ´çÃ· µÆ´Ù! </color>\n";
                        }
                    }

                    else if (randomValue <= 30)
                    {
                        //characterName = "15%";
                        characterSprite = image2_4;
                        Debug.Log("15%¿¡ ´çÃ·µÆ´Ù!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#4ABC44> 15%¿¡ ´çÃ· µÆ´Ù! </color>\n";
                        }
                    }

                    else
                    {
                        //characterName = "²Î";
                        characterSprite = image2_5;
                        Debug.Log("²Î!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#808080> ²Î! </color>\n";
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
                        Debug.Log("10È¸ º¸»ó¿¡ ´çÃ·µÆ´Ù!");
                        count = 0;

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#EA0000>¡Ú 10È¸ »Ì±â º¸³Ê½º ´çÃ·! ¡Ú</color>\n";
                        }
                    }

                    else if (randomValue <= 1)
                    {
                        //characterName = "1%";
                        characterSprite = image3_1;
                        Debug.Log("1%¿¡ ´çÃ·µÆ´Ù!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#FFC000> 1%¿¡ ´çÃ· µÆ´Ù! </color>\n";
                        }
                    }

                    else if (randomValue <= 5)
                    {
                        //characterName = "4%";
                        characterSprite = image3_2;
                        Debug.Log("4%¿¡ ´çÃ·µÆ´Ù!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#5601FF> 4%¿¡ ´çÃ· µÆ´Ù! </color>\n";
                        }
                    }

                    else if (randomValue <= 15)
                    {
                        //characterName = "10%";
                        characterSprite = image3_3;
                        Debug.Log("10%¿¡ ´çÃ·µÆ´Ù!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#FA0686> 10%¿¡ ´çÃ· µÆ´Ù! </color>\n";
                        }
                    }

                    else if (randomValue <= 30)
                    {
                        //characterName = "15%";
                        characterSprite = image3_4;
                        Debug.Log("15%¿¡ ´çÃ·µÆ´Ù!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#4ABC44> 15%¿¡ ´çÃ· µÆ´Ù! </color>\n";
                        }
                    }

                    else
                    {
                        //characterName = "²Î";
                        characterSprite = image3_5;
                        Debug.Log("²Î!");

                        if (gachaLogText != null)
                        {
                            gachaLogText.text += "<color=#808080> ²Î! </color>\n";
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
            Debug.Log("ÀÌ¹ÌÁö ¾øÀ½");
        }
        Debug.Log($"--- {currentGacha} Type »Ì±â Á¾·á ---");
        gachaNumber++;
        }
    }
}
