using TMPro;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
        max = max + 1;
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }

    // Update is called once per frame

    // Read documentation: https://docs.unity3d.com/ScriptReference/Input.html
    // Fixed intellisense not working on unity through source: https://forum.unity.com/threads/intellisense-not-working-with-visual-studio-fix.836599/

    void NextGuess()
    {
        guess = (max + min) / 2;
        guessText.text = guess.ToString();
    }
}
