using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// UI-Image사용하기 위해 추가

public class LightController : MonoBehaviour
{
    public GameObject light1; //게임 오브젝트 light추가
    public GameObject grass1;// 게임 오브젝트 grass1 추가
    private bool on = true;// 논리형 변수 on을 true로 선언

    public void OnMouseDown()//오브젝트를 클릭하면
    {
        if (on)//논리형 변수 on이 true일 때
        {  light1.SetActive(false);//light1 오브젝트를 비활성화 시키기
            on = false;//논리형 변수 on의 값을 false로 바꾸기
            transform.Rotate(0,-40,0);// 오브젝트를 y축방향으로 -40도 회전시키기
            grass1.SetActive(true);//grass1을 활성화 시키기
        }
        else//논리형 변수 on이 false일 때
        { light1.SetActive(true);//light1 오브젝트를 활성화 시키기
            on = true;//논리형 변수 on의 값을 true로 바꾸기
            transform.Rotate(0, 40, 0);// 오브젝트를 y축방향으로 40도 회전시키기
            grass1.SetActive(false);//grass1을 비활성화 시키기
        }
        
    }
}
