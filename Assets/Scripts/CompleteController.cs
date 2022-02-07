using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI 사용을 위해 추가
using UnityEngine.SceneManagement;// Scene전환을 위해 추가

public class CompleteController : MonoBehaviour
{
    public GameObject grass3;//grass3 게임오브젝트 추가
    public GameObject grass4;//grass4 게임오브젝트 추가
    public GameObject complete;//complete 게임오브젝트 추가

    public void Update()
    {
        ShowPanel();// ShowPanel()호출하기
    }
    // Start is called before the first frame update
    void ShowPanel()
    {
        if (grass3.activeSelf==true && grass4.activeSelf==true)// 만약 grass3과 grass4가 동시에 active 되어 있으면
        {
            SceneManager.LoadScene("Scene4_Ending");//Scene4로 화면 전환
        }
    }
}
