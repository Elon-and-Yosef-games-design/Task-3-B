using TMPro;
using UnityEngine;

public class UI_controller : MonoBehaviour
{
    TMP_Text Item_collected_text;
    [SerializeField] TMP_Text Timer_text;
    // Start is called before the first frame update

    void Start()
    {
        Transform obj = GameObject.Find("Canvas/Collect_display/Items_collected_Text").transform;
        Item_collected_text = obj.GetComponent<TMP_Text>();

        collector.OnCollect += (int count) => { Item_collected_text.text = count.ToString(); };
        Timer.OnTimerUpdate += (float time) =>
        {
            //Timer_text.GetComponent<TMP_Text>().enabled = true;
            int minutes = (int)time / 60;
            int seconds = (int)time % 60;
            Timer_text.text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
        };
        Timer.OnTimesUp += () => { Timer_text.text = "Time's up!"; };
    }

    // Update is called once per frame
    void Update()
    {

    }
}
