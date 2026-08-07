using UnityEngine;
using UnityEngine.InputSystem;

public class EneCon : MonoBehaviour
{
	[SerializeField] GameObject PlayC;

	float Xv = 0.3f;
	float Yv = 0f;
	float DiscoverA = 10.0f;
	float MoveSp = 0.2f;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		Application.targetFrameRate = 60;
	}

	// Update is called once per frame
	void Update()
	{
		Xv = 0;
		Yv = 0;
		if(transform.position.x + DiscoverA > PlayC.transform.position.x )
		{
			if(transform.position.x <= PlayC.transform.position.x )
			{
				Xv = Xv + MoveSp;
			}
		}
		if(transform.position.x - DiscoverA < PlayC.transform.position.x)
		{
			if(transform.position.x >= PlayC.transform.position.x )
			{
				Xv = Xv - MoveSp;
			}
		}
		if(transform.position.y + DiscoverA > PlayC.transform.position.y )
		{
			if(transform.position.y <= PlayC.transform.position.y )
			{
				Yv = Yv + MoveSp;
			}
		}
		if(transform.position.y - DiscoverA < PlayC.transform.position.y)
		{
			if(transform.position.y >= PlayC.transform.position.y )
			{
				Yv = Yv - MoveSp;
			}
		}
		transform.Translate(Xv, Yv, 0);
	}
}

