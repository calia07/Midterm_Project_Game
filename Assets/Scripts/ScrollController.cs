using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// UI-Image사용하기 위해

public class ScrollController : MonoBehaviour
{
    public GameObject Panel;// 게임오브젝트 Panel 추가
    int counter = 0; // 변수 counter에 0을 넣어 선언

    public void ShowhidePanel()// ShowhidePanel()함수 선언
    {
        counter++;//counter을 1씩 증가
        if (counter % 2 == 1)//만약 counter가 홀수이면
        {
            Panel.gameObject.SetActive(true);// SetActive를 false로 하여 보이지 않게 만든다
        }
        else//이 경우가 아니라면
        {
            Panel.gameObject.SetActive(false);// SetActive를 true로 하여 보이게 만든다
        }
    }
}
