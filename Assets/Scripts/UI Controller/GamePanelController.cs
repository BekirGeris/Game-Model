using UnityEngine;
using Snake.Data;

namespace Snake.UIController
{ 
    public class GamePanelController : MonoBehaviour
    {
        [Header("Panels")]
        [SerializeField] private GameObject menuPanel;
        [SerializeField] private GameObject adsPanel;
        [SerializeField] private GameObject endPanel;
        [SerializeField] private GameObject sharePanel;
        [SerializeField] private GameObject gamePanel;

        [Header("Circle Bars")]
        [SerializeField] private GameObject adsCircleBar;
        [SerializeField] private GameObject shareCircleBar;

        [Header("Game Data")]
        [SerializeField] private GameData gameData;

        private void Start()
        {
            openMenuPanel();
        }

        public void openMenuPanel()
        {
            menuPanel.SetActive(true);
            adsPanel.SetActive(false);
            endPanel.SetActive(false);
            sharePanel.SetActive(false);
            gamePanel.SetActive(false);
            stopeGame();
        }
        public void openAdsPanel()
        {
            menuPanel.SetActive(false);
            adsPanel.SetActive(true);
            endPanel.SetActive(false);
            sharePanel.SetActive(false);
            gamePanel.SetActive(false);
            stopeGame();
        }
        public void openEndPanel()
        {
            menuPanel.SetActive(false);
            adsPanel.SetActive(false);
            endPanel.SetActive(true);
            sharePanel.SetActive(false);
            gamePanel.SetActive(false);
            stopeGame();
        }
        public void openSharePanel()
        {
            menuPanel.SetActive(true);
            adsPanel.SetActive(false);
            endPanel.SetActive(false);
            sharePanel.SetActive(true);
            gamePanel.SetActive(false);
        }

        public void closeSharePanel()
        {
            openMenuPanel();
            shareCircleBar.SetActive(false);
        }
        public void openGamePanel()
        {
            menuPanel.SetActive(false);
            adsPanel.SetActive(false);
            endPanel.SetActive(false);
            sharePanel.SetActive(false);
            gamePanel.SetActive(true);
            adsCircleBar.SetActive(false);
            resumeGame();
        }

        public void openAdsCircleBar()
        {
            adsCircleBar.SetActive(true);
        }

        public void openShareCircleBar()
        {
            shareCircleBar.SetActive(true);
        }

        public void closeAdsCircleBar()
        {
            adsCircleBar.SetActive(false);
        }

        public void closeShareCircleBar()
        {
            shareCircleBar.SetActive(false);
        }

        public void stopeGame()
        {
            gameData.GameState = false;
        }

        public void resumeGame()
        {
            gameData.GameState = true;
        }
    }
}