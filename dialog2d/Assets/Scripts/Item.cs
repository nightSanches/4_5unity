using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [System.Serializable]
    public class Messages
    {
        public Sprite Sprite;
        public string Text;
    }

    public Image Img;
    public Text Message;
    public int step;

    public List<Messages> messages = new List<Messages>();
    private void Start()
    {
        Img.sprite = messages[step].Sprite;
        Message.text = messages[step].Text;
    }

    public void Next()
    {
        if (step == messages.Count - 1) return;
        step++;
        Img.sprite = messages[step].Sprite;
        Message.text = messages[step].Text;
    }

    public void Back()
    {
        if (step == 0) return;
        step--;
        Img.sprite = messages[step].Sprite;
        Message.text = messages[step].Text;
    }
}
