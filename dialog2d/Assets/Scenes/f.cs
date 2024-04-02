using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class f : MonoBehaviour
{
    public Transform parent;
    private GameObject currentBtn;

    public GameObject prefab;
    private GameObject play;

    public GameObject inputgo;
    public InputField input;

    public void AddGame(GameObject btn)
    {
        currentBtn = btn;
        inputgo.SetActive(true);
    }

    public void AddPath()
    {
        string src = input.text;
        play = Instantiate(prefab, currentBtn.transform.position, Quaternion.identity, parent);
        play.GetComponent<b>().src = src + "/novel.exe";
        play.GetComponent<b>().imgSrc = src + "/novel.png";
        inputgo.SetActive(false);
        currentBtn.SetActive(false);
    }
}
