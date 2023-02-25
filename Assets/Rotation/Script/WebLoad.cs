using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class WebLoad : MonoBehaviour
{
    [SerializeField] RawImage image;

    void Awake()
    {
        StartCoroutine(GetTexture(image));
    }

    IEnumerator GetTexture(RawImage webImage)
    {
        string url = "https://cdn.pixabay.com/photo/2015/11/16/14/43/cat-1045782_960_720.jpg";

        UnityWebRequest www = UnityWebRequestTexture.GetTexture(url);

        yield return www.SendWebRequest();

        if(www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            webImage.texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
        }
    }
}
