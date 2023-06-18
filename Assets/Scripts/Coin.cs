using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float i;
    public Material baseMaterial;
    [SerializeField] Canvas _canvas;

    private void Start()
    {
        _canvas.GetComponent<OrientationSetter>().OrientationPortrait();
    }

    void FixedUpdate()
    {
        if (i == 360)
        {
            i = 0;
        }
        i = i + 2;
        this.transform.rotation = Quaternion.Euler(0, i, 0); ;
    }

    public void OnMouseDown()
    {
        if (this.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        else 
        {
            this.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
