using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] Image num100;
    [SerializeField] Image num10;
    [SerializeField] Image num1;
    [SerializeField] Image num_1;
    [SerializeField] Image num_01;

    [SerializeField] Sprite[] number;
 
    float time;
    private int IntTime;
    private string StringInt;
    private int DecimalTime;
    private string StringDecimal;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;

        text.text = time.ToString("f2");
    }

    // Update is called once per frame
    void Update()
    {
        if(time < 1000.0f)
        {
            time += Time.deltaTime;
            IntTime = (int)time;
            DecimalTime = (int)((time - (int)time) * 100);
            StringInt = IntTime.ToString("000");
            StringDecimal = DecimalTime.ToString("00");
            Debug.Log(StringInt);
            Debug.Log(int.Parse(StringInt[0].ToString()));

            num100.sprite = number[int.Parse(StringInt[0].ToString())];
            num10.sprite = number[int.Parse(StringInt[1].ToString())];
            num1.sprite = number[int.Parse(StringInt[2].ToString())];

            num_1.sprite = number[int.Parse(StringDecimal[0].ToString())];
            num_01.sprite = number[int.Parse(StringDecimal[1].ToString())];
        }

        text.text = time.ToString("f2");
    }
}