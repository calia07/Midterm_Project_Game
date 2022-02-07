using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI-Images 사용을 위해 추가

public class WaterController : MonoBehaviour
{
    public ParticleSystem Water;// ParticleSystem인 Water 추가
    public GameObject grass3;// 게임오브젝트 grass3 추가

    public void OnMouseDown()// 오브젝트를 클릭하면
    {
        if (!Water.isPlaying)// 만약 Particle Water가 실행중이지 않으면
        {
            Water.Play();// Particle Water를 실행하기
            grass3.SetActive(false);//grass3을 화면에 보이지 않게 하기
            GetComponent<AudioSource>().Play();// 구성요소인 AudioSource를 재생하기
        }
        else// 만약 Particle Water가 실행중이면
        {
            Water.Stop();// Particle Water를 멈추기
            grass3.SetActive(true);//grass3을 화면에 보이게 하기
            GetComponent<AudioSource>().Pause();// 구성요소인 AudioSource의 재생을 멈추기
        }
    }
}
