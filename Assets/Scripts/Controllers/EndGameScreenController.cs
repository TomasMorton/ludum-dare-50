using Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class EndGameScreenController : MonoBehaviour
    {
        [SerializeField] private Text HighscoreBanner;
        [SerializeField] private Text Highscore1;
        [SerializeField] private Text Highscore2;
        [SerializeField] private Text Highscore3;
        [SerializeField] private Text Highscore4;
        [SerializeField] private Text Highscore5;
        [SerializeField] private Text TotalBanner;
        [SerializeField] private Text TotalDodoDeaths;
        [SerializeField] private Text TotalFoodsEaten;
        [SerializeField] private Text TotalObjectsSmashed;
        [SerializeField] private Text TotalBridgesCrossed;
        [SerializeField] private Text TotalBouldersBumped;

        private StatsController _statsController;
        private Canvas _canvas;

        private void Start()
        {
            _canvas = GetComponent<Canvas>();
            hideEndGameScreen();
        }

        public void onGameReset()
        {
            hideEndGameScreen();
        }

        public void onGameEnd()
        {
            _statsController = FindObjectOfType<StatsController>();
            showEndGameScreen();
        }

        public void showEndGameScreen()
        {
            _canvas.enabled = true;
            Highscore1.text = _statsController.FormattedTimes[0];
            Highscore2.text = _statsController.FormattedTimes[1];
            Highscore3.text = _statsController.FormattedTimes[2];
            Highscore4.text = _statsController.FormattedTimes[3];
            Highscore5.text = _statsController.FormattedTimes[4];
            TotalDodoDeaths.text = "Dodo Deaths: " + _statsController.deaths;
            TotalFoodsEaten.text = "Snacks Eaten: " + _statsController.foodsEaten;
            TotalObjectsSmashed.text = "Things Smashed: " + _statsController.objectsSmashed;
            TotalBridgesCrossed.text = "Bridges Crossed: " + _statsController.bridgesCrossed;
            TotalBouldersBumped.text = "Boulders Bumped: " + _statsController.bouldersBumped;
            
        }

        public void hideEndGameScreen()
        {
            _canvas.enabled = false;
        }
    }
}