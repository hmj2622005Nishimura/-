using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TITLE : MonoBehaviour
{
	[SerializeField] GameObject TEXT;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		Application.targetFrameRate = 60;
    }

	private void Update()
	{
		TEXT.GetComponent<TextMeshPro>();
		if(Keyboard.current.enterKey.wasPressedThisFrame)
		{
			SceneManager.LoadScene("PLAY2scene");
		}
	}

}
