using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cliAText : MonoBehaviour {

    //Text messageText;

    public void deathMsgStart()
    {
        Text messageText = GameObject.Find("DeathMsg").GetComponent<Text>();
        messageText.text = "街で出会った死神から、特殊な力を手に入れた。死神が患者の足元に居れば消すことができるが、頭上にいる場合は消せないそうだ。\n"
            + "力を使いますか？";
        GameObject button = GameObject.Find("DirectorUI");
        button.GetComponent<cliAdireUI>().addbutton();
    }

    public void usemagicMsgStart()
    {
        Text useMgcText = GameObject.Find("UseMagicMsg").GetComponent<Text>();
        useMgcText.text = "呪文を唱えた！\n"
            + "呪文をさらに唱えた！！";
    }
    public void usemagicMsg2Start()
    {
        Text magicAfter = GameObject.Find("UseMagicMsg2").GetComponent<Text>();
        magicAfter.text = "患者は突然回復し、患者の家族より報酬として大金を手に入れた！！";
    }

    public void nomagicMsg()
    {
        Text nomagicAfter = GameObject.Find("noMagicMsg").GetComponent<Text>();
        nomagicAfter.text = "男は力を使わずに帰宅することにした。";
    }

    //public void enterRoom()
    //{
    //    Text enterText = GameObject.Find("TextEventPoint").GetComponent<Text>();
    //    enterText.text = "部屋に入りますか？";
    //}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
