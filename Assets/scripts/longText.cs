using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class longText : MonoBehaviour {


    private Text messageText;
    private string message;
    // 一回のメッセージの最大文字数
    private int maxTextLength = 100;
    // 一回のメッセージの現在の文字数
    private int textLength = 0;
    // メッセージの最大行数
    private int maxLine = 10;
    // 現在の行
    private int nowLine = 0;
    // テキストスピード
    private float elapsedTime = 0f;
    // 今見ている文字番号
    private int nowTextNum = 0;
    // 一回分のメッセージを表示したかどうか
    private bool isOneMessage = false;
    // メッセージをすべて表示したかどうか
    private bool isEndMessage = false;


    public void introText()
    {
        messageText = GameObject.Find("IntroText").GetComponent<Text>();
        messageText.text = "";
        SetMessage("金があればすぐ使う。毎日毎日金がない。\n" +
                   "そんなこの男が、いつもの如くぶらぶらと街を歩いていたときの話である。");
    }

    public void HowtoplayGameText()
    {
        messageText = GameObject.Find("TextHowToPlay").GetComponent<Text>();
        messageText.text = "";
        SetMessage("このゲームにはいくつか選択肢があらわれます。\n" +
                   "選んだ選択肢により、主人公が迎える結末が変化します。\n" +
                   "エンディングは全部で6パターンあります。");

    }

    // Update is called once per frame
    void Update()
    {
        // メッセージをすべて表示している、または、メッセージに何も入っていない場合
        if (isEndMessage || message == null)
        {
            return;
        }
        // 一回分のメッセージを表示していない場合
        if (!isOneMessage)
        {

            messageText.text += message[nowTextNum];
            // message[●番]のなかに改行があれば nowLine つまり現在の行に +1
            if (message[nowTextNum] == '\n')
            {
                nowLine++;
            }
            nowTextNum++; // 今見ている文字番号
            textLength++; // 一回のメッセージの現在の文字数
            //elapsedTime = 0f; // 経過時間
            // 今見ている文字番号 >= メッセージの文字数　|| 一回のメッセージの現在の文字数 >= 90 || 現在の行 >= 3
            if (nowTextNum >= message.Length || textLength >= maxTextLength || nowLine >= maxLine)
            {
                isOneMessage = true;
            }

            elapsedTime += Time.deltaTime;


        }
        // 一回分のメッセージを表示した
        else
        {
            elapsedTime += Time.deltaTime;
            if (Input.GetMouseButtonDown(0))
            {
                messageText.text = "";
                nowLine = 0;
                elapsedTime = 0f;
                textLength = 0;
                isOneMessage = false;

                // もうmessage.Lengthに何もない場合。つまりメッセージが表示しきった場合
                if (nowTextNum >= message.Length)
                {
                    nowTextNum = 0;
                    isEndMessage = true;

                }
            }
        }

    }

    void SetMessage(string message)
    {
        this.message = message;
    }
}
