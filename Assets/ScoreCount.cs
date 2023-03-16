using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    //�\�����链�_
    private int score;

    //�擾���链�_
    private int smallStarScore = 5;
    private int largeStarScore = 1;
    private int smallCloudScore = 10;
    private int largeCloudScore = 2;

    //���_��\������e�L�X�g�̕ϐ��w��
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");
        //���_�̏����l��0��
        this.score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //�I�u�W�F�N�g���Փ˂������Ƀ^�[�Q�b�g�ɉ����ē��_�����Z���ĕ\������悤��
    void OnCollisionEnter(Collision collision)
    {
        string target = collision.gameObject.tag;
        Debug.Log(target);//����e�X�g�p�ɒǉ�

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