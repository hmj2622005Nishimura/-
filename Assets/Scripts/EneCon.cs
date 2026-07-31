using UnityEngine;

public class EneCon : MonoBehaviour
{
	[SerializeField] GameObject PlayC;
	[SerializeField] GameObject Enemy;

	int x;
	int y;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		Application.targetFrameRate = 60;
	}

	// Update is called once per frame
	void Update()
	{
		float Xv = 1;
		float Yv = 1;
		if (PlayC.transform.position.x = Enemy.transform.position.x)
		{
			Xv = 2.0f;
		}
		if (PlayC.transform.position.y = Enemy.transform.position.y)
		{
			Yv = 2.0f;
		}

		transform.Translate(Xv, Yv, 0);
	}
}
