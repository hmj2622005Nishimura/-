using UnityEngine;

public class ropeController : MonoBehaviour
{
	[SerializeField] GameObject rope;
	int Move = 1000;

	public void Shoot(Vector3 rp)
	{
		GetComponent<Rigidbody>().AddForce(rp);
	}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
		Shoot(new Vector3(Move, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
