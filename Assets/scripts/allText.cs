using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class allText : MonoBehaviour {


    private Text messageText;
    private string message;
    // 一回のメッセージの最大文字数
    private int maxTextLength = 100;
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

    bool boolEnd6 = false;
    bool boolEnd5 = false;
    bool boolEnd4 = false;
    bool boolEnd3 = false;
    bool boolEnd2 = false;
    bool boolEnd1 = false;



    // 男は死ぬ
    public void end1()
    {
        messageText = GameObject.Find("end1Text").GetComponent<Text>();
        boolEnd1 = true;
        messageText.text = "";
        SetMessage("死神\n" +
                   "「ここにある蝋燭はすべて、人間の命なのさ。\n" +
                   "これはお前の女房。これはお前の息子。。。。\n" +
                   "そしてお前の蝋燭は、今にも消えそうなこいつだ」\n" +
                   "ーー死神曰く、先ほど男がズルをしたことにより、\n" +
                   "蝋燭の炎が先ほどの患者のものと男のものが入れ替わったという。\n" +
                   "男はとりみだし、死神にチャンスをくれるように懇願した。\n" +
                   "今にも消えそうな男の蝋燭から、まだ芯の長い別の蝋燭に炎を移せたら、男は助かるという。\n" +
                   "消えるか、移せるか。\n" +
                   "男は身体中から流れる脂汗と、手の震えと戦いながら懸命に蝋燭の炎を移そうと努力をするが…\n" +
                   "「消えるよ、消えそうだよ、ほら、ほら…」\n" +
                   "死神がそばから囁き、男の手の震えはますます増していく。\n" +
                   "「消えた…」\n" +
                   "ぼそりと呟かれたと同時に、男は目を剥き、倒れたのだった。");
        

    }
    // ロウソクがため息で消え、結局男は死ぬ
    public void end2()
    {
        boolEnd2 = true;
        messageText = GameObject.Find("end2Text").GetComponent<Text>();
        messageText.text = "";
        SetMessage("死神\n" +
                   "「ここにある蝋燭はすべて、人間の命なのさ。\n" +
                   "これはお前の女房。これはお前の息子。。。。\n" +
                   "そしてお前の蝋燭は、今にも消えそうなこいつだ」\n" +
                   "ーー死神曰く、先ほど男がズルをしたことにより、\n" +
                   "蝋燭の炎が先ほどの患者のものと男のものが入れ替わったという。\n" +
                   "男はとりみだし、死神にチャンスをくれるように懇願した。\n" +
                   "今にも消えそうな男の蝋燭から、まだ芯の長い別の蝋燭に炎を移せたら、男は助かるという。\n" +
                   "消えるか、移せるか。\n" +
                   "男は身体中から流れる脂汗と、手の震えと戦いながら懸命に蝋燭の炎を移そうとし…\n" +
                   "「や、やった……」\n" +
                   "男の命が助かった。\n" +
                   "と同時に…\n" +
                   "「ふぅ…」\n" +
                   "ついたため息が、新しく灯った炎を消してしまったのだった…");
    }

    // 危機一髪で男は助かる
    public void end3()
    {
        boolEnd3 = true;
        messageText = GameObject.Find("end3Text").GetComponent<Text>();
        messageText.text = "";
        SetMessage("死神\n" +
                   "「ここにある蝋燭はすべて、人間の命なのさ。\n" +
                   "これはお前の女房。これはお前の息子。。。。\n" +
                   "そしてお前の蝋燭は、今にも消えそうなこいつだ」\n" +
                   "ーー死神曰く、先ほど男がズルをしたことにより、\n" +
                   "蝋燭の炎が先ほどの患者のものと男のものが入れ替わったという。\n" +
                   "男はとりみだし、死神にチャンスをくれるように懇願した。\n" +
                   "今にも消えそうな男の蝋燭から、まだ芯の長い別の蝋燭に炎を移せたら、男は助かるという。\n" +
                   "消えるか、移せるか。\n" +
                   "男は身体中から流れる脂汗と、手の震えと戦いながら懸命に蝋燭の炎を移そうとし…\n" +
                   "「つまんないねぇ…」\n" +
                   "死神は一言呟くと、姿を消したのだった…");

    }
    // 大金持ちエンド
    public void end4()
    {
        boolEnd4 = true;
        messageText = GameObject.Find("end4Text").GetComponent<Text>();
        messageText.text = "";
        SetMessage("ズルをすれば大金が手に入るが、\n" +
                   "男はその気にならなかった。\n" +
                   "そうして、男は手に入れた力を堅実に使い、大金持ちになったのであった。\n");

    }

    // 日常エンド
    public void end5()
    {
        boolEnd5 = true;
        messageText = GameObject.Find("end5Text").GetComponent<Text>();
        messageText.text = "";
        SetMessage("男は今日も街へ繰り出した。\n" +
                   "変化のない、変わりない日常。\n" +
                   "しかし、男はそれでよかったのだった。\n");

    }

    // 中途半端エンド
    public void end6()
    {
        boolEnd6 = true;
        messageText = GameObject.Find("end6Text").GetComponent<Text>();
        messageText.text = "";
        SetMessage("男は今日も街へ繰り出した。\n" +
                   "しかし、男の上に大きな植木鉢が降ってきた。\n" +
                   "男は間も無く、息を引き取ったのだった\n");

    }
    public void introText()
    {
        messageText = GameObject.Find("IntroText").GetComponent<Text>();
        messageText.text = "";
        SetMessage("わわわ");
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
                    if(boolEnd3 == true)
                    {
                        after3();
                    }
                    else if(boolEnd2 == true)
                    {
                        after2();
                    }
                    else if(boolEnd1 == true)
                    {
                        after1();
                    }
                    else if(boolEnd5 == true)
                    {
                        FadeManager.Instance.LoadScene("intro", 1f);

                    }
                    else if(boolEnd6 == true)
                    {
                        FadeManager.Instance.LoadScene("intro", 1f);

                    }
                    else if(boolEnd4 == true)
                    {
                        FadeManager.Instance.LoadScene("intro", 1f);
                    }

                }
            }
        }

    }

    void SetMessage(string message)
    {
        this.message = message;
    }
    public void after6()
    {
        GameObject endName = GameObject.Find("Town2UI2");
        endName.GetComponent<town2UI2>().end6Name();

    }
    public void after5()
    {
        GameObject endName = GameObject.Find("Town2UI2");
        endName.GetComponent<town2UI2>().end5Name();

    }
    public void after3()
    {
        GameObject endName = GameObject.Find("DirectorUI");
        endName.GetComponent<caveUI>().end3Name();

    }
    public void after2()
    {
        GameObject endName = GameObject.Find("DirectorUI");
        endName.GetComponent<caveUI>().end2Name();
    }
    public void after1()
    {
        GameObject endName = GameObject.Find("DirectorUI");
        endName.GetComponent<caveUI>().end1Name();
    }
}
