using UnityEngine;
using UnityEngine.UI;

public class ClickerController : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    private int _score;
    private int _powerScore;

    private void Start()
    {
        _score = PlayerPrefs.GetInt("Score");
        if (_powerScore < 1)
        {
            _powerScore = 1;
        }
    }
    private void FixedUpdate()
    {
        _scoreText.text = "" + _score;
    }
    public void Clicking()
    {
        _score += _powerScore;
        PlayerPrefs.SetInt("Score", _score);
    }
    public void RessetScore()
    {
        PlayerPrefs.DeleteAll();
        _score = PlayerPrefs.GetInt("Score");
    }
}
