using System.ComponentModel;
using System.Data;

namespace calculator_basic;

public partial class calculator_binding : ContentPage
{
	public calculator_binding()
	{
        
        InitializeComponent();
        Brain brain = new Brain();
        BindingContext = brain;
    }

    class Brain
    {
        private string label;
        public string Lable
        {
            private set
            {
                if (label != value)
                {
                    label = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entry"));
                }
            }
            get
            {
                return label;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Command operatorCommand { get; set; }

        public Command solveCommand { get; set; }

        public Brain()
        {
            operatorCommand = new Command<string>((p) => change_lable(p));
            solveCommand = new Command<string>((p) => change_lable(solve()), (p) => isnumber());
            label = "";
        }

        public bool isnumber()
        {
            if (label == "")
            {
                return false;
            }
            if (label[^1] > 47)
            {
                return true;
            }
            return false;
        }
        public void change_lable<T>(T p)
        {
            if (p is double)
            {
                label = p.ToString();
            }
            else if (p.Equals("a/c"))
            {
                label = "";
            }
            else
            {
                label += p;
            }
            OnPropertyChanged();
            
        }

        private double solve()
        {
            if (label == null)
            {
                return 0;
            }

            double answer = 0;
            string text = label;
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), text);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            answer = double.Parse((string)row["expression"]);
            return answer;
        }
    }
}