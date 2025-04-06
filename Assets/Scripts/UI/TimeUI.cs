using System.Threading;
using TMPro;
using UnityEngine;

public class TimeUI : MonoBehaviour
{
    TMP_Text _tmp;

    void Start()
    {
        _tmp = GetComponent<TMP_Text>();
    }

    void Update()
    {
        _tmp.text = GameManager.Instance.timer.SpanMinutes().ToString();
    }
}
