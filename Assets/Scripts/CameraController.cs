using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float inputX, inputZ;//실수형 변수 inputX, inputZ 선언
    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");//inputX에 GetAxis를 사용하여 Horizontal 좌표 축의 값을 얻어와 넣는다.
        inputZ = Input.GetAxis("Vertical");//inputZ에 GetAxis를 사용하여 Vertical 좌표 축의 값을 얻어와 넣는다
        if (inputX != 0)//inputX가 0이 아니면
            rotate();//rotate함수 실행
        if (inputZ != 0)//inputZ가 0이 아니면
            move();//move 함수 실행
    }

    private void move()// move 함수 선언
    {
        transform.position += transform.forward * 10*inputZ *Time.deltaTime;//카메라의 위치를 inputZ에 10을 곱하고 Time.deltaTime을 곱한 값만큼 앞으로 이동한다.  
    }

    private void rotate() //rotate 함수 선언
    {
        transform.Rotate(new Vector3(0f, 30*inputX * Time.deltaTime, 0f));// y축 방향으로 10과 inputX, Time.deltaTime을 곱한 값으로 회전한다.
    }
}
