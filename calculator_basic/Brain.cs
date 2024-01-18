using Android.Views;
using Microsoft.Maui.Controls.PlatformConfiguration.TizenSpecific;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_basic
{
    //class Brain
    //{
    //    private string label ="";

    //    private Microsoft.Maui.Controls.Label Labelpls = calculator_binding.lablebest;

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }

    //    public Command operatorCommand { get; set; }
    //    public Command numberCommand { get; set; }

    //    public Command solveCommand { get; set; }

    //    public Brain() 
    //    {
    //        operatorCommand = new Command<string>((p) => change_lable(p));
    //        solveCommand = new Command<string>((p) => change_lable(solve()), (p) => isnumber());
    //    }

    //    public bool isnumber()
    //    {
    //        if (label == "")
    //        {
    //            return false;
    //        }
    //        if (label[^1] > 47)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }
    //    public void change_lable<T>(T p)
    //    {
    //        if (p is double) 
    //        {
    //            label = p.ToString();
    //        }
    //        else if (p.Equals("a/c"))
    //        {
    //            label = "";
    //        }
    //        else
    //        {
    //            label += p;
    //        }
    //        OnPropertyChanged();
    //    }

    //    private double solve()
    //    {
    //        if (label == null)
    //        {
    //            return 0;
    //        }

    //        double answer = 0;
    //        string text = label;
    //        DataTable table = new DataTable();
    //        table.Columns.Add("expression", typeof(string), text);
    //        DataRow row = table.NewRow();
    //        table.Rows.Add(row);
    //        answer = double.Parse((string)row["expression"]);
    //        return answer;
    //    }
    //}
}
