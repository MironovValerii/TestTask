using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSlider : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    [SerializeField] private Slider _slider;
    public int i = 1;
    [SerializeField] private Canvas _canvas;

    public void Start()
    {
        _canvas.GetComponent<OrientationSetter>().OrientationPortrait();
    }

    void Update()
    {
        _slider.value = i;
        
        if (_slider.value >= 9)
        {
            _panel.SetActive(false);
        }
    }
}
