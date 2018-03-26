using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{


    // mpから消費mpを引いた値を返す関数
    int magic(int a)
    {
        // mpから消費mpを引いて、変数bに代入する
        int b = a - 5;
        // 変数bを呼び出し元の関数に返す
        return b;
    }

    // Use this for initialization
    void Start()
    {

        //変数の宣言
        int mp;
        //変数の代入
        mp = 53;

        for (int i = 0; i < 11; i++)
        {

            // magic関数に残りmp数を渡し、返り値をnum変数に代入する
            int num = magic(mp);

            if (mp < 5)
            {
                // mpが5未満だった場合
                Debug.Log("MPが足りないため魔法が使えない。");
            }
            else
            {
                // mpが5以上だった場合残りmpをmpに代入し、numを表示する
                mp = num;
                Debug.Log("魔法攻撃をした。残りMPは" + num);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}