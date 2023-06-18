using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] Canvas _canvas;

    public void ExitToMenu()
    {
        SceneManager.LoadSceneAsync(0);
        _canvas.GetComponent<OrientationSetter>().OrientationPortrait();
    }

    public void LoadingScens(int i)
    {
        SceneManager.LoadSceneAsync(i);
    }
}
