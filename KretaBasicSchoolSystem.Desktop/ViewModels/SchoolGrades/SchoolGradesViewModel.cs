using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolSubjects;


namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolGrades
{
    public partial class SchoolGradesViewModel : BaseViewModel
    {
        private TeachingViewModel _teachingViewModel;
        private EndingSemester _endingSemester;
        private EndingYearViewModel _endingYearViewModel;
        private CurrentLessonViewModel _currentLessonViewModel;

        public SchoolGradesViewModel()
        {
            _currentSchoolGradesChildView = new TeachingViewModel();
            _currentSchoolGradesChildView = new EndingSemester();
            _currentSchoolGradesChildView = new EndingYearViewModel();
            _currentSchoolGradesChildView = new CurrentLessonViewModel();



            _teachingViewModel = new TeachingViewModel();
            _endingSemester = new EndingSemester();
            _endingYearViewModel = new EndingYearViewModel();
            _currentLessonViewModel = new CurrentLessonViewModel();


        }

        public SchoolGradesViewModel(TeachingViewModel teachingViewModel, EndingSemester endingSemester, EndingYearViewModel endingYearViewModel, CurrentLessonViewModel currentLessonViewModel)
        {
            _teachingViewModel = teachingViewModel;
            _endingSemester = endingSemester;
            _endingYearViewModel = endingYearViewModel;
            _currentLessonViewModel = currentLessonViewModel;


            _currentSchoolGradesChildView = new TeachingViewModel();
            _currentSchoolGradesChildView = new EndingSemester();
            _currentSchoolGradesChildView = new EndingYearViewModel();
            _currentSchoolGradesChildView = new CurrentLessonViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolGradesChildView;


        [RelayCommand]
        public void ShowTeachingView()
        {
            CurrentSchoolGradesChildView = _teachingViewModel;
        }

        [RelayCommand]
        public void ShowEndingSemesterView()
        {
            CurrentSchoolGradesChildView = _endingSemester;
        }

        [RelayCommand]
        public void ShowEndingYear()
        {
            CurrentSchoolGradesChildView = _endingYearViewModel;
        }

        [RelayCommand]
        public void ShowCurrentLessonView() 
        {
            CurrentSchoolGradesChildView = _currentLessonViewModel;
        }


    }
}
