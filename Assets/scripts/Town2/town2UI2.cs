using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class town2UI2 : MonoBehaviour {

    public static int normalPoint = 0;
    GameObject TextEnd5;
    GameObject TextEnd6;
    GameObject end5NameText;
    GameObject end6NameText;
    GameObject textGotoHome;



    public void gohome()
    {
        Debug.Log("帰ります");
        normalPoint += 1;
        //FadeManager.Instance.LoadScene("map", 1.0f);
        this.judge();
    }

    public void judge()
    {
        map2UI.normalPoint += 1;
        if(map2UI.normalPoint >= 2)
        {
            textGotoHome.GetComponent<Text>().enabled = false;
            TextEnd5.GetComponent<Text>().enabled = true;
            TextEnd5.GetComponent<allText>().end5();
            end5NameText.GetComponent<Text>().enabled = true;

            Debug.Log("end5 近所の人からいい職を斡旋してもらう");
            Debug.Log("deathポイント；" + map2UI.deathPoint + "goodポイント：" + map2UI.goodPoint + "normalポイント：" + map2UI.normalPoint);
        }
        else if((map2UI.deathPoint + map2UI.goodPoint) >= 2)
        {
            textGotoHome.GetComponent<Text>().enabled = false;
            TextEnd6.GetComponent<Text>().enabled = true;
            TextEnd5.GetComponent<allText>().end6();
            end6NameText.GetComponent<Text>().enabled = true;

            Debug.Log("end6 男は事故死する");
            Debug.Log("deathポイント；" + map2UI.deathPoint + "goodポイント：" + map2UI.goodPoint + "normalポイント：" + map2UI.normalPoint);
            //FadeManager.Instance.LoadScene("clientA", 1.0f);

        }
        else
        {
            FadeManager.Instance.LoadScene("map", 1.0f);

        }

    }
    public void end5Name()
    {
    }
    public void end6Name()
    {

    }

	// Use this for initialization
	void Start () {
        //normalPoint += 1;
        //this.judge();
        this.textGotoHome = GameObject.Find("TextGotoHome");

        TextEnd5 = GameObject.Find("end5Text");
        TextEnd5.GetComponent<Text>().enabled = false;
        TextEnd6 = GameObject.Find("end6Text");
        TextEnd6.GetComponent<Text>().enabled = false;
        end5NameText = GameObject.Find("end5NameText");
        end6NameText = GameObject.Find("end6NameText");
        end5NameText.GetComponent<Text>().enabled = false;
        end6NameText.GetComponent<Text>().enabled = false;

        //normalPoint = map1UI.normalPoint;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
