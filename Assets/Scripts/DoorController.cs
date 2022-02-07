using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;// Scene전환을 위해 추가

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMouseDown()//오브젝트를 클릭하면
    {
        SceneManager.LoadScene("Scene3_Outdoor");//Scene3으로 전환하기
    }
}
