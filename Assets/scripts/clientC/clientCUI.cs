using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clientCUI : MonoBehaviour {
    GameObject Player;
    GameObject Death;
    GameObject TextEventPoint;
    Button EnterButton;
    GameObject TextSelect;
    Button useMagicButton;
    Button noMagicButton;
    GameObject TextuseMagic;
    GameObject TextMagicAfter;
    GameObject TextNoMagicAfter;
    public static int deathPoint;
    public static int goodPoint;
    public static int normalPoint;
    GameObject TextEnd4;
    GameObject end4NameText;

    // 選択肢・ズルをする
    public void addDeathPoint()
    {
        deathPoint += 1;
        Debug.Log("死神ポイント：" + deathPoint);
        Debug.Log("goodポイント：" + goodPoint);
        Debug.Log("normalポイント：" + normalPoint);
        TextuseMagic.GetComponent<Text>().enabled = true;
        TextuseMagic.GetComponent<CText>().usemagicMsgStart();
        Invoke("deathDestroy", 2f);
        //Destroy(Death);
    }

    // ズルをして死神が消える
    void deathDestroy()
    {
        Destroy(Death);
        Destroy(TextuseMagic);
        TextMagicAfter.GetComponent<Text>().enabled = true;
        TextMagicAfter.GetComponent<CText>().usemagicMsg2Start();
        Invoke("cave", 1f);

    }

    // 選択肢・ズルをしない
    public void addGoodPointAndNormalPoint()
    {
        goodPoint += 1;
        //normalPoint += 1;
        Debug.Log("死神ポイント：" + deathPoint);
        Debug.Log("goodポイント：" + goodPoint);
        Debug.Log("normalポイント：" + normalPoint);
        TextNoMagicAfter.GetComponent<Text>().enabled = true;
        TextNoMagicAfter.GetComponent<CText>().nomagicMsg();
        Invoke("end4", 1f);
    }

    // end4の大金持ち！
    void end4()
    {
        TextNoMagicAfter.GetComponent<Text>().enabled = false;
        TextEnd4.GetComponent<Text>().enabled = true;
        TextEnd4.GetComponent<allText>().end4();
        end4NameText.GetComponent<Text>().enabled = true;

        Debug.Log("end4 大金持ち");
        Debug.Log("死神ポイント；" + map2UI.deathPoint + "goodポイント：" + (map2UI.goodPoint + goodPoint) + "normalポイント：" + map2UI.normalPoint);
    }

    // 洞窟シーンへ
    void cave()
    {
        FadeManager.Instance.LoadScene("cave", 1.0f);

    }

    // 次のシーンへ
    void nextScene()
    {
        FadeManager.Instance.LoadScene("map", 1.0f);
        //SceneManager.LoadScene("map");

    }


    // 部屋に入る
    public void enterRoom()
    {
        //Debug.Log("部屋に入りますか？");
        TextEventPoint.GetComponent<Text>().enabled = true;
        EnterButton.gameObject.SetActive(true);

    }

    // 部屋に入った後
    public void next()
    {
        //Debug.Log("部屋に入ったシーンへ");
        Player.transform.position = new Vector3(-16f, -0.006f, -20f);
        Player.transform.rotation = Quaternion.Euler(0, 30, 0);
        Player.transform.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        TextSelect.GetComponent<Text>().enabled = true;
        TextSelect.GetComponent<CText>().deathMsgStart();

    }

    // 部屋に入った後の選択肢ボタン追加
    public void addbutton()
    {
        Debug.Log("選択肢を表示");
        useMagicButton.gameObject.SetActive(true);
        noMagicButton.gameObject.SetActive(true);
    }

    // 部屋に入った後の選択肢ボタンオフ
    public void removebutton()
    {
        Debug.Log("ボタン削除");
        useMagicButton.gameObject.SetActive(false);
        noMagicButton.gameObject.SetActive(false);
    }

    // 部屋に入るかメッセージのオフ
    public void removeMsg()
    {
        TextSelect.GetComponent<Text>().enabled = false;

    }

    // 部屋から離れるとメッセージオフ
    public void leaveRoom()
    {
        Debug.Log("部屋から離れた");
        TextEventPoint.GetComponent<Text>().enabled = false;
        EnterButton.gameObject.SetActive(false);
    }
    // Use this for initialization
    void Start()
    {
        deathPoint = map2UI.deathPoint;
        normalPoint = map2UI.normalPoint;
        goodPoint = map2UI.goodPoint;

        Player = GameObject.FindGameObjectWithTag("Player");
        Death = GameObject.FindGameObjectWithTag("Death");
        TextEventPoint = GameObject.Find("TextEventPoint");
        TextEventPoint.GetComponent<Text>().enabled = false;
        EnterButton = GameObject.Find("EnterButton").GetComponent<Button>();
        EnterButton.gameObject.SetActive(false);
        TextSelect = GameObject.Find("DeathMsg");
        TextSelect.GetComponent<Text>().enabled = false;
        TextuseMagic = GameObject.Find("UseMagicMsg");
        TextuseMagic.GetComponent<Text>().enabled = false;
        TextMagicAfter = GameObject.Find("UseMagicMsg2");
        TextMagicAfter.GetComponent<Text>().enabled = false;
        TextNoMagicAfter = GameObject.Find("noMagicMsg");
        TextNoMagicAfter.GetComponent<Text>().enabled = false;

        useMagicButton = GameObject.Find("useMagicButton").GetComponent<Button>();
        useMagicButton.gameObject.SetActive(false);
        noMagicButton = GameObject.Find("noMagicButton").GetComponent<Button>();
        noMagicButton.gameObject.SetActive(false);

        TextEnd4 = GameObject.Find("end4Text");
        TextEnd4.GetComponent<Text>().enabled = false;
        end4NameText = GameObject.Find("end4NameText");
        end4NameText.GetComponent<Text>().enabled = false;

    }

    // Update is called once per frame
    void Update () {
		
	}
}
