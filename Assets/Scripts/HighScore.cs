using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;

    public Color LatestEntryColor;


    // Start is called before the first frame update
    void Awake()
    {
        entryContainer = transform.Find("Container");
        entryTemplate = entryContainer.Find("Template");

        entryTemplate.gameObject.SetActive(false);

        float templateHeight = 30f;

        int i = 0;
        int latestScoreIndex = SaveScoreScript.GetLatestScoreNumber();
        foreach (SaveScoreScript.Score score in SaveScoreScript.Current.Scores.OrderByDescending(s => s.Value))
        {

            Transform entryTransform = Instantiate(entryTemplate, entryContainer);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            entryTransform.gameObject.SetActive(true);

            int rank = i+1;
            string rankString;
            switch (rank)
            {
                default:
                    rankString = $"{rank}TH";
                    break;
                case 1:
                    rankString = "1ST";
                    break;
                case 2:
                    rankString = "2ND";
                    break;
                case 3:
                    rankString = "3RD";
                    break;
            }

            var entryNumberLabel = entryTransform.Find("Numb").GetComponent<Text>();
            var entryDateLabel = entryTransform.Find("Date").GetComponent<Text>();
            var entryScoreLabel = entryTransform.Find("Score").GetComponent<Text>();



            if (i == latestScoreIndex)
            {
                entryNumberLabel.color = Color.red;
                entryDateLabel.color = Color.red;
                entryScoreLabel.color = Color.red;
            }

            entryNumberLabel.text = rankString;
            entryDateLabel.text = score.Date.ToString("dd.MM.yyyy");
            entryScoreLabel.text = score.Value.ToString();
            i++;
        }
        



    }

    // Update is called once per frame
    void Update()
    {

    }
}
