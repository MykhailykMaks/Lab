using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Windows.Input;
using System.Windows.Controls;

namespace Lab_6
{
    public class WorkerApplication
    {
        public string Pip { get; set; } = "";
        public DateTime Birthdate { get; set; } = DateTime.Now;
        public string Education { get; set; } = "Not specified";
        public List<string> Languages { get; set; } = new List<string>();
        public bool IsGoodAtUsingComputer { get; set; }
        public int YearsOfExperience { get; set; }
        public bool HasRecommendations { get; set; }

        [JsonIgnore]
        public ICommand SubmitCommand { get; private set; }

        public WorkerApplication()
        {
            SubmitCommand = new RelayCommand(SubmitData, CanSubmitData);
        }

        [JsonConstructor]
        public WorkerApplication(string pip, DateTime birthdate, string education, List<string> languages, bool isGoodAtUsingComputer, int yearsOfExperience, bool hasRecommendations)
        {
            Pip = pip;
            Birthdate = birthdate;
            Education = education;
            Languages = languages;
            IsGoodAtUsingComputer = isGoodAtUsingComputer;
            YearsOfExperience = yearsOfExperience;
            HasRecommendations = hasRecommendations;
            SubmitCommand = new RelayCommand(SubmitData, CanSubmitData);
        }

        private bool CanSubmitData(object parameter)
        {
            if (parameter is AddWindow window)
            {
                if (string.IsNullOrWhiteSpace(Pip)) return false;
                if (DateTime.Now.Year - Birthdate.Year < 18) return false;
                bool isEdu = (window.RbSchool.IsChecked == true || window.RbBachelor.IsChecked == true || window.RbHigh.IsChecked == true);
                bool isComp = (window.Yes.IsChecked == true || window.No.IsChecked == true);
                bool isRec = (window.Have.IsChecked == true || window.DontHave.IsChecked == true);

                return isEdu && isComp && isRec;
            }
            return false;
        }

        private void SubmitData(object parameter)
        {
            if (parameter is AddWindow window)
            {
                if (window.RbSchool.IsChecked == true) Education = "Середнє";
                else if (window.RbBachelor.IsChecked == true) Education = "Бакалавр";
                else if (window.RbHigh.IsChecked == true) Education = "Магістр";
                else Education = "Не вказано";

                Languages = new List<string>();
                if (window.LanguagesPanel != null)
                {
                    foreach (var child in window.LanguagesPanel.Children)
                    {
                        if (child is CheckBox cb && cb.IsChecked == true && cb.Tag != null)
                        {
                            Languages.Add(cb.Tag.ToString());
                        }
                    }
                }

                IsGoodAtUsingComputer = (window.Yes.IsChecked == true);
                HasRecommendations = (window.Have.IsChecked == true);
                window.DialogResult = true;
                window.Close();
            }
        }
        [JsonIgnore] 
        public string ComputerKnowledge
        {
            get
            {
                return IsGoodAtUsingComputer ? "Впевнений користувач (Yes)" : "Немає навичок (No)";
            }
        }

        [JsonIgnore]
        public string RecommendationsText
        {
            get
            {
                return HasRecommendations ? "Є рекомендації" : "Немає рекомендацій";
            }
        }
    }
}