using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class end1Text : MonoBehaviour
{

    private Text messageText;
    private string message;
    // 一回のメッセージの最大文字数
    private int maxTextLength = 30;
    // 一回のメッセージの現在の文字数
    private int textLength = 0;
    // メッセージの最大行数
    private int maxLine = 3;
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


    public void end1()
    {
        messageText = GameObject.Find("testText").GetComponent<Text>();
        messageText.text = "";
        SetMessage("死神\n" +
                   "ここにある蝋燭はすべて、人間の命なのさ"
                   + "これはお前の女房。これはお前の息子。。。。");

    }
    public void end2()
    {
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



//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class end1Text : MonoBehaviour {

//    private Text messageText;
//    private string message;
//    // 一回のメッセージの最大文字数
//    private int maxTextLength = 30;
//    // 一回のメッセージの現在の文字数
//    private int textLength = 0;
//    // メッセージの最大行数
//    private int maxLine = 3;
//    // 現在の行
//    private int nowLine = 0;
//    // テキストスピード
//    private float textSpeed = 0.05f;
//    // 経過時間
//    private float elapsedTime = 0f;
//    // 今見ている文字番号
//    private int nowTextNum = 0;
//    // 一回分のメッセージを表示したかどうか
//    private bool isOneMessage = false;
//    // メッセージをすべて表示したかどうか
//    private bool isEndMessage = false;

//    // Use this for initialization
//    void Start()
//    {
//    }

//    public void end1()
//    {
//        messageText = GameObject.Find("testText").GetComponent<Text>();
//        messageText.text = "";
//        SetMessage("死神\n" +
//                   "この蝋燭は命の炎さ\n"
//                   + "これはお前の女房。これはお前の息子。。。。");

//    }
//    public void end2()
//    {
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        // メッセージをすべて表示している、または、メッセージが設定されていない場合
//        if (isEndMessage || message == null)
//        {
//            return;
//        }
//        // 一回分のメッセージを表示していない場合
//        if (!isOneMessage)
//        {

//            messageText.text += message [nowTextNum];
//            // 改行があれば nowTextNum 今見ている文字番号に +1
//            if(message [nowTextNum] == '\n')
//            {
//                nowLine++;
//            }
//            nowTextNum++; // 今見ている文字番号
//            textLength++; // 一回のメッセージの現在の文字数
//            elapsedTime = 0f; // 経過時間
//            // 今見ている文字番号 >= メッセージの文字数　|| 一回のメッセージの現在の文字数 >= 90 || 現在の行 >= 3
//            if (nowTextNum >= message.Length || textLength >= maxTextLength || nowLine >= maxLine)
//            {
//                isOneMessage = true;
//            }

//            elapsedTime += Time.deltaTime;

//            //if (Input.GetMouseButtonDown(0))
//            //{
//            //    var allText = messageText.text;
//            //    for (var i = nowTextNum; i < message.Length; i++)
//            //    {
//            //        allText += message[i];
//            //        if (message[i] == '\n')
//            //        {
//            //            nowLine++;
//            //        }
//            //        nowTextNum++;
//            //        textLength++;
//            //        if (nowTextNum >= message.Length || textLength >= maxTextLength || nowLine >= maxLine)
//            //        {
//            //            messageText.text = allText;
//            //            isOneMessage = true;
//            //            break;
//            //        }
//            //    }
//            //}

//        }
//        // 一回分のメッセージを表示した
//        else
//        {
//            elapsedTime += Time.deltaTime;
//            if (Input.GetMouseButtonDown(0))
//            {
//                messageText.text = "";
//                nowLine = 0;
//                elapsedTime = 0f;
//                textLength = 0;
//                isOneMessage = false;

//                // もうmessage.Lengthに何もない場合。つまりメッセージが表示しきった場合
//                if(nowTextNum >= message.Length)
//                {
//                    nowTextNum = 0;
//                    isEndMessage = true;

//                }
//            }
//        }

//    }

//    void SetMessage(string message)
//    {
//        this.message = message;
//    }


//}



//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class end1Text : MonoBehaviour
//{

//    private Text messageText;
//    private string message;
//    private int maxTextLength = 5;
//    private int textLength = 0;
//    private int maxLine = 3;
//    private int nowLine = 0;
//    private float textSpeed = 0.05f;
//    private float elapsedTime = 0f;
//    private int nowTextNum = 0;
//    private float clickFlashTime = 0.2f;
//    private bool isOneMessage = false;
//    private bool isEndMessage = false;

//    // Use this for initialization
//    void Start()
//    {
//        messageText = GameObject.Find("testText").GetComponent<Text>();
//        messageText.text = "";
//        SetMessage("木戸孝允。なんてこったい！！ああああああああああいいいいいいいいいうううううううう"
//                   + "桂小五郎とも言います。ああああああああああああああああ");

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (isEndMessage || message == null)
//        {
//            return;
//        }
//        if (!isOneMessage)
//        {
//            if (elapsedTime >= textSpeed)
//            {
//                messageText.text += message[nowTextNum];
//                if (message[nowTextNum] == '\n')
//                {
//                    nowLine++;
//                }
//                nowTextNum++;
//                textLength++;
//                elapsedTime = 0f;
//                if (nowTextNum >= message.Length || textLength >= maxTextLength || nowLine >= maxLine)
//                {
//                    isOneMessage = true;
//                }

//            }
//            elapsedTime += Time.deltaTime;

//            if (Input.GetMouseButtonDown(0))
//            {
//                var allText = messageText.text;
//                for (var i = nowTextNum; i < message.Length; i++)
//                {
//                    allText += message[i];
//                    if (message[i] == '\n')
//                    {
//                        nowLine++;
//                    }
//                    nowTextNum++;
//                    textLength++;
//                    if (nowTextNum >= message.Length || textLength >= maxTextLength || nowLine >= maxLine)
//                    {
//                        messageText.text = allText;
//                        isOneMessage = true;
//                        break;
//                    }
//                }
//            }

//        }
//        else
//        {
//            if (Input.GetMouseButtonDown(0))
//            {
//                messageText.text = "";
//                textLength = 0;
//                isOneMessage = false;
//                if (nowTextNum >= message.Length)
//                {
//                    nowTextNum = 0;
//                    isEndMessage = true;

//                }
//            }
//        }

//    }

//    void SetMessage(string message)
//    {
//        this.message = message;
//    }


//}
