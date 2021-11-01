using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    [SerializeField] GameObject t1;
    [SerializeField] GameObject t2;
    [SerializeField] GameObject t3;
    [SerializeField] GameObject t4;
    [SerializeField] GameObject t5;
    [SerializeField] GameObject t6;
    [SerializeField] GameObject t7;
    [SerializeField] GameObject t8;
    [SerializeField] GameObject t9;
    [SerializeField] GameObject t10;
    [SerializeField] GameObject t11;
    [SerializeField] GameObject t0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var one = Input.GetAxis("1");
        var two = Input.GetAxis("2");
        var three = Input.GetAxis("3");
        var four = Input.GetAxis("4");
        var five = Input.GetAxis("5");
        var six = Input.GetAxis("6");
        var seven = Input.GetAxis("7");
        var eight = Input.GetAxis("8");
        var nine = Input.GetAxis("9");
        var ten = Input.GetAxis("10");
        var eleven = Input.GetAxis("11");
        var zero = Input.GetAxis("0");

        TextMeshPro text1 = t1.GetComponent<TextMeshPro>();
        TextMeshPro text2 = t2.GetComponent<TextMeshPro>();
        TextMeshPro text3 = t3.GetComponent<TextMeshPro>();
        TextMeshPro text4 = t4.GetComponent<TextMeshPro>();
        TextMeshPro text5 = t5.GetComponent<TextMeshPro>();
        TextMeshPro text6 = t6.GetComponent<TextMeshPro>();
        TextMeshPro text7 = t7.GetComponent<TextMeshPro>();
        TextMeshPro text8 = t8.GetComponent<TextMeshPro>();
        TextMeshPro text9 = t9.GetComponent<TextMeshPro>();
        TextMeshPro text10 = t10.GetComponent<TextMeshPro>();
        TextMeshPro text11 = t11.GetComponent<TextMeshPro>();
        TextMeshPro text0 = t0.GetComponent<TextMeshPro>();

        text1.SetText(one.ToString());
        text2.SetText(two.ToString());
        text3.SetText(three.ToString());
        text4.SetText(four.ToString());
        text5.SetText(five.ToString());
        text6.SetText(six.ToString());
        text7.SetText(seven.ToString());
        text8.SetText(eight.ToString());
        text9.SetText(nine.ToString());
        text10.SetText(ten.ToString());
        text11.SetText(eleven.ToString());
        text0.SetText(zero.ToString());
    }
}
