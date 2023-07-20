using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class NovelGame : MonoBehaviour, IPointerClickHandler
{
    public Text storyText;
    private string[] storyLines = {
    "ミナト:「ねえ、リリア、今日新しい量子物理学の理論を見つけたんだ。」",
    "リリア:「量子物理学？それは何ですか？」",
    "ミナト:「うーん、簡単に言うと、我々が住んでいるこの宇宙の、最も基本的なレベルでの振る舞いを説明する学問だよ。」",
    "リリア:「それは私たちの魔法と似ているような...。あなたの世界では、それがすべてのものを結びつけているのですね。」",
    "ミナト:「そうだね。でも、それが全てを説明するわけではない。まだ未解明の部分がたくさんあるんだ。」",
    "リリア:「それは私たちの世界でも同じです。魔法は強力ですが、全てを解決するわけではありません。実は、森の精霊が体調を崩していて、私たちの魔法では治せないんです...」",
    "ミナト:「そうなんだ...。君が使っている魔法の原理を教えてくれたら、科学的な観点から何か手がかりを見つけられるかもしれないよ。」",
    "リリア:「それは素晴らしいアイデアです！私たちの世界とあなたの世界が助け合えるなんて...。」",
    "ミナト:「まさにその通りだよ、リリア。僕たちはこの状況を最大限に利用しよう。それぞれの世界から学ぶことで、新たな視点を見つけられるはずだから。」"
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
