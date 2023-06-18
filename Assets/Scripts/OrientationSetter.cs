using UnityEngine;

public class OrientationSetter : MonoBehaviour
{
    public void OrientationPortrait()
    {
        Screen.orientation = UnityEngine.ScreenOrientation.Portrait;
    }

    public void OrientationAny()
    {
        Screen.orientation = UnityEngine.ScreenOrientation.AutoRotation;

        Screen.autorotateToPortrait = Screen.autorotateToPortraitUpsideDown = true;
        Screen.autorotateToLandscapeLeft = Screen.autorotateToLandscapeRight = true;
    }

    public void OrientationLandscape()
    {
        Screen.orientation = UnityEngine.ScreenOrientation.LandscapeLeft;
    }
}
