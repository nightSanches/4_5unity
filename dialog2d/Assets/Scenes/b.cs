using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class b : MonoBehaviour
{
    public string src;
    public string imgSrc;

    private void Start()
    {
        Texture2D texture = null;
        byte[] fileData;
        if (File.Exists(imgSrc))
        {
            fileData = File.ReadAllBytes(imgSrc);
            texture = new Texture2D(1, 1);
            texture.LoadImage(fileData);
        }
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        this.gameObject.GetComponent<Image>().sprite = sprite;
    }

    public void PlayGame()
    {
        Process.Start(src);
    }
}
