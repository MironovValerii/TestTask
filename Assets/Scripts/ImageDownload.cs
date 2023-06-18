using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;

public class ImageDownload : MonoBehaviour
{
    private string _url;
    private Image _img;
    [SerializeField] private GameObject _imgPrefab;
    private GameObject content;
    public int i = 1;
    [SerializeField] private GameObject panel_Image;
    [SerializeField] private Slider slider;
    private bool isNewPicture = false;


    private void Start()
    {
        content = GameObject.Find("Content");
        _url = "http://data.ikppbb.com/test-task-unity-data/pics/" + i.ToString() + ".jpg";
        Debug.Log(i.ToString());
        _img = GetComponent<Image>();
        StartCoroutine(LoadImage());

    }

    private void Update()
    {
       if (content.GetComponent<RectTransform>().anchoredPosition.y > (i*i * 3.5f) && (slider.GetComponent<LoadSlider>().i+1) == i && isNewPicture == false)
       {
            isNewPicture = true;
            StartCoroutine(LoadImage());
            Debug.Log(name);
       }
    }

    private IEnumerator LoadImage()
    {
        UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture( _url );
        yield return webRequest.SendWebRequest();
        if (webRequest.isDone == false)
        {
            Debug.Log(webRequest.error);
        }
        else
        {
            Texture texture = ((DownloadHandlerTexture)webRequest.downloadHandler).texture;
            _img.sprite = Sprite.Create((Texture2D)texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
            _img.color = Color.white;

            if (i <= 9)
            {
                GameObject _img_ = Instantiate(_imgPrefab);
                _img_.transform.SetParent(content.transform);
                _img_.GetComponent<Image>().sprite = null;
                _img_.GetComponent<Image>().color = Color.clear;
                _img_.GetComponent<ImageDownload>().i = i + 1;
                slider.GetComponent<LoadSlider>().i = i;
            }

            if (i < 66 && i > 9 && isNewPicture == true)
            {
                isNewPicture = false;
                GameObject _img_ = Instantiate(_imgPrefab);
                _img_.transform.SetParent(content.transform);
                _img_.GetComponent<Image>().sprite = null;
                _img_.GetComponent<Image>().color = Color.clear;
                _img_.GetComponent<ImageDownload>().i = i + 1;
                slider.GetComponent<LoadSlider>().i = i;
            }
        }
    }

    public void But()
    {
        Show(_img.sprite);
        panel_Image.GetComponent<OrientationSetter>().OrientationAny();
    }

    public void Show(Sprite sprite)
    {
        panel_Image.SetActive(true);
        GameObject child = panel_Image.transform.GetChild(0).gameObject;
        child.GetComponent<Image>().sprite = sprite;
    }
}
