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
        Debug.Log(guess); // 1000 
        NextGuess();
        Debug.Log(guess); // 1000 
        max = max + 1;
        Debug.Log(guess); // 1001 
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess; //Then we assign max tue guess value
        NextGuess(); // we then invoke and thus updaye next guess' value
    }

    // Update is called once per frame

    // Read documentation: https://docs.unity3d.com/ScriptReference/Input.html
    // Fixed intellisense not working on unity through source: https://forum.unity.com/threads/intellisense-not-working-with-visual-studio-fix.836599/

    void NextGuess()
    {
        //guess = (max + min) / 2; // Uses the max and min we inserted in the Gameplay element within Unity, = 500
        guess = Random.Range(min, max);
        guessText.text = guess.ToString(); // So, here we convert guess of type int to string, and store it in a string var.
    }
}
