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


}