using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    //表示する得点
    private int score;

    //取得する得点
    private int smallStarScore = 5;
    private int largeStarScore = 1;
    private int smallCloudScore = 10;
    private int largeCloudScore = 2;

    //得点を表示するテキストの変数指定
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
        //得点の初期値を0に
        this.score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //オブジェクトが衝突した時にターゲットに応じて得点を加算して表示するように
    void OnCollisionEnter(Collision collision)
    {
        string target = collision.gameObject.tag;
        Debug.Log(target);//動作テスト用に追加

        if (target == "SmallStarTag")
        {
            score += this.smallStarScore;
            Debug.Log(score);
        }
        else if (target == "LargeStarTag")
        {
            score += this.largeStarScore;
            Debug.Log(score);
        }
        else if (target == "SmallCloudTag")
        {
            score += this.smallCloudScore;
        }
        else if (target == "LargeCloudTag")
        {
            score += this.largeCloudScore;
        }

        this.scoreText.GetComponent<Text>().text = "Score: " + score.ToString();
    }
}