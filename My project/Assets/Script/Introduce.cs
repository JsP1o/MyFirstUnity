using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Introduce : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text;

    public string myName = "���ؼ�";
    public int age = 30;
    public float height = 171.3f;
    public float weight = 70.1f;
    public string major = "�ɸ���";
    public string hobby = "��Ÿ ����";
    public string favoriteFood = "���۷δ� ����";
    public string favoriteColor = "������";
    public string MBTI = "INTP";
    public string favoriteMusic = "J-POP";
    public string favoriteGame = "������";

    public void OCB_name()
    {
        Txt_Text.text = $"�� �̸��� {myName}�Դϴ�.";
    }

    public void OCB_age()
    {
        Txt_Text.text = $"���̴� {age}�� �Դϴ�.";
    }

    public void OCB_height()
    {
        Txt_Text.text = $"Ű�� �۾ƿ�, {height}cm �Դϴ�.";
    }

    public void OCB_weight()
    {
        Txt_Text.text = $"�����Դ� {weight}kg �Դϴ�.";
    }

    public void OCB_favoriteFood()
    {
        Txt_Text.text = $"{favoriteFood}�� ���� �����մϴ�.";
    }

    public void OCB_favoriteColor()
    {
        Txt_Text.text = $"���� �����ϴ� ���� {favoriteColor}�Դϴ�.";
    }

    public void OCB_MBTI()
    {
        Txt_Text.text = $"MBTI�� {MBTI}�Դϴ�.";
    }

    public void OCB_favoriteMusic()
    {
        Txt_Text.text = $"{favoriteMusic} ��� ���� �����մϴ�.";
    }   

    public void OCB_favoriteGame()
    {
        Txt_Text.text = $"{favoriteGame}�� ����ְ� �÷��� �� ����� �ֽ��ϴ�.";
    }   

    public void OCB_hobby()
    {
        Txt_Text.text = $"��̴� {hobby}�Դϴ�.";
    }

}
