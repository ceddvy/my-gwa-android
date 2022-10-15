using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_GWA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainArea : ContentPage
    {
        public MainArea()
        {
            InitializeComponent();
            string value = $"{Application.Current.Properties["Name"].ToString()}";

            lblSubjects.Text = $"You have " + value + " subjects";
            isVisibleOrNot();
            DateTime dateTime = DateTime.Now;
            string year = dateTime.Year.ToString();
            copyWrite.Text = "© "+year+" BSC Tech";

        }

        public void isVisibleOrNot()
        {
            string value = $"{Application.Current.Properties["Name"].ToString()}";
            int Value = int.Parse(value);
            if (Value == 1){
                Row2.IsVisible = false; Row8.IsVisible = false;
                Row3.IsVisible = false; Row9.IsVisible = false;
                Row4.IsVisible = false; Row10.IsVisible = false;
                Row5.IsVisible = false; Row11.IsVisible = false;
                Row6.IsVisible = false; Row12.IsVisible = false;
                Row7.IsVisible = false;                                                                     
            }
            if (Value == 2){
                Row3.IsVisible = false; Row8.IsVisible = false;
                Row4.IsVisible = false; Row9.IsVisible = false;
                Row5.IsVisible = false; Row10.IsVisible = false;
                Row6.IsVisible = false; Row11.IsVisible = false;
                Row7.IsVisible = false; Row12.IsVisible = false;
            }
            if (Value == 3){
                Row4.IsVisible = false; Row9.IsVisible = false;
                Row5.IsVisible = false; Row10.IsVisible = false;
                Row6.IsVisible = false; Row11.IsVisible = false;
                Row7.IsVisible = false; Row12.IsVisible = false;
                Row8.IsVisible = false;                                                      
            }
            if (Value == 4){
                Row5.IsVisible = false; Row9.IsVisible = false;
                Row6.IsVisible = false; Row10.IsVisible = false;
                Row7.IsVisible = false; Row11.IsVisible = false;
                Row8.IsVisible = false; Row12.IsVisible = false;
            }
            if (Value == 5){ 
                Row6.IsVisible = false; Row10.IsVisible = false;
                Row7.IsVisible = false; Row11.IsVisible = false;
                Row8.IsVisible = false; Row12.IsVisible = false;
                Row9.IsVisible = false;                                            
            }if (Value == 6){
                Row7.IsVisible = false; Row10.IsVisible = false;
                Row8.IsVisible = false; Row11.IsVisible = false;
                Row9.IsVisible = false; Row12.IsVisible = false;
            }if (Value == 7){
                Row8.IsVisible = false; Row11.IsVisible = false;
                Row9.IsVisible = false; Row12.IsVisible = false;
                Row10.IsVisible = false;                               
            }
            if (Value == 8){
                Row9.IsVisible = false; Row11.IsVisible = false;
                Row10.IsVisible = false; Row12.IsVisible = false;
            }
            if (Value == 9){
                Row10.IsVisible = false; Row12.IsVisible = false;
                Row11.IsVisible = false;               
            }
            if (Value == 10){
                Row11.IsVisible = false; Row12.IsVisible = false;
            }
            if (Value == 11){
                Row12.IsVisible = false;
            }
            if (Value == 12){
            }
        }
        async void callThis2()
        {
            await DisplayAlert("Note:", "Fields must not be empty.", "OK");
        }

        async void resultsGwa(double[] subjectGrades,double[] subjectUnit)
        {
            int numberOfSubjects = subjectGrades.Length;
            string results;         
            
            double[] equals = new double[numberOfSubjects];
            double totalSub = 0;
            double totalUnit = 0;
            double gwa = 0;          
           
            for (int i = 0; i < numberOfSubjects; i++)
            {
                equals[i] = subjectGrades[i] * subjectUnit[i];
                totalUnit = totalUnit + subjectUnit[i];
                totalSub = totalSub + equals[i];
                gwa = totalSub / totalUnit;
            }

            results = String.Format("{0:0.00}", gwa);
            await DisplayAlert("Congratulations", "Your General Weighted Average: " + results, "OK");
        }
        public void resultShow()
        {
            string value = $"{Application.Current.Properties["Name"].ToString()}";
            int Value = int.Parse(value);
            int numberOfSubjects = Value;

            double[] subjectGrades = new double[numberOfSubjects];
            double[] subjectUnit = new double[numberOfSubjects];       
            
            if (Value == 1){
                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
            if (Value == 2){
                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);
                subjectGrades[1] = double.Parse(subject2.Text); subjectUnit[1] = double.Parse(unit2.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
            if (Value == 3) {
                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);
                subjectGrades[1] = double.Parse(subject2.Text); subjectUnit[1] = double.Parse(unit2.Text);
                subjectGrades[2] = double.Parse(subject3.Text); subjectUnit[2] = double.Parse(unit3.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
            if (Value == 3){
                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);
                subjectGrades[1] = double.Parse(subject2.Text); subjectUnit[1] = double.Parse(unit2.Text);
                subjectGrades[2] = double.Parse(subject3.Text); subjectUnit[2] = double.Parse(unit3.Text);
                subjectGrades[3] = double.Parse(subject4.Text); subjectUnit[3] = double.Parse(unit4.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
            if (Value == 4){
                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);
                subjectGrades[1] = double.Parse(subject2.Text); subjectUnit[1] = double.Parse(unit2.Text);
                subjectGrades[2] = double.Parse(subject3.Text); subjectUnit[2] = double.Parse(unit3.Text);
                subjectGrades[3] = double.Parse(subject4.Text); subjectUnit[3] = double.Parse(unit4.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
            if (Value == 5){

                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);
                subjectGrades[1] = double.Parse(subject2.Text); subjectUnit[1] = double.Parse(unit2.Text);
                subjectGrades[2] = double.Parse(subject3.Text); subjectUnit[2] = double.Parse(unit3.Text);
                subjectGrades[3] = double.Parse(subject4.Text); subjectUnit[3] = double.Parse(unit4.Text);
                subjectGrades[4] = double.Parse(subject5.Text); subjectUnit[4] = double.Parse(unit5.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
            if (Value == 6){
                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);
                subjectGrades[1] = double.Parse(subject2.Text); subjectUnit[1] = double.Parse(unit2.Text);
                subjectGrades[2] = double.Parse(subject3.Text); subjectUnit[2] = double.Parse(unit3.Text);
                subjectGrades[3] = double.Parse(subject4.Text); subjectUnit[3] = double.Parse(unit4.Text);
                subjectGrades[4] = double.Parse(subject5.Text); subjectUnit[4] = double.Parse(unit5.Text);
                subjectGrades[5] = double.Parse(subject6.Text); subjectUnit[5] = double.Parse(unit6.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
            if (Value == 7){
                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);
                subjectGrades[1] = double.Parse(subject2.Text); subjectUnit[1] = double.Parse(unit2.Text);
                subjectGrades[2] = double.Parse(subject3.Text); subjectUnit[2] = double.Parse(unit3.Text);
                subjectGrades[3] = double.Parse(subject4.Text); subjectUnit[3] = double.Parse(unit4.Text);
                subjectGrades[4] = double.Parse(subject5.Text); subjectUnit[4] = double.Parse(unit5.Text);
                subjectGrades[5] = double.Parse(subject6.Text); subjectUnit[5] = double.Parse(unit6.Text);
                subjectGrades[6] = double.Parse(subject7.Text); subjectUnit[6] = double.Parse(unit7.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
            if (Value == 8){
                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);
                subjectGrades[1] = double.Parse(subject2.Text); subjectUnit[1] = double.Parse(unit2.Text);
                subjectGrades[2] = double.Parse(subject3.Text); subjectUnit[2] = double.Parse(unit3.Text);
                subjectGrades[3] = double.Parse(subject4.Text); subjectUnit[3] = double.Parse(unit4.Text);
                subjectGrades[4] = double.Parse(subject5.Text); subjectUnit[4] = double.Parse(unit5.Text);
                subjectGrades[5] = double.Parse(subject6.Text); subjectUnit[5] = double.Parse(unit6.Text);
                subjectGrades[6] = double.Parse(subject7.Text); subjectUnit[6] = double.Parse(unit7.Text);
                subjectGrades[7] = double.Parse(subject8.Text); subjectUnit[7] = double.Parse(unit8.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
            if (Value == 9){
                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);
                subjectGrades[1] = double.Parse(subject2.Text); subjectUnit[1] = double.Parse(unit2.Text);
                subjectGrades[2] = double.Parse(subject3.Text); subjectUnit[2] = double.Parse(unit3.Text);
                subjectGrades[3] = double.Parse(subject4.Text); subjectUnit[3] = double.Parse(unit4.Text);
                subjectGrades[4] = double.Parse(subject5.Text); subjectUnit[4] = double.Parse(unit5.Text);
                subjectGrades[5] = double.Parse(subject6.Text); subjectUnit[5] = double.Parse(unit6.Text);
                subjectGrades[6] = double.Parse(subject7.Text); subjectUnit[6] = double.Parse(unit7.Text);
                subjectGrades[7] = double.Parse(subject8.Text); subjectUnit[7] = double.Parse(unit8.Text);
                subjectGrades[8] = double.Parse(subject9.Text); subjectUnit[8] = double.Parse(unit9.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
            if (Value == 10) {
                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);
                subjectGrades[1] = double.Parse(subject2.Text); subjectUnit[1] = double.Parse(unit2.Text);
                subjectGrades[2] = double.Parse(subject3.Text); subjectUnit[2] = double.Parse(unit3.Text);
                subjectGrades[3] = double.Parse(subject4.Text); subjectUnit[3] = double.Parse(unit4.Text);
                subjectGrades[4] = double.Parse(subject5.Text); subjectUnit[4] = double.Parse(unit5.Text);
                subjectGrades[5] = double.Parse(subject6.Text); subjectUnit[5] = double.Parse(unit6.Text);
                subjectGrades[6] = double.Parse(subject7.Text); subjectUnit[6] = double.Parse(unit7.Text);
                subjectGrades[7] = double.Parse(subject8.Text); subjectUnit[7] = double.Parse(unit8.Text);
                subjectGrades[8] = double.Parse(subject9.Text); subjectUnit[8] = double.Parse(unit9.Text);
                subjectGrades[9] = double.Parse(subject10.Text); subjectUnit[9] = double.Parse(unit10.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
            if (Value == 11){
                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);
                subjectGrades[1] = double.Parse(subject2.Text); subjectUnit[1] = double.Parse(unit2.Text);
                subjectGrades[2] = double.Parse(subject3.Text); subjectUnit[2] = double.Parse(unit3.Text);
                subjectGrades[3] = double.Parse(subject4.Text); subjectUnit[3] = double.Parse(unit4.Text);
                subjectGrades[4] = double.Parse(subject5.Text); subjectUnit[4] = double.Parse(unit5.Text);
                subjectGrades[5] = double.Parse(subject6.Text); subjectUnit[5] = double.Parse(unit6.Text);
                subjectGrades[6] = double.Parse(subject7.Text); subjectUnit[6] = double.Parse(unit7.Text);
                subjectGrades[7] = double.Parse(subject8.Text); subjectUnit[7] = double.Parse(unit8.Text);
                subjectGrades[8] = double.Parse(subject9.Text); subjectUnit[8] = double.Parse(unit9.Text);
                subjectGrades[9] = double.Parse(subject10.Text); subjectUnit[9] = double.Parse(unit10.Text);
                subjectGrades[10] = double.Parse(subject11.Text); subjectUnit[10] = double.Parse(unit11.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
            if (Value == 12){
                subjectGrades[0] = double.Parse(subject1.Text); subjectUnit[0] = double.Parse(unit1.Text);
                subjectGrades[1] = double.Parse(subject2.Text); subjectUnit[1] = double.Parse(unit2.Text);
                subjectGrades[2] = double.Parse(subject3.Text); subjectUnit[2] = double.Parse(unit3.Text);
                subjectGrades[3] = double.Parse(subject4.Text); subjectUnit[3] = double.Parse(unit4.Text);
                subjectGrades[4] = double.Parse(subject5.Text); subjectUnit[4] = double.Parse(unit5.Text);
                subjectGrades[5] = double.Parse(subject6.Text); subjectUnit[5] = double.Parse(unit6.Text);
                subjectGrades[6] = double.Parse(subject7.Text); subjectUnit[6] = double.Parse(unit7.Text);
                subjectGrades[7] = double.Parse(subject8.Text); subjectUnit[7] = double.Parse(unit8.Text);
                subjectGrades[8] = double.Parse(subject9.Text); subjectUnit[8] = double.Parse(unit9.Text);
                subjectGrades[9] = double.Parse(subject10.Text); subjectUnit[9] = double.Parse(unit10.Text);
                subjectGrades[10] = double.Parse(subject11.Text); subjectUnit[10] = double.Parse(unit11.Text);
                subjectGrades[11] = double.Parse(subject12.Text); subjectUnit[11] = double.Parse(unit12.Text);

                resultsGwa(subjectGrades, subjectUnit);
            }
        }

        public bool checkIfHigh()
        {
            bool isEmpty = false;
            string value = $"{Application.Current.Properties["Name"].ToString()}";
            int Value = int.Parse(value);
            if (Value == 1)
            {
                if (double.Parse(subject1.Text) > subjectLimit || double.Parse(unit1.Text) > unitLimit){
                    isEmpty = true;
                    callThis();
                }
            }
            if (Value == 2)
            {
                if (double.Parse(subject1.Text) > subjectLimit || double.Parse(subject2.Text) > subjectLimit ||
                    double.Parse(unit1.Text) > unitLimit || double.Parse(unit2.Text) > unitLimit) {
                    isEmpty = true;
                    callThis();
                }
            }
            if (Value == 3)
            {
                if (double.Parse(subject1.Text) > subjectLimit || double.Parse(subject2.Text) > subjectLimit || double.Parse(subject3.Text) > subjectLimit ||
                        double.Parse(unit1.Text) > unitLimit || double.Parse(unit2.Text) > unitLimit || double.Parse(unit3.Text) > unitLimit){
                    isEmpty = true;
                    callThis();
                }
            }
            if (Value == 4)
            {
                if (double.Parse(subject1.Text) > subjectLimit || double.Parse(subject2.Text) > subjectLimit || double.Parse(subject3.Text) > subjectLimit ||
                    double.Parse(subject4.Text) > subjectLimit ||
                    double.Parse(unit1.Text) > unitLimit || double.Parse(unit2.Text) > unitLimit || double.Parse(unit3.Text) > unitLimit ||
                    double.Parse(unit4.Text) > unitLimit){
                    isEmpty = true;
                    callThis();
                }
            }
            if (Value == 5)
            {
                if (double.Parse(subject1.Text) > subjectLimit || double.Parse(subject2.Text) > subjectLimit || double.Parse(subject3.Text) > subjectLimit ||
                    double.Parse(subject4.Text) > subjectLimit || double.Parse(subject5.Text) > subjectLimit ||
                    double.Parse(unit1.Text) > unitLimit || double.Parse(unit2.Text) > unitLimit || double.Parse(unit3.Text) > unitLimit ||
                    double.Parse(unit4.Text) > unitLimit || double.Parse(unit5.Text) > unitLimit){
                    isEmpty = true;
                    callThis();
                }
            }
            if (Value == 6)
            {
                if (double.Parse(subject1.Text) > subjectLimit || double.Parse(subject2.Text) > subjectLimit || double.Parse(subject3.Text) > subjectLimit ||
                    double.Parse(subject4.Text) > subjectLimit || double.Parse(subject5.Text) > subjectLimit || double.Parse(subject6.Text) > subjectLimit ||
                    double.Parse(unit1.Text) > unitLimit || double.Parse(unit2.Text) > unitLimit || double.Parse(unit3.Text) > unitLimit ||
                    double.Parse(unit4.Text) > unitLimit || double.Parse(unit5.Text) > unitLimit || double.Parse(unit6.Text) > unitLimit){
                    isEmpty = true;
                    callThis();
                }
            }
            if (Value == 7)
            {
                if (double.Parse(subject1.Text) > subjectLimit || double.Parse(subject2.Text) > subjectLimit || double.Parse(subject3.Text) > subjectLimit ||
                    double.Parse(subject4.Text) > subjectLimit || double.Parse(subject5.Text) > subjectLimit || double.Parse(subject6.Text) > subjectLimit ||
                    double.Parse(subject7.Text) > subjectLimit ||
                    double.Parse(unit1.Text) > unitLimit || double.Parse(unit2.Text) > unitLimit || double.Parse(unit3.Text) > unitLimit ||
                    double.Parse(unit4.Text) > unitLimit || double.Parse(unit5.Text) > unitLimit || double.Parse(unit6.Text) > unitLimit ||
                    double.Parse(unit7.Text) > unitLimit){
                    isEmpty = true;
                    callThis();
                }
            }
            if (Value == 8)
            {
                if (double.Parse(subject1.Text) > subjectLimit || double.Parse(subject2.Text) > subjectLimit || double.Parse(subject3.Text) > subjectLimit ||
                    double.Parse(subject4.Text) > subjectLimit || double.Parse(subject5.Text) > subjectLimit || double.Parse(subject6.Text) > subjectLimit ||
                    double.Parse(subject7.Text) > subjectLimit || double.Parse(subject8.Text) > subjectLimit ||
                    double.Parse(unit1.Text) > unitLimit || double.Parse(unit2.Text) > unitLimit || double.Parse(unit3.Text) > unitLimit ||
                    double.Parse(unit4.Text) > unitLimit || double.Parse(unit5.Text) > unitLimit || double.Parse(unit6.Text) > unitLimit ||
                    double.Parse(unit7.Text) > unitLimit || double.Parse(unit8.Text) > unitLimit){
                    isEmpty = true;
                    callThis();
                }
            }
            if (Value == 9)
            {
                if (double.Parse(subject1.Text) > subjectLimit || double.Parse(subject2.Text) > subjectLimit || double.Parse(subject3.Text) > subjectLimit ||
                    double.Parse(subject4.Text) > subjectLimit || double.Parse(subject5.Text) > subjectLimit || double.Parse(subject6.Text) > subjectLimit ||
                    double.Parse(subject7.Text) > subjectLimit || double.Parse(subject8.Text) > subjectLimit || double.Parse(subject9.Text) > subjectLimit ||
                    double.Parse(unit1.Text) > unitLimit || double.Parse(unit2.Text) > unitLimit || double.Parse(unit3.Text) > unitLimit ||
                    double.Parse(unit4.Text) > unitLimit || double.Parse(unit5.Text) > unitLimit || double.Parse(unit6.Text) > unitLimit ||
                    double.Parse(unit7.Text) > unitLimit || double.Parse(unit8.Text) > unitLimit || double.Parse(unit9.Text) > unitLimit){
                    isEmpty = true;
                    callThis();
                }
            }
            if (Value == 10)
            {
                if (double.Parse(subject1.Text) > subjectLimit || double.Parse(subject2.Text) > subjectLimit || double.Parse(subject3.Text) > subjectLimit ||
                    double.Parse(subject4.Text) > subjectLimit || double.Parse(subject5.Text) > subjectLimit || double.Parse(subject6.Text) > subjectLimit ||
                    double.Parse(subject7.Text) > subjectLimit || double.Parse(subject8.Text) > subjectLimit || double.Parse(subject9.Text) > subjectLimit ||
                    double.Parse(subject10.Text) > subjectLimit ||
                    double.Parse(unit1.Text) > unitLimit || double.Parse(unit2.Text) > unitLimit || double.Parse(unit3.Text) > unitLimit ||
                    double.Parse(unit4.Text) > unitLimit || double.Parse(unit5.Text) > unitLimit || double.Parse(unit6.Text) > unitLimit ||
                    double.Parse(unit7.Text) > unitLimit || double.Parse(unit8.Text) > unitLimit || double.Parse(unit9.Text) > unitLimit ||
                    double.Parse(unit10.Text) > unitLimit){
                    isEmpty = true;
                    callThis();
                }
            }
            if (Value == 11)
            {
                if (double.Parse(subject1.Text) > subjectLimit || double.Parse(subject2.Text) > subjectLimit || double.Parse(subject3.Text) > subjectLimit ||
                    double.Parse(subject4.Text) > subjectLimit || double.Parse(subject5.Text) > subjectLimit || double.Parse(subject6.Text) > subjectLimit ||
                    double.Parse(subject7.Text) > subjectLimit || double.Parse(subject8.Text) > subjectLimit || double.Parse(subject9.Text) > subjectLimit ||
                    double.Parse(subject10.Text) > subjectLimit || double.Parse(subject11.Text) > subjectLimit ||
                    double.Parse(unit1.Text) > unitLimit || double.Parse(unit2.Text) > unitLimit || double.Parse(unit3.Text) > unitLimit ||
                    double.Parse(unit4.Text) > unitLimit || double.Parse(unit5.Text) > unitLimit || double.Parse(unit6.Text) > unitLimit ||
                    double.Parse(unit7.Text) > unitLimit || double.Parse(unit8.Text) > unitLimit || double.Parse(unit9.Text) > unitLimit ||
                    double.Parse(unit10.Text) > unitLimit || double.Parse(unit11.Text) > unitLimit){
                    isEmpty = true;
                    callThis();
                }
            }
            if (Value == 12)
            {
                if (double.Parse(subject1.Text) > subjectLimit || double.Parse(subject2.Text) > subjectLimit || double.Parse(subject3.Text) > subjectLimit ||
                    double.Parse(subject4.Text) > subjectLimit || double.Parse(subject5.Text) > subjectLimit || double.Parse(subject6.Text) > subjectLimit ||
                    double.Parse(subject7.Text) > subjectLimit || double.Parse(subject8.Text) > subjectLimit || double.Parse(subject9.Text) > subjectLimit ||
                    double.Parse(subject10.Text) > subjectLimit || double.Parse(subject11.Text) > subjectLimit || double.Parse(subject12.Text) > subjectLimit ||
                    double.Parse(unit1.Text) > unitLimit || double.Parse(unit2.Text) > unitLimit || double.Parse(unit3.Text) > unitLimit ||
                    double.Parse(unit4.Text) > unitLimit || double.Parse(unit5.Text) > unitLimit || double.Parse(unit6.Text) > unitLimit ||
                    double.Parse(unit7.Text) > unitLimit || double.Parse(unit8.Text) > unitLimit || double.Parse(unit9.Text) > unitLimit ||
                    double.Parse(unit10.Text) > unitLimit || double.Parse(unit11.Text) > unitLimit || double.Parse(unit12.Text) > unitLimit){
                    isEmpty = true;
                    callThis();
                }
            }
            return isEmpty;
        }
        public bool checkComponents()
        {
            bool isEmpty = false;
            string value = $"{Application.Current.Properties["Name"].ToString()}";
            int Value = int.Parse(value);
            if (Value == 1)
            {
                if (String.IsNullOrWhiteSpace(subject1.Text) || String.IsNullOrWhiteSpace(unit1.Text)){
                    isEmpty = true;
                    callThis2();
                }
            }
            if (Value == 2)
            {
                if (String.IsNullOrWhiteSpace(subject1.Text) || String.IsNullOrWhiteSpace(subject2.Text) ||
                     String.IsNullOrWhiteSpace(unit1.Text) || String.IsNullOrWhiteSpace(unit2.Text)){
                    isEmpty = true;
                    callThis2();
                }
            }
            if (Value == 3)
            {
                if (String.IsNullOrWhiteSpace(subject1.Text) || String.IsNullOrWhiteSpace(subject2.Text) || String.IsNullOrWhiteSpace(subject3.Text) ||
                     String.IsNullOrWhiteSpace(unit1.Text) || String.IsNullOrWhiteSpace(unit2.Text) || String.IsNullOrWhiteSpace(unit3.Text)){
                    isEmpty = true;
                    callThis2();
                }
            }
            if (Value == 4)
            {
                if (String.IsNullOrWhiteSpace(subject1.Text) || String.IsNullOrWhiteSpace(subject2.Text) || String.IsNullOrWhiteSpace(subject3.Text) ||
                    String.IsNullOrWhiteSpace(subject4.Text) ||
                    String.IsNullOrWhiteSpace(unit1.Text) || String.IsNullOrWhiteSpace(unit2.Text) || String.IsNullOrWhiteSpace(unit3.Text) ||
                    String.IsNullOrWhiteSpace(unit4.Text)){
                    isEmpty = true;
                    callThis2();
                }
            }
            if (Value == 5)
            {
                if (String.IsNullOrWhiteSpace(subject1.Text) || String.IsNullOrWhiteSpace(subject2.Text) || String.IsNullOrWhiteSpace(subject3.Text) ||
                    String.IsNullOrWhiteSpace(subject4.Text) || String.IsNullOrWhiteSpace(subject5.Text) ||
                    String.IsNullOrWhiteSpace(unit1.Text) || String.IsNullOrWhiteSpace(unit2.Text) || String.IsNullOrWhiteSpace(unit3.Text) ||
                    String.IsNullOrWhiteSpace(unit4.Text) || String.IsNullOrWhiteSpace(unit5.Text)){
                    isEmpty = true;
                    callThis2();
                }

            }
            if (Value == 6)
            {
                if (String.IsNullOrWhiteSpace(subject1.Text) || String.IsNullOrWhiteSpace(subject2.Text) || String.IsNullOrWhiteSpace(subject3.Text) ||
                     String.IsNullOrWhiteSpace(subject4.Text) || String.IsNullOrWhiteSpace(subject5.Text) || String.IsNullOrWhiteSpace(subject6.Text) ||
                     String.IsNullOrWhiteSpace(unit1.Text) || String.IsNullOrWhiteSpace(unit2.Text) || String.IsNullOrWhiteSpace(unit3.Text) ||
                     String.IsNullOrWhiteSpace(unit4.Text) || String.IsNullOrWhiteSpace(unit5.Text) || String.IsNullOrWhiteSpace(unit6.Text)){
                    isEmpty = true;
                    callThis2();
                }
            }
            if (Value == 7)
            {
                if (String.IsNullOrWhiteSpace(subject1.Text) || String.IsNullOrWhiteSpace(subject2.Text) || String.IsNullOrWhiteSpace(subject3.Text) ||
                    String.IsNullOrWhiteSpace(subject4.Text) || String.IsNullOrWhiteSpace(subject5.Text) || String.IsNullOrWhiteSpace(subject6.Text) ||
                    String.IsNullOrWhiteSpace(subject7.Text) ||
                    String.IsNullOrWhiteSpace(unit1.Text) || String.IsNullOrWhiteSpace(unit2.Text) || String.IsNullOrWhiteSpace(unit3.Text) ||
                    String.IsNullOrWhiteSpace(unit4.Text) || String.IsNullOrWhiteSpace(unit5.Text) || String.IsNullOrWhiteSpace(unit6.Text) ||
                    String.IsNullOrWhiteSpace(unit7.Text)){
                    isEmpty = true;
                    callThis2();
                }
            }
            if (Value == 8)
            {
                if (String.IsNullOrWhiteSpace(subject1.Text) || String.IsNullOrWhiteSpace(subject2.Text) || String.IsNullOrWhiteSpace(subject3.Text) ||
                    String.IsNullOrWhiteSpace(subject4.Text) || String.IsNullOrWhiteSpace(subject5.Text) || String.IsNullOrWhiteSpace(subject6.Text) ||
                    String.IsNullOrWhiteSpace(subject7.Text) || String.IsNullOrWhiteSpace(subject8.Text) ||
                    String.IsNullOrWhiteSpace(unit1.Text) || String.IsNullOrWhiteSpace(unit2.Text) || String.IsNullOrWhiteSpace(unit3.Text) ||
                    String.IsNullOrWhiteSpace(unit4.Text) || String.IsNullOrWhiteSpace(unit5.Text) || String.IsNullOrWhiteSpace(unit6.Text) ||
                    String.IsNullOrWhiteSpace(unit7.Text) || String.IsNullOrWhiteSpace(unit8.Text)){
                    isEmpty = true;
                    callThis2();
                }
            }
            if (Value == 9)
            {
                if (String.IsNullOrWhiteSpace(subject1.Text) || String.IsNullOrWhiteSpace(subject2.Text) || String.IsNullOrWhiteSpace(subject3.Text) ||
                    String.IsNullOrWhiteSpace(subject4.Text) || String.IsNullOrWhiteSpace(subject5.Text) || String.IsNullOrWhiteSpace(subject6.Text) ||
                    String.IsNullOrWhiteSpace(subject7.Text) || String.IsNullOrWhiteSpace(subject8.Text) || String.IsNullOrWhiteSpace(subject9.Text) ||
                    String.IsNullOrWhiteSpace(unit1.Text) || String.IsNullOrWhiteSpace(unit2.Text) || String.IsNullOrWhiteSpace(unit3.Text) ||
                    String.IsNullOrWhiteSpace(unit4.Text) || String.IsNullOrWhiteSpace(unit5.Text) || String.IsNullOrWhiteSpace(unit6.Text) ||
                    String.IsNullOrWhiteSpace(unit7.Text) || String.IsNullOrWhiteSpace(unit8.Text) || String.IsNullOrWhiteSpace(unit9.Text)){
                    isEmpty = true;
                    callThis2();
                }
            }
            if (Value == 10)
            {
                if (String.IsNullOrWhiteSpace(subject1.Text) || String.IsNullOrWhiteSpace(subject2.Text) || String.IsNullOrWhiteSpace(subject3.Text) ||
                    String.IsNullOrWhiteSpace(subject4.Text) || String.IsNullOrWhiteSpace(subject5.Text) || String.IsNullOrWhiteSpace(subject6.Text) ||
                    String.IsNullOrWhiteSpace(subject7.Text) || String.IsNullOrWhiteSpace(subject8.Text) || String.IsNullOrWhiteSpace(subject9.Text) ||
                    String.IsNullOrWhiteSpace(subject10.Text) ||
                    String.IsNullOrWhiteSpace(unit1.Text) || String.IsNullOrWhiteSpace(unit2.Text) || String.IsNullOrWhiteSpace(unit3.Text) ||
                    String.IsNullOrWhiteSpace(unit4.Text) || String.IsNullOrWhiteSpace(unit5.Text) || String.IsNullOrWhiteSpace(unit6.Text) ||
                    String.IsNullOrWhiteSpace(unit7.Text) || String.IsNullOrWhiteSpace(unit8.Text) || String.IsNullOrWhiteSpace(unit9.Text) ||
                    String.IsNullOrWhiteSpace(unit10.Text)){
                    isEmpty = true;
                    callThis2();
                }
            }
            if (Value == 11)
            {
                if (String.IsNullOrWhiteSpace(subject1.Text) || String.IsNullOrWhiteSpace(subject2.Text) || String.IsNullOrWhiteSpace(subject3.Text) ||
                     String.IsNullOrWhiteSpace(subject4.Text) || String.IsNullOrWhiteSpace(subject5.Text) || String.IsNullOrWhiteSpace(subject6.Text) ||
                     String.IsNullOrWhiteSpace(subject7.Text) || String.IsNullOrWhiteSpace(subject8.Text) || String.IsNullOrWhiteSpace(subject9.Text) ||
                     String.IsNullOrWhiteSpace(subject10.Text) || String.IsNullOrWhiteSpace(subject11.Text) ||
                     String.IsNullOrWhiteSpace(unit1.Text) || String.IsNullOrWhiteSpace(unit2.Text) || String.IsNullOrWhiteSpace(unit3.Text) ||
                     String.IsNullOrWhiteSpace(unit4.Text) || String.IsNullOrWhiteSpace(unit5.Text) || String.IsNullOrWhiteSpace(unit6.Text) ||
                     String.IsNullOrWhiteSpace(unit7.Text) || String.IsNullOrWhiteSpace(unit8.Text) || String.IsNullOrWhiteSpace(unit9.Text) ||
                     String.IsNullOrWhiteSpace(unit10.Text) || String.IsNullOrWhiteSpace(unit11.Text)){
                    isEmpty = true;
                    callThis2();
                }
            }
            if (Value == 12)
            {
                if (String.IsNullOrWhiteSpace(subject1.Text) || String.IsNullOrWhiteSpace(subject2.Text) || String.IsNullOrWhiteSpace(subject3.Text) ||
                    String.IsNullOrWhiteSpace(subject4.Text) || String.IsNullOrWhiteSpace(subject5.Text) || String.IsNullOrWhiteSpace(subject6.Text) ||
                    String.IsNullOrWhiteSpace(subject7.Text) || String.IsNullOrWhiteSpace(subject8.Text) || String.IsNullOrWhiteSpace(subject9.Text) ||
                    String.IsNullOrWhiteSpace(subject10.Text) || String.IsNullOrWhiteSpace(subject11.Text) || String.IsNullOrWhiteSpace(subject12.Text) ||
                    String.IsNullOrWhiteSpace(unit1.Text) || String.IsNullOrWhiteSpace(unit2.Text) || String.IsNullOrWhiteSpace(unit3.Text) ||
                    String.IsNullOrWhiteSpace(unit4.Text) || String.IsNullOrWhiteSpace(unit5.Text) || String.IsNullOrWhiteSpace(unit6.Text) ||
                    String.IsNullOrWhiteSpace(unit7.Text) || String.IsNullOrWhiteSpace(unit8.Text) || String.IsNullOrWhiteSpace(unit9.Text) ||
                    String.IsNullOrWhiteSpace(unit10.Text) || String.IsNullOrWhiteSpace(unit11.Text) || String.IsNullOrWhiteSpace(unit12.Text)){
                    isEmpty = true;
                    callThis2();
                }
            }
            return isEmpty;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!checkComponents())
            {
                if (!checkIfHigh())
                {
                    resultShow();
                }
            }
        }

        private void subject1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(e.NewTextValue))
            {
                return;
            }
            if (!double.TryParse(e.NewTextValue, out double value))
            {
                ((CustomEntry)sender).Text = e.OldTextValue;
            }

        }
        double subjectLimit = 7;
        double unitLimit = 7;      
        async void callThis()
        {
            await DisplayAlert("Oppps!! Error:", "The Subject/Unit grade minimum limit is 1.00. \nThe Subject/Unit grade maximum limit is 7.00.", "OK");
        }
        private void subject1_Unfocused(object sender, FocusEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(subject1.Text)){
                return;
            }else{
                string totalSub = subject1.Text.TrimStart(new Char[] { '0', '+', '-' });
                subject1.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(subject1.Text))
                {
                    if (double.Parse(subject1.Text) > subjectLimit || double.Parse(subject1.Text) < 1)
                    {
                        callThis();
                        subject1.Focus();
                    }
                }else{return;}               
            }
        }    
        private void subject2_Unfocused(object sender, FocusEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(subject2.Text)){
                return;
            }else{
                string totalSub = subject2.Text.TrimStart(new Char[] { '0', '+', '-' });
                subject2.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(subject2.Text))
                {
                    if (double.Parse(subject2.Text) > subjectLimit || double.Parse(subject2.Text) < 1)
                    {
                        callThis();
                        subject2.Focus();
                    }
                }else{ return; }                  
            }
        }
        private void subject3_Unfocused(object sender, FocusEventArgs e)
        {
            
            if (String.IsNullOrWhiteSpace(subject3.Text)){
                return;
            }else{
                string totalSub = subject3.Text.TrimStart(new Char[] { '0', '+', '-' });
                subject3.Text = totalSub;

                if (!String.IsNullOrWhiteSpace(subject3.Text))
                {
                    if (double.Parse(subject3.Text) > subjectLimit || double.Parse(subject3.Text) < 1)
                    {
                        callThis();
                        subject3.Focus();
                    }
                }else { return; }                           
            }
        }
        private void subject4_Unfocused(object sender, FocusEventArgs e)
        {           
            if (String.IsNullOrWhiteSpace(subject4.Text)){
                return;
            }else{
                string totalSub = subject4.Text.TrimStart(new Char[] { '0', '+', '-' });
                subject4.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(subject4.Text))
                {
                    if (double.Parse(subject4.Text) > subjectLimit || double.Parse(subject4.Text) < 1)
                    {
                        callThis();
                        subject4.Focus();
                    }
                }else { return; }          
            }
        }
        private void subject5_Unfocused(object sender, FocusEventArgs e)
        {       
            if (String.IsNullOrWhiteSpace(subject5.Text))
            {
                return;
            }else{
                string totalSub = subject5.Text.TrimStart(new Char[] { '0', '+', '-' });
                subject5.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(subject5.Text))
                {
                    if (double.Parse(subject5.Text) > subjectLimit || double.Parse(subject5.Text) < 1)
                    {
                        callThis();
                        subject5.Focus();
                    }
                }else { return; }             
            }
        }
        private void subject6_Unfocused(object sender, FocusEventArgs e)
        {        
            if (String.IsNullOrWhiteSpace(subject6.Text))
            {
                return;
            }else{
                string totalSub = subject6.Text.TrimStart(new Char[] { '0', '+', '-' });
                subject6.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(subject6.Text))
                {
                    if (double.Parse(subject6.Text) > subjectLimit || double.Parse(subject6.Text) < 1)
                    {
                        callThis();
                        subject6.Focus();
                    }
                }else { return; }         
            }
        }
        private void subject7_Unfocused(object sender, FocusEventArgs e)
        {          
            if (String.IsNullOrWhiteSpace(subject7.Text))
            {
                return;
            }else{
                string totalSub = subject7.Text.TrimStart(new Char[] { '0', '+', '-' });
                subject7.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(subject7.Text))
                {
                    if (double.Parse(subject7.Text) > subjectLimit || double.Parse(subject7.Text) < 1)
                    {
                    callThis();
                    subject7.Focus();
                    }
                }else { return; }               
            }
        }
        private void subject8_Unfocused(object sender, FocusEventArgs e)
        {          
            if (String.IsNullOrWhiteSpace(subject8.Text)){
                return;
            }else{
                string totalSub = subject8.Text.TrimStart(new Char[] { '0', '+', '-' });
                subject8.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(subject8.Text))
                {
                    if (double.Parse(subject8.Text) > subjectLimit || double.Parse(subject8.Text) < 1)
                    {
                        callThis();
                        subject8.Focus();
                    }
                }else { return; }             
            }
        }
        private void subject9_Unfocused(object sender, FocusEventArgs e)
        {           
            if (String.IsNullOrWhiteSpace(subject9.Text)){
                return;
            }else{
                string totalSub = subject9.Text.TrimStart(new Char[] { '0', '+', '-' });
                subject9.Text = totalSub;

                if (!String.IsNullOrWhiteSpace(subject9.Text))
                {
                    if (double.Parse(subject9.Text) > subjectLimit || double.Parse(subject9.Text) < 1)
                    {
                    callThis();
                    subject9.Focus();
                    }
                }else { return; }
                
            }
        }
        private void subject10_Unfocused(object sender, FocusEventArgs e)
        {                      
            if (String.IsNullOrWhiteSpace(subject10.Text)){
                return;
            }else{
                string totalSub = subject10.Text.TrimStart(new Char[] { '0', '+', '-' });
                subject10.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(subject10.Text))
                {
                    if (double.Parse(subject10.Text) > subjectLimit || double.Parse(subject10.Text) < 1)
                    {
                    callThis();
                    subject10.Focus();
                    }
                }else { return; }              
            }
        }
        private void subject11_Unfocused(object sender, FocusEventArgs e)
        {         
            if (String.IsNullOrWhiteSpace(subject11.Text)){
                return;
            }else{
                string totalSub = subject11.Text.TrimStart(new Char[] { '0', '+', '-' });
                subject11.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(subject11.Text))
                {
                    if (double.Parse(subject11.Text) > subjectLimit || double.Parse(subject11.Text) < 1)
                    {
                        callThis();
                        subject11.Focus();
                    }
                }else { return; }              
            }
        }
        private void subject12_Unfocused(object sender, FocusEventArgs e)
        {  
            if (String.IsNullOrWhiteSpace(subject12.Text)){
                return;
            }else{
                string totalSub = subject12.Text.TrimStart(new Char[] { '0', '+', '-' });
                subject12.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(subject12.Text))
                {
                    if (double.Parse(subject12.Text) > subjectLimit || double.Parse(subject12.Text) < 1)
                    {
                        callThis();
                        subject12.Focus();
                    }
                }else { return; }             
            }
        }
        private void unit1_Unfocused(object sender, FocusEventArgs e)
        {                  
            if (String.IsNullOrWhiteSpace(unit1.Text)){
                return;
            }else{
                string totalSub = unit1.Text.TrimStart(new Char[] { '0', '+', '-' });
                unit1.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(unit1.Text))
                {
                    if (double.Parse(unit1.Text) > unitLimit || double.Parse(unit1.Text) < 1)
                    {
                        callThis();
                        unit1.Focus();
                    }
                }else { return; }              
            }
        }
        private void unit2_Unfocused(object sender, FocusEventArgs e)
        {                      
            if (String.IsNullOrWhiteSpace(unit2.Text)){
                return;
            }else{
                string totalSub = unit2.Text.TrimStart(new Char[] { '0', '+', '-' });
                unit2.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(unit2.Text))
                {
                    if (double.Parse(unit2.Text) > unitLimit || double.Parse(unit2.Text) < 1)
                    {
                        callThis();
                        unit2.Focus();
                    }
                }else { return; }             
            }
        }
        private void unit3_Unfocused(object sender, FocusEventArgs e)
        {                    
            if (String.IsNullOrWhiteSpace(unit3.Text)){
                return;
            }else{
                string totalSub = unit3.Text.TrimStart(new Char[] { '0', '+', '-' });
                unit3.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(unit3.Text))
                {
                    if (double.Parse(unit3.Text) > unitLimit || double.Parse(unit3.Text) < 1)
                    {
                        callThis();
                        unit3.Focus();
                    }
                }else { return; }
                
            }
        }
        private void unit4_Unfocused(object sender, FocusEventArgs e)
        {                      
            if (String.IsNullOrWhiteSpace(unit4.Text)) {
                return;
            }else{
                string totalSub = unit4.Text.TrimStart(new Char[] { '0', '+', '-' });
                unit4.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(unit4.Text))
                {
                    if (double.Parse(unit4.Text) > unitLimit || double.Parse(unit4.Text) < 1)
                    {
                        callThis();
                        unit4.Focus();
                    }
                } else { return; }               
            }
        }
        private void unit5_Unfocused(object sender, FocusEventArgs e)
        {                      
            if (String.IsNullOrWhiteSpace(unit5.Text)) {
                return;
            }else{
                string totalSub = unit5.Text.TrimStart(new Char[] { '0', '+', '-' });
                unit5.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(unit5.Text))
                {
                    if (double.Parse(unit5.Text) > unitLimit || double.Parse(unit5.Text) < 1)
                    {
                        callThis();
                        unit5.Focus();
                    }
                }else { return; }            
            }
        }
        private void unit6_Unfocused(object sender, FocusEventArgs e)
        {                    
            if (String.IsNullOrWhiteSpace(unit6.Text)){
                return;
            }else{
                string totalSub = unit6.Text.TrimStart(new Char[] { '0', '+', '-' });
                unit6.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(unit6.Text))
                {
                    if (double.Parse(unit6.Text) > unitLimit || double.Parse(unit6.Text) < 1)
                    {
                        callThis();
                        unit6.Focus();
                    }
                }else { return; }               
            }
        }
        private void unit7_Unfocused(object sender, FocusEventArgs e)
        {                  
            if (String.IsNullOrWhiteSpace(unit7.Text)) {
                return;
            }else{
                string totalSub = unit7.Text.TrimStart(new Char[] { '0', '+', '-' });
                unit7.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(unit7.Text))
                {
                    if (double.Parse(unit7.Text) > unitLimit || double.Parse(unit7.Text) < 1)
                    {
                        callThis();
                        unit7.Focus();
                    }
                }else { return; }             
            }
        }
        private void unit8_Unfocused(object sender, FocusEventArgs e)
        {                   
            if (String.IsNullOrWhiteSpace(unit8.Text)){
                return;
            }else{
                string totalSub = unit8.Text.TrimStart(new Char[] { '0', '+', '-' });
                unit8.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(unit8.Text))
                {
                    if (double.Parse(unit8.Text) > unitLimit || double.Parse(unit8.Text) < 1)
                    {
                        callThis();
                        unit8.Focus();
                    }
                }else { return; }           
            }
        }

        private void unit9_Unfocused(object sender, FocusEventArgs e)
        {                  
            if (String.IsNullOrWhiteSpace(unit9.Text)){
                return;
            }else{
                string totalSub = unit9.Text.TrimStart(new Char[] { '0', '+', '-' });
                unit9.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(unit9.Text))
                {
                    if (double.Parse(unit9.Text) > unitLimit || double.Parse(unit9.Text) < 1)
                    {
                        callThis();
                        unit9.Focus();
                    }
                }else { return; }             
            }
        }

        private void unit10_Unfocused(object sender, FocusEventArgs e)
        {                     
            if (String.IsNullOrWhiteSpace(unit10.Text)){
                return;
            }else{
                string totalSub = unit10.Text.TrimStart(new Char[] { '0', '+', '-' });
                unit10.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(unit10.Text))
                {
                    if (double.Parse(unit10.Text) > unitLimit || double.Parse(unit10.Text) < 1)
                    {
                        callThis();
                        unit10.Focus();
                    }
                }else { return; }            
            }
        }
        private void unit11_Unfocused(object sender, FocusEventArgs e)
        {            
            if (String.IsNullOrWhiteSpace(unit11.Text)){
                return;
            }else{
                string totalSub = unit11.Text.TrimStart(new Char[] { '0', '+', '-' });
                unit11.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(unit11.Text))
                {
                    if (double.Parse(unit11.Text) > unitLimit || double.Parse(unit11.Text) < 1)
                    {
                        callThis();
                        unit11.Focus();
                    }
                }else { return; }
            }
        }
        private void unit12_Unfocused(object sender, FocusEventArgs e)
        {           
            if (String.IsNullOrWhiteSpace(unit12.Text)){
                return;
            }else{
                string totalSub = unit12.Text.TrimStart(new Char[] { '0', '+', '-' });
                unit12.Text = totalSub;
                if (!String.IsNullOrWhiteSpace(unit12.Text))
                {
                    if (double.Parse(unit12.Text) > unitLimit || double.Parse(unit12.Text) < 1)
                    {
                        callThis();
                        unit12.Focus();
                    }
                }else { return; }           
            }
        }
        private async void backBtn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Message:", "\t\t Thank you for installing My GWA!", "Welcome");
            await Navigation.PopAsync();
        }
    }
}