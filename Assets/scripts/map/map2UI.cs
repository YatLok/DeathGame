using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map2UI : MonoBehaviour {

    public static int deathPoint;
    public static int goodPoint;
    public static int normalPoint;
    //public static int deathPointPlus;
    //public static int goodPointPlus;
    //public static int normalPointPlus;

    // Use this for initialization
    void Start()
    {
        deathPoint = map1UI.deathPoint + clientBUI.deathPoint;
        goodPoint = map1UI.goodPoint + clientBUI.goodPoint;
        normalPoint = map1UI.normalPoint + clientBUI.normalPoint + town2UI2.normalPoint;
        //deathPoint = clientBUI.deathPoint;
        //normalPoint = clientBUI.normalPoint;
        //goodPoint = clientBUI.goodPoint;
        Debug.Log("map2 死神ポイント：" + deathPoint);
        Debug.Log("map2 goodポイント：" + goodPoint);
        Debug.Log("map2 normalポイント：" + normalPoint);
    }

    public void clientBorC()
    {
        if(deathPoint > 0 || goodPoint > 0 || normalPoint > 0)
        {
            FadeManager.Instance.LoadScene("clientC", 1.0f);
        }else
        {
            FadeManager.Instance.LoadScene("clientB", 1.0f);

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
