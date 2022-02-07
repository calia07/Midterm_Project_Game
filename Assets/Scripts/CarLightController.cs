using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// UI-Image사용하기 위해

public class CarLightController : MonoBehaviour
{
    public GameObject light1;//게임 오브젝트 light1추가
    public GameObject light2;//게임 오브젝트 light2추가
    public GameObject grass4;// 게임 오브젝트 grass4 추가
    private bool on = true;// 논리형 변수 on을 true로 선언
    public void OnMouseDown()// 오브젝트를 클릭하면
    {
        if (on)// on이 true일 때
        {
            light1.SetActive(false);//light1 오브젝트를 비활성화 시키기
            light2.SetActive(false);//light2 오브젝트를 비활성화 시키기
            on = false;//논리형 변수 on의 값을 false로 바꾸기
            grass4.SetActive(true);//grass4을 활성화 시키기
        }
        else//on이 false일 때
        {
            light1.SetActive(true);//light1 오브젝트를 활성화 시키기
            light2.SetActive(true);//light2 오브젝트를 활성화 시키기
            on = true;//논리형 변수 on의 값을 true로 바꾸기
            grass4.SetActive(false);//grass4을 비활성화 시키기
        }

    }

}
