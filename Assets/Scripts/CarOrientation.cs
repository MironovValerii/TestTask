using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarOrientation : MonoBehaviour
{
    [SerializeField] GameObject _panel;
    private void Start()
    {
        _panel.GetComponent<OrientationSetter>().OrientationPortrait();
    }
}
