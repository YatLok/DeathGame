using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cliAdireUI : MonoBehaviour {

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

    // 選択肢・力を使う
    public void addDeathPoint()
    {
        deathPoint += 1;
        Debug.Log("死神ポイント：" + deathPoint);
        Debug.Log("goodポイント：" + goodPoint);
        Debug.Log("normalポイント：" + normalPoint);
        TextuseMagic.GetComponent<Text>().enabled = true;
        TextuseMagic.GetComponent<cliAText>().usemagicMsgStart();
        Invoke("deathDestroy", 2f);
        //Destroy(Death);
    }

    // 力を使ったので死神が消える
    void deathDestroy()
    {
        Destroy(Death);
        Destroy(TextuseMagic);
        TextMagicAfter.GetComponent<Text>().enabled = true;
        TextMagicAfter.GetComponent<cliAText>().usemagicMsg2Start();
        Invoke("nextScene", 1f);

    }

    // 選択肢・力を使わない
    public void addGoodPointAndNormalPoint()
    {
        goodPoint += 1;
        normalPoint += 1;
        Debug.Log("死神ポイント：" + deathPoint);
        Debug.Log("goodポイント：" + goodPoint);
        Debug.Log("normalポイント：" + normalPoint);
        TextNoMagicAfter.GetComponent<Text>().enabled = true;
        TextNoMagicAfter.GetComponent<cliAText>().nomagicMsg();
        Invoke("nextScene", 1f);
    }


    // 次のシーンへ
    void nextScene()
    {

        //SceneManager.LoadScene("map");
        FadeManager.Instance.LoadScene("map", 1.0f);
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
        TextSelect.GetComponent<cliAText>().deathMsgStart();

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
    void Start () {
        //deathPoint = Point.deathPoint;
        //normalPoint = Point.normalPoint;
        //goodPoint = Point.goodPoint;

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

    }

    // Update is called once per frame
    void Update () {
		
	}
}
