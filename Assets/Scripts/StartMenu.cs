using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    [SerializeField] Canvas _canvas;
    private void Start()
    {
        _canvas.GetComponent<OrientationSetter>().OrientationPortrait();
    }
}
