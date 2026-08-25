using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
	private void Update()
	{
		if(Keyboard.current.escapeKey.wasPressedThisFrame)
		{
			SceneManager.LoadScene("TITLE");
		}
	}
}
