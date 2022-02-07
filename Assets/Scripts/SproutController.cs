using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI 사용을 위해 추가

public class SproutController : MonoBehaviour
{
    public GameObject grass1;// 게임오브젝트 grass3 추가
    public GameObject grass2;// 게임오브젝트 grass3 추가
    public GameObject grass3;// 게임오브젝트 grass3 추가
    public GameObject Panel;// 게임오브젝트 Panel 추가

    // Update is called once per frame
    void Update()
    {
        ShowPanel1();//ShowPanel1()호출하기
    }
    void ShowPanel1()//ShowPanel1()정의하기
    {
        if(grass1.activeSelf==true&& grass2.activeSelf == true&& grass3.activeSelf == true)//만약 grass1과 grass2와 grass3이 동시에 active 되어 있으면
        {
            Panel.SetActive(true);//Panel을 활성화하기
        }
    }
}
