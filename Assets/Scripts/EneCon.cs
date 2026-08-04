using UnityEngine;
using UnityEngine.InputSystem;

public class EneCon : MonoBehaviour
{
	[SerializeField] GameObject PlayC;
	[SerializeField] GameObject Enemy;

	float Xv = 1.0f;
	float Yv = 1.0f;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		Application.targetFrameRate = 60;
	}

	// Update is called once per frame
	void Update()
	{
		//if()
		transform.Translate(Xv, Yv, 0);
	}
}

