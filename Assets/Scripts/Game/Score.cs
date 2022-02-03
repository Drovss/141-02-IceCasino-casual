using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText; 

    private int _score;

    public UnityEvent <int> SaveScoreEvent;

    private void OnEnable()
    {
        Ice.DestroyEvent += UpScore;
    }

    private void OnDisable()
    {
        Ice.DestroyEvent -= UpScore;
    }

    private void UpScore()
    {
        _score++;
        _scoreText.SetText(_score.ToString());
    }

    public void SaveScore()
    {
        SaveScoreEvent.Invoke(_score);
    }
}
