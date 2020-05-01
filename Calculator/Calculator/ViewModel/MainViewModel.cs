using Calculator.Model;

namespace Calculator.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        private readonly Calculats calculates;
        private Command _calcCommand;
        private string result;
        public MainViewModel()
        {
            calculates = new Calculats();
        }

        public double A
        {
            get => calculates.A;
            set
            {
                calculates.A = value;
            }
        }

        public double B
        {
            get => calculates.B;
            set
            {
                calculates.B = value;
            }
        }
        public string Oper
        {
            get => calculates.Operation;
            set
            {
                calculates.Operation = value;
            }
        }

        public string Result
        {
            get => result;
            set
            {
                result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        private void Calculate()
        {
            Result = calculates.Culc().ToString();
        }
        
        public Command CalculateCommand => _calcCommand ?? (_calcCommand = new Command(ExecuteCalcCommand, CanCalcCommand));
        public void ExecuteCalcCommand(object parameter)
        {
            Calculate();
        }

        public bool CanCalcCommand(object parameter) => B != 0;
    }
}