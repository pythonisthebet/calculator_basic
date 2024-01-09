using System.Data;

namespace calculator_basic;

public partial class calculator : ContentPage
{
    public double solution;
	public calculator()
	{
		InitializeComponent();
	}

    private void solve_Clicked(object sender, EventArgs e)
    {
        
        if (display.Text[display.Text.Length - 1] >47)
        {
            try
            {
                solution = solver();
                display.Text = solution.ToString();
            }
            catch (Exception)
            {
                display.Text = "naughty boy/girl/thing";

            }
            
        }


    }

    private void mult_Clicked(object sender, EventArgs e)
    {
        if (display.Text[display.Text.Length-1] > 46)
        {
            display.Text += "*";
        }
        else
        {
            string newtext = display.Text.Substring(0, display.Text.Length - 1) + "*";
            display.Text = newtext;
        }
    }

    private void minus_Clicked(object sender, EventArgs e)
    {
        if (display.Text[display.Text.Length-1] > 46)
        {
            display.Text += "-";
        }
        else
        {
            string newtext = display.Text.Substring(0, display.Text.Length - 1) + "-";
            display.Text = newtext;
        }
    }

    private void plus_Clicked(object sender, EventArgs e)
    {
        if (display.Text[display.Text.Length - 1] > 47)
        {
            display.Text += "+";
        }
        else
        {
            string newtext = display.Text.Substring(0, display.Text.Length - 1) + "+";
            display.Text = newtext;
        }
    }

    private void dev_Clicked(object sender, EventArgs e)
    {
        if (display.Text[display.Text.Length - 1] > 47)
        {
            display.Text += "/";
        }
        else
        {
            string newtext = display.Text.Substring(0, display.Text.Length - 1) + "/";
            display.Text = newtext;
        }
    }
    private void one_Clicked(object sender, EventArgs e)
    {
        display.Text += "1";
    }

    private void two_Clicked(object sender, EventArgs e)
    {
        display.Text += "2";
    }

    private void three_Clicked(object sender, EventArgs e)
    {
        display.Text += "3";
    }

    private void four_Clicked(object sender, EventArgs e)
    {
        display.Text += "4";
    }

    private void five_Clicked(object sender, EventArgs e)
    {
        display.Text += "5";
    }

    private void six_Clicked(object sender, EventArgs e)
    {
        display.Text += "6";
    }

    private void seven_Clicked(object sender, EventArgs e)
    {
        display.Text += "7";
    }

    private void eight_Clicked(object sender, EventArgs e)
    {
        display.Text += "8";
    }

    private void nine_Clicked(object sender, EventArgs e)
    {
        display.Text += "9";
    }

    private void zero_Clicked(object sender, EventArgs e)
    {
        display.Text += "0";
    }

    private double solver()
    {
        if (display.Text == null)
        {
            return 0;
        }

        double answer = 0;
        string text = display.Text;
        DataTable table = new DataTable();
        table.Columns.Add("expression", typeof(string), text);
        DataRow row = table.NewRow();
        table.Rows.Add(row);
        answer = double.Parse((string)row["expression"]);
        return answer;
    }

    private void clear_Clicked(object sender, EventArgs e)
    {
        display.Text = "";
    }
}