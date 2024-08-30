using System;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float time = 0.0f;
    private bool isCounting = false;
    public delegate void TimerDelegate(float time);
    public static event TimerDelegate OnTimerUpdate;

    public static event Action OnTimesUp;

    public void StartCounting(float time)
    {
        this.time = time;
        isCounting = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
                if (time % 1 >= 0.001)
                {
                    OnTimerUpdate?.Invoke(time);
                }
            }
            else
            {
                Debug.Log("Time's up!");
                OnTimesUp?.Invoke();
                isCounting = false;
            }
        }
    }
}
