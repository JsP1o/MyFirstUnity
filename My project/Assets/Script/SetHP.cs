using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.ComponentModel.Design;

public class SetHP : MonoBehaviour
{
    public TextMeshProUGUI Txt_HP; // ü�� �ؽ�Ʈ
    public TextMeshProUGUI Txt_Damage_1; // ������ �ؽ�Ʈ BG
    public TextMeshProUGUI Txt_Damage_2; // ������ �ؽ�Ʈ real

    public TextMeshProUGUI Txt_HealPoint_1; // �� �ؽ�Ʈ BG
    public TextMeshProUGUI Txt_HealPoint_2; // �� �ؽ�Ʈ real

    public Image Img_HPbar;

    public int maxHP;
    // int maxHP;
    float nowHP;
    // �ּ� ü�� 0

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

    public void OnClickDamage() // ������
    {
        Damage = Random.Range(5, 26); // 5 ~ 25 ���� ������ �� ����
        nowHP -= Damage;
        if (nowHP < 0) // ü���� 0���� �۾����� 0���� ����
        {
            nowHP = 0;
        }

        Img_HPbar.fillAmount = nowHP / maxHP;
        Txt_HP.text = $"{nowHP} / {maxHP}";
        Txt_Damage_1.text = $"{Damage}�� ���ظ� ������!";
        Txt_Damage_2.text = $"{Damage}�� ���ظ� ������!";

    }

    public void OnClickHeal() // ȸ��
    {
        HealPoint = Random.Range(3, 16); // 5 ~ 25 ���� ������ �� ����
        nowHP += HealPoint;
        if (nowHP > maxHP) // ü���� �ִ� ü���� �ʰ��ϸ� �ִ� ü������ ����
        {
            nowHP = maxHP;
        }

        Img_HPbar.fillAmount = nowHP / maxHP;
        Txt_HP.text = $"{nowHP} / {maxHP}"; // now HP / maxHP : 50 / 100
        Txt_HealPoint_1.text = $"{HealPoint}�� ���ظ� ������!";
        Txt_HealPoint_2.text = $"{HealPoint}�� ���ظ� ������!";
        
    }

    void UIset()
    {
        Img_HPbar.fillAmount = nowHP / maxHP;
        Txt_HP.text = $"{nowHP} / {maxHP}";
    }
}


