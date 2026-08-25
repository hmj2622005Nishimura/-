using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GM1 : MonoBehaviour
{
	[SerializeField] GameObject PlayerChara;
	[SerializeField] GameObject ENEMY;
	[SerializeField] GameObject TEXT;

	float timer;
	float timerT;

	int count = 1;
	int enemyC;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
		timerT += Time.deltaTime;
		enemyC = 20;
		TEXT.GetComponent<TextMeshProUGUI>().text = "timer" + timer.ToString("F1");
		if(timerT > enemyC * count)
		{
			GameObject ii = Instantiate(ENEMY);
			ii.transform.position = new Vector3 (PlayerChara.transform.position.x + 30, PlayerChara.transform.position.y - 20, 0);
			ii.GetComponent<EneCon>().SetPlayC(PlayerChara);
			count++;
			timerT = 0;
		}
    }
}
