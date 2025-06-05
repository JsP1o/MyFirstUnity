using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Introduce : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text;

    public string myName = "박준석";
    public int age = 30;
    public float height = 171.3f;
    public float weight = 70.1f;
    public string major = "심리학";
    public string hobby = "기타 연주";
    public string favoriteFood = "페퍼로니 피자";
    public string favoriteColor = "검은색";
    public string MBTI = "INTP";
    public string favoriteMusic = "J-POP";
    public string favoriteGame = "마비노기";

    public void OCB_name()
    {
        Txt_Text.text = $"제 이름은 {myName}입니다.";
    }

    public void OCB_age()
    {
        Txt_Text.text = $"나이는 {age}세 입니다.";
    }

    public void OCB_height()
    {
        Txt_Text.text = $"키는 작아요, {height}cm 입니다.";
    }

    public void OCB_weight()
    {
        Txt_Text.text = $"몸무게는 {weight}kg 입니다.";
    }

    public void OCB_favoriteFood()
    {
        Txt_Text.text = $"{favoriteFood}를 가장 좋아합니다.";
    }

    public void OCB_favoriteColor()
    {
        Txt_Text.text = $"가장 좋아하는 색은 {favoriteColor}입니다.";
    }

    public void OCB_MBTI()
    {
        Txt_Text.text = $"MBTI는 {MBTI}입니다.";
    }

    public void OCB_favoriteMusic()
    {
        Txt_Text.text = $"{favoriteMusic} 듣는 것을 좋아합니다.";
    }   

    public void OCB_favoriteGame()
    {
        Txt_Text.text = $"{favoriteGame}을 재미있게 플레이 한 기억이 있습니다.";
    }   

    public void OCB_hobby()
    {
        Txt_Text.text = $"취미는 {hobby}입니다.";
    }

}
