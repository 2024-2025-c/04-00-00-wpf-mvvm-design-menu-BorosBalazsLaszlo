using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects
{
    public partial class SchoolSubjectsViewModel : BaseViewModel
    {
        private SchoolSubjectsViewModel _subjectsViewModel;

        public SchoolSubjectsViewModel()
        {
            _currentSchoolSubjectsChildView = new SchoolSubjectsViewModel();
            _subjectsViewModel = new SchoolSubjectsViewModel();
        }

        public SchoolSubjectsViewModel(SchoolSubjectsViewModel subjectsViewModel)
        {
            _subjectsViewModel = subjectsViewModel;

            _currentSchoolSubjectsChildView = new SchoolSubjectsViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolSubjectsChildView;

        [RelayCommand]
        public void ShowSubjectView()
        {
            CurrentSchoolSubjectsChildView = _subjectsViewModel;
        }
    }
}
