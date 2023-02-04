using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BountyHunter
{
    public sealed class ShelterWindowView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _moneyLabel;
        [SerializeField] private Button _testButton;
        [SerializeField] private Button _menuButton;
        
        private Progress _progress;
        
        public event Action MenuClicked;

        public void ShowWindow(Progress progress)
        {
            _progress = progress;
            UpdateFields();
            AddListeners();
            
            gameObject.SetActive(true);
            
        }

        private void AddListeners()
        {
            _testButton.onClick.AddListener(OnTestClick);
            _menuButton.onClick.AddListener(OnMenuClick);
        }

        private void OnMenuClick()
        {
            MenuClicked?.Invoke();
        }

        private void UpdateFields()
        {
            _moneyLabel.text = _progress.Money.ToString();
        }

        private void OnTestClick()
        {
            _progress.Money++;
            UpdateFields();
        }

        public void HideWindow()
        {
            gameObject.SetActive(false);
            _testButton.onClick.RemoveListener(OnTestClick);
        }
    }
}