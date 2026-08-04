using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCon : MonoBehaviour
{
	float Xv;
	float Yv;
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
			Xv = Xv - 1.0f;
		}
		if (Keyboard.current.dKey.isPressed)
		{
			Xv = Xv + 1.0f;
		}
		if (Keyboard.current.wKey.isPressed)
		{
			Yv = Yv + 1.0f;
		}
		if (Keyboard.current.sKey.isPressed)
		{
			Yv = Yv - 1.0f;
		}
		transform.Translate(Xv, Yv, 0);
		Xv = 0;
		Yv = 0;
	}
}
