using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    GameManager gm;

    public Text moneyIndicator;


    void Start () {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        moneyIndicator.text = gm.Resources[0] + "";
    }
}
