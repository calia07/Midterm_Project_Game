using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI-Image사용하기 위해 추가
using UnityEngine.Video;// video 사용을 위해 추가

public class TVController : MonoBehaviour
{
    public GameObject TV;//게임 오브젝트 TV 추가
    public GameObject grass2; //게임 오브젝트 grass2 추가
    GameObject MovieClip; //게임 오브젝트 MovieClip을 추가
    public VideoPlayer videoPlayer;//VideoPlayer인 videoPlayer 추가

     void Start()
    {
        this.MovieClip = GameObject.Find("Screen");// 변수 MovieClip에 Screen이라는 오브젝트를 찾아 넣는다.
        videoPlayer = MovieClip.GetComponent<VideoPlayer>();// videoPlayer에는 MovieClip의 구성요소인 VideoPlayer를 가져와 넣는다.
    }

    // Start is called before the first frame update
    public void OnMouseDown()//오브젝트를 클릭하면
    {
        if (videoPlayer.isPlaying)//만약 videoPlayer가 실행중이면
        {
            videoPlayer.Pause();//videoPlayer를 멈추기
            grass2.SetActive(true);//grass2를 활성화시키기
            TV.SetActive(true);//TV 오브젝트를 활성화시키기
        }
        else//만약 videoPlayer가 실행중이면
        {
            videoPlayer.Play();//videoPlayer를 실행하기
            TV.SetActive(false);//TV 오브젝트를 비활성화시키기
            grass2.SetActive(false);//grass2를 비활성화시키기
        }
    }
}
