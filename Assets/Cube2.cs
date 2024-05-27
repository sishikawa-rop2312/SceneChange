using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene("Scene1");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Debug.Log("num:" + Cube1.num);
            // Debug.Log("Global:" + SuperGlobal.score);
            // Debug.Log("Global2:" + SuperGlobal.version);

            //Cube1.instanceでシングルトンのCube1インスタンスにアクセス
            Debug.Log("num" + Cube1.instance.GetNum());
        }
    }
}
