using UnityEngine;
using UnityEngine.UI;

public class CanvasResolutionHandler : MonoBehaviour
{
	private CanvasScaler canvasScaler;

	private void Awake()
	{
		canvasScaler = GetComponent<CanvasScaler>();

		SetScaler();
	}

	private void SetScaler()
	{
		var screenWidthScale  = Screen.width  / canvasScaler.referenceResolution.x;
		var screenHeightScale = Screen.height / canvasScaler.referenceResolution.y;

		canvasScaler.matchWidthOrHeight = screenWidthScale > screenHeightScale ? 1 : 0;
	}
}