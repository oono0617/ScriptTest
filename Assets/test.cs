using UnityEngine;
using System.Collections;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // mp

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }
    // 魔法攻撃用の関数
    public void magic(int cost)
    {
        if (mp > cost)
        {
            // 残りmpが消費mp以上だった場合
            mp -= cost;
            Debug.Log("魔法攻撃をした。残りMPは"+ mp);
        }
        else
        {
            //残りmpが消費mp未満だった場合
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class test : MonoBehaviour
{

    void Start()
    {
        // 配列を初期化する
        int[] array = { 30, 20, 50, 10, 80, };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
                // 配列の要素を表示する
                Debug.Log(array[i]);
        }

        // 配列の各要素に値を代入する
        array[0] = 80;
        array[1] = 10;
        array[2] = 50;
        array[3] = 20;
        array[4] = 30;

        for (int i = 0; i < array.Length; i++)
        {
            // 配列の要素を表示する
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法攻撃用の関数を呼び出す
        for (int i = 0; i < 11; i++)
        {
            lastboss.magic(5);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}