using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerCon : MonoBehaviour
{
	float Xv;
	float Yv;

	[SerializeField] GameObject Enemy;

	float MoveS = 0.3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Application.targetFrameRate = 60; 
    }

    // Update is called once per frame
    void Update()
    {
		if (Keyboard.current.aKey.isPressed)
		{
			Xv = Xv - MoveS;
		}
		if (Keyboard.current.dKey.isPressed)
		{
			Xv = Xv + MoveS;
		}
		if (Keyboard.current.wKey.isPressed)
		{
			Yv = Yv + MoveS;
		}
		if (Keyboard.current.sKey.isPressed)
		{
			Yv = Yv - MoveS;
		}
		transform.Translate(Xv, Yv, 0);
		Xv = 0;
		Yv = 0;

		if(transform.position.x <= Enemy.transform.position.x)
		{
			if(transform.position.x >= Enemy.transform.position.x)
			{
				SceneManager.LoadScene("GameOver");
			}
		}
	}
}
