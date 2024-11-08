using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolClasses;
using System;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        private StudentViewModel _studentViewModel;

        public SchoolCitizensViewModel()
        {
            _currentSchoolCitizensChildView = new StudentViewModel();
            _studentViewModel = new StudentViewModel();
        }

        public SchoolCitizensViewModel(StudentViewModel studentViewModel)
        {
            _studentViewModel = studentViewModel;

            _currentSchoolCitizensChildView= new StudentViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolCitizensChildView;

        [RelayCommand]
        public void ShowStudentView()
        {
            CurrentSchoolCitizensChildView = _studentViewModel;
        }

        public static implicit operator SchoolCitizensViewModel(SchoolClassesViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}
