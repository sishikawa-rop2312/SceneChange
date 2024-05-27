using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cube1 : MonoBehaviour
{
    public static Cube1 instance;
    int num = 0;
    // public static int num = 0;

    void Awake()
    {
        //初回のAwakeの時のみここがtrueになりインスタンスが登録される
        if (instance == null)
        {
            //このインスタンスをstatic な instanceに登録
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //２回目以降重複して作成してしまったgameObjectを削除
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            num++;
            SuperGlobal.score++;
            Debug.Log(num);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("Scene2");
        }
    }

    // numのゲッターを作成
    public int GetNum()
    {
        return this.num;
    }
}
