using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Scene간의 이동을 위해

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeFIrstScene()
    {
        SceneManager.LoadScene("Scene1_Title");// Scene1_Title로 이동
    }
    public void ChangeSecondScene()
    {
        SceneManager.LoadScene("Scene2_Indoor2");//Scene2_Indoor2로 이동
    }
    public void ChangeThirdScene()
    {
        SceneManager.LoadScene("Scene3_Outdoor");//Scene3_Outdoor로 이동
    }
}
