using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private string myName = "���ؼ�";
    private int age = 30;
    private float height = 171.3f;
    private float weight = 70.1f;
    private string major = "�ɸ���";
    private string hobby = "��Ÿ ����";
    private string favoriteFood = "���۷δ� ����";
    private string favoriteColor = "������";
    private string MBTI = "INTP";
    private string favoriteMusic = "J-POP";
    private string favoriteGame = "������";

    void Start()
    {
        SelfIntroduction();
        // SelfIntroduction(myName, age, height, weight, major, hobby, favoriteFood, favoriteColor, MBTI, favoriteMusic, favoriteGame);
    }

    public void SelfIntroduction()
    {
        Debug.Log($"�ȳ��ϼ���. �� �̸��� {myName}�Դϴ�.");
        Debug.Log($"���̴� {age}�� �Դϴ�.");
        Debug.Log($"Ű�� �۾ƿ�, {height}cm �Դϴ�.");
        Debug.Log($"�����Դ� {weight}kg �Դϴ�.");
        Debug.Log($"{major}�� �����߽��ϴ�.");
        Debug.Log($"��̴� {hobby}�Դϴ�.");
        Debug.Log($"{favoriteFood}�� ���� �����մϴ�.");
        Debug.Log($"���� �����ϴ� ���� {favoriteColor}�Դϴ�.");
        Debug.Log($"MBTI�� {MBTI}�Դϴ�.");
        Debug.Log($"{favoriteMusic} ��� ���� �����մϴ�.");
        Debug.Log($"{favoriteGame}�� ����ְ� �÷��� �� ����� �ֽ��ϴ�.");
    }

    //public void SelfIntroduction(string _name, int _age, float _height, float _weight, string _major, string _hobby, string _favoriteFood, string _favoriteColor, string _MBTI, string _favoriteMusic, string _favoriteGame)
    //{
    //    Debug.Log($"�ȳ��ϼ���. �� �̸��� {_name}�Դϴ�.");
    //    Debug.Log($"���̴� {_age}�� �Դϴ�.");
    //    Debug.Log($"Ű�� �۾ƿ�, {_height}cm �Դϴ�."); 
    //    Debug.Log($"�����Դ� {_weight}kg �Դϴ�.");
    //    Debug.Log($"{_major}�� �����߽��ϴ�.");
    //    Debug.Log($"��̴� {_hobby}�Դϴ�.");
    //    Debug.Log($"{_favoriteFood}�� ���� �����մϴ�.");
    //    Debug.Log($"���� �����ϴ� ���� {_favoriteColor}�Դϴ�.");
    //    Debug.Log($"MBTI�� {_MBTI}�Դϴ�.");
    //    Debug.Log($"{_favoriteMusic} ��� ���� �����մϴ�.");
    //    Debug.Log($"{_favoriteGame}�� ����ְ� �÷��� �� ����� �ֽ��ϴ�.");
    //}
}