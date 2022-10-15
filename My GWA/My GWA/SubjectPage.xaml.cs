using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_GWA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubjectPage : ContentPage
    {
        public SubjectPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(inputArea.Text))
            {
                await DisplayAlert("Note:", "Please Enter the number of subjects.", "OK");
            }
            else
            {
                int numberOfSubjects = int.Parse(inputArea.Text);
                if (numberOfSubjects >= 1 && numberOfSubjects <= 12)
                {
                    String totalSub = inputArea.Text.TrimStart(new Char[] { '0', '+', '-' });
                    Application.Current.Properties["Name"] = totalSub;
                    await Navigation.PushAsync(new MainArea());
                }
                if (numberOfSubjects > 12)
                {
                    await DisplayAlert("Error", "Too many Subject", "OK");
                }
                if (numberOfSubjects < 1)
                {
                    await DisplayAlert("Error", "Subject must be more than 1", "OK");
                }
            }
        }

        private void inputArea_Focused(object sender, FocusEventArgs e)
        {
            inputArea.Placeholder = " ";
            inputArea.Unfocus();
        }

        private void inputArea_Unfocused(object sender, FocusEventArgs e)
        {
            
        }
        private void NumberClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            inputArea.Text = inputArea.Text + btn.Text;
        }

        private void ClearBtn_Clicked(object sender, EventArgs e)
        {
            btnZero.IsEnabled = true;
            btnOne.IsEnabled = true;
            btnTwo.IsEnabled = true;
            btnThree.IsEnabled = true;
            btnFour.IsEnabled = true;
            btnFive.IsEnabled = true;
            btnSix.IsEnabled = true;
            btnSeven.IsEnabled = true;
            btnEigth.IsEnabled = true;
            btnNine.IsEnabled = true;
            if (!String.IsNullOrWhiteSpace(inputArea.Text))
            {
                int length = inputArea.Text.Length;
                if (length != 1)
                {
                    inputArea.Text = inputArea.Text.Remove(length - 1);
                }
                else
                {
                    inputArea.Text = "";
                }
            }
            else
            {
                inputArea.Text = "";
            }

        }

        private void inputArea_TextChanged(object sender, TextChangedEventArgs e)
        {
            string[] container = {"2", "3", "4", "5", "6", "7", "8", "9" };

            if (!String.IsNullOrWhiteSpace(inputArea.Text))
            {
                if (inputArea.Text.Contains("1"))
                {
                    btnThree.IsEnabled = false;
                    btnFour.IsEnabled = false;
                    btnFive.IsEnabled = false;
                    btnSix.IsEnabled = false;
                    btnSeven.IsEnabled = false;
                    btnEigth.IsEnabled = false;
                    btnNine.IsEnabled = false;
                }
                if (container.Contains(inputArea.Text))
                {
                    btnZero.IsEnabled = false;
                    btnOne.IsEnabled = false;
                    btnTwo.IsEnabled = false;
                    btnThree.IsEnabled = false;
                    btnFour.IsEnabled = false;
                    btnFive.IsEnabled = false;
                    btnSix.IsEnabled = false;
                    btnSeven.IsEnabled = false;
                    btnEigth.IsEnabled = false;
                    btnNine.IsEnabled = false;
                }
            }else
            {
                return;
            }
            
        }
    }
}