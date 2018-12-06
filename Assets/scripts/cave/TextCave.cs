using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCave : MonoBehaviour {



    public void end3Msg()
    {
        Text end3 = GameObject.Find("end3Text").GetComponent<Text>();
        end3.text = "死神\n"
            + "ここに連れてきたのは他でもない。あんたがやったことの代償をみてもらおうとおもってね…うんたらかんたら";
    }

    public void end2Msg()
    {
        Text end2 = GameObject.Find("end2Text").GetComponent<Text>();
        end2.text = "死神\n"
            + "ロウソクがついた。ふぅ…。あ、消えた…";
    }

    public void end1Msg()
    {
        Text end1 = GameObject.Find("end1Text").GetComponent<Text>();
        end1.text = "死神\n"
            + "消えそうだよ。消えそう、消える。きえる。きえた・・・・";
    }


	// Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update () {
    }
}
