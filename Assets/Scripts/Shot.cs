using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    [SerializeField] private GameObject _shot;
    [SerializeField] private GameObject _muz;


    public void StartShot()
    {
        
        _shot.transform.position = _muz.transform.position;
        _shot.transform.rotation = _muz.transform.rotation;
        Instantiate(_shot);
    }
}
