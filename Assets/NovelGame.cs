using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NovelGame : MonoBehaviour, IPointerClickHandler
{
    public Text storyText;
    private string[] storyLines = {
        "最初のセリフ",
        "二つ目のセリフ",
        "最後のセリフ"
    };
    private int currentLine = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateText();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        AdvanceStory();
    }

    private void UpdateText()
    {
        storyText.text = storyLines[currentLine];
    }

    private void AdvanceStory()
    {
        currentLine++;
        if (currentLine >= storyLines.Length)
        {
            Debug.Log("ストーリーが終了しました");
        }
        else
        {
            UpdateText();
        }
    }
}
