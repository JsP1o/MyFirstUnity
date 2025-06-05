using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private string myName = "박준석";
    private int age = 30;
    private float height = 171.3f;
    private float weight = 70.1f;
    private string major = "심리학";
    private string hobby = "기타 연주";
    private string favoriteFood = "페퍼로니 피자";
    private string favoriteColor = "검은색";
    private string MBTI = "INTP";
    private string favoriteMusic = "J-POP";
    private string favoriteGame = "마비노기";

    void Start()
    {
        SelfIntroduction();
        // SelfIntroduction(myName, age, height, weight, major, hobby, favoriteFood, favoriteColor, MBTI, favoriteMusic, favoriteGame);
    }

    public void SelfIntroduction()
    {
        Debug.Log($"안녕하세요. 제 이름은 {myName}입니다.");
        Debug.Log($"나이는 {age}세 입니다.");
        Debug.Log($"키는 작아요, {height}cm 입니다.");
        Debug.Log($"몸무게는 {weight}kg 입니다.");
        Debug.Log($"{major}을 전공했습니다.");
        Debug.Log($"취미는 {hobby}입니다.");
        Debug.Log($"{favoriteFood}를 가장 좋아합니다.");
        Debug.Log($"가장 좋아하는 색은 {favoriteColor}입니다.");
        Debug.Log($"MBTI는 {MBTI}입니다.");
        Debug.Log($"{favoriteMusic} 듣는 것을 좋아합니다.");
        Debug.Log($"{favoriteGame}을 재미있게 플레이 한 기억이 있습니다.");
    }

    //public void SelfIntroduction(string _name, int _age, float _height, float _weight, string _major, string _hobby, string _favoriteFood, string _favoriteColor, string _MBTI, string _favoriteMusic, string _favoriteGame)
    //{
    //    Debug.Log($"안녕하세요. 제 이름은 {_name}입니다.");
    //    Debug.Log($"나이는 {_age}세 입니다.");
    //    Debug.Log($"키는 작아요, {_height}cm 입니다."); 
    //    Debug.Log($"몸무게는 {_weight}kg 입니다.");
    //    Debug.Log($"{_major}을 전공했습니다.");
    //    Debug.Log($"취미는 {_hobby}입니다.");
    //    Debug.Log($"{_favoriteFood}를 가장 좋아합니다.");
    //    Debug.Log($"가장 좋아하는 색은 {_favoriteColor}입니다.");
    //    Debug.Log($"MBTI는 {_MBTI}입니다.");
    //    Debug.Log($"{_favoriteMusic} 듣는 것을 좋아합니다.");
    //    Debug.Log($"{_favoriteGame}을 재미있게 플레이 한 기억이 있습니다.");
    //}
}