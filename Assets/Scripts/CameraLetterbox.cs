using UnityEngine;

public class CameraLetterbox : MonoBehaviour
{
	[SerializeField] private float baseWidth  = 1920f;
	[SerializeField] private float baseHeight = 1080f;

	private float ratio => baseWidth / baseHeight;

	private void Start()
	{
		var cam = Camera.main;

		var currentRatio = (float)Screen.width / Screen.height;
		var scaleHeight  = currentRatio        / ratio;

		var rect = cam.rect;

		if (scaleHeight < 1.0f)
		{
			rect.width  = 1.0f;
			rect.height = scaleHeight;
			rect.x      = 0;
			rect.y      = (1.0f - scaleHeight) / 2.0f;

			cam.rect = rect;

			return;
		}

		var scaleWidth = 1.0f / scaleHeight;

		rect.width  = scaleWidth;
		rect.height = 1.0f;
		rect.x      = (1.0f - scaleWidth) / 2.0f;
		rect.y      = 0;

		cam.rect = rect;
	}
}