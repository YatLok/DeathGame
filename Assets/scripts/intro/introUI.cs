using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class introUI : MonoBehaviour {

    GameObject introText;
    GameObject TextHowToPlay;
    Button ButtonGameStart;
    Button ButtonHowToGame;
    Button ButtonReturn;

	// Use this for initialization
	void Start () {
        introText = GameObject.Find("IntroText");
        introText.GetComponent<Text>().enabled = false;
        TextHowToPlay = GameObject.Find("TextHowToPlay");
        TextHowToPlay.GetComponent<Text>().enabled = false;
        ButtonGameStart = GameObject.Find("ButtonGameStart").GetComponent<Button>();
        ButtonGameStart.gameObject.SetActive(false);
        ButtonHowToGame = GameObject.Find("ButtonHowToPlay").GetComponent<Button>();
        ButtonHowToGame.gameObject.SetActive(false);
        ButtonReturn = GameObject.Find("ButtonReturn").GetComponent<Button>();
        ButtonReturn.gameObject.SetActive(false);
        //TextHowTo();
        Invoke("introStart", 1f);
        //introStart();
	}

    // ゲーム紹介文
    public void introStart()
    {
        //introText = GameObject.Find("IntroText");
        introText.GetComponent<Text>().enabled = true;
        introText.GetComponent<longText>().introText();
        introText.GetComponent<longText>();
        Invoke("introAfter", 1f);

    }

    // ゲーム紹介文の後のボタンオン
    public void introAfter()
    {
        ButtonGameStart.gameObject.SetActive(true);
        ButtonHowToGame.gameObject.SetActive(true);
    }

    // howtoplayに入った時のボタンオフ
    public void ButtonOff()
    {
        ButtonGameStart.gameObject.SetActive(false);
        ButtonHowToGame.gameObject.SetActive(false);

    }




    // ゲームの遊び方
    public void TextHowTo()
    {
        TextHowToPlay.GetComponent<Text>().enabled = true;
        TextHowToPlay.GetComponent<longText>().HowtoplayGameText();
        TextHowToPlay.GetComponent<longText>();
        ButtonReturn.gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
