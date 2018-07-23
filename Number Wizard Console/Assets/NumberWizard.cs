using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start ()
    {
        StartGame();
    }
	
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("ナンバーウィザードへよこそ！");
        Debug.Log("数字を一つ選択してください。");
        Debug.Log("あなたが選べる最も高い数字は： " + max);
        Debug.Log("あなたが選べる最も小さい数字は： " + min);
        Debug.Log("私にあなたの数字を教えないでください。＾＾");
        Debug.Log("あなたの数字が " + guess + " より高いか小さいか教えてください。");
        Debug.Log("上矢印キー = よりも高い, 下矢印キー = よりも小さい, Enterキー = 正しい");
        max += 1;
    }

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("あなたが選んだ数字は" + guess + "です!!");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("あなたの数字が " + guess + " より高いか小さいか教えてください。");
    }
}
