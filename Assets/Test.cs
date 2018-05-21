using UnityEngine;
using System.Collections;


public class Boss
{
    private int mp = 53;    //  mp
    private int power = 18; //魔法攻撃力

    //攻撃用の関数
    public void Magic()
    {
        if(mp>=5)
        {
            this.mp = mp - 5;
            Debug.Log("魔法攻撃をした。残りMPは。" + mp );
        }

        else
        {
            //mpが5より少なかった場合
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}



public class Test : MonoBehaviour
    {
    //  Use this for initialization
    void Start()
    {
        //   要素数5の配列を初期化する
        int[] array = { 88, 17, 103, 56, 99 };

        //配列の要素をすべて表示する
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の要素をすべて逆順で表示する
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }



        // Bossクラスの変数を宣言してインスタンスを代入
        Boss boss = new Boss();

        // 攻撃用の関数を呼び出す
        boss.Magic();

        //10回処理を繰り返す
        for(int i = 0; i < 10; i++)
        {
            boss.Magic();
        }


    }
    // Update is called once per frame
    void Update()
    {

    }
 }

    

