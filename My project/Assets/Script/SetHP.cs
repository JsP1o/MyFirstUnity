using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.ComponentModel.Design;

public class SetHP : MonoBehaviour
{
    public TextMeshProUGUI Txt_HP; // 체력 텍스트
    public TextMeshProUGUI Txt_Damage_1; // 데미지 텍스트 BG
    public TextMeshProUGUI Txt_Damage_2; // 데미지 텍스트 real

    public TextMeshProUGUI Txt_HealPoint_1; // 힐 텍스트 BG
    public TextMeshProUGUI Txt_HealPoint_2; // 힐 텍스트 real

    public Image Img_HPbar;

    public int maxHP;
    // int maxHP;
    float nowHP;
    // 최소 체력 0

    public int Damage;
    public int HealPoint;

    void Awake()
    {
        nowHP = maxHP;
        Initializer();
    }

    void Initializer()
    {
        UIset();
    }

    public void OnClickDamage() // 데미지
    {
        Damage = Random.Range(5, 26); // 5 ~ 25 랜덤 데미지 값 설정
        nowHP -= Damage;
        if (nowHP < 0) // 체력이 0보다 작아지면 0으로 설정
        {
            nowHP = 0;
        }

        Img_HPbar.fillAmount = nowHP / maxHP;
        Txt_HP.text = $"{nowHP} / {maxHP}";
        Txt_Damage_1.text = $"{Damage}의 피해를 입혔다!";
        Txt_Damage_2.text = $"{Damage}의 피해를 입혔다!";

    }

    public void OnClickHeal() // 회복
    {
        HealPoint = Random.Range(3, 16); // 5 ~ 25 랜덤 데미지 값 설정
        nowHP += HealPoint;
        if (nowHP > maxHP) // 체력이 최대 체력을 초과하면 최대 체력으로 설정
        {
            nowHP = maxHP;
        }

        Img_HPbar.fillAmount = nowHP / maxHP;
        Txt_HP.text = $"{nowHP} / {maxHP}"; // now HP / maxHP : 50 / 100
        Txt_HealPoint_1.text = $"{HealPoint}의 피해를 입혔다!";
        Txt_HealPoint_2.text = $"{HealPoint}의 피해를 입혔다!";
        
    }

    void UIset()
    {
        Img_HPbar.fillAmount = nowHP / maxHP;
        Txt_HP.text = $"{nowHP} / {maxHP}";
    }
}


