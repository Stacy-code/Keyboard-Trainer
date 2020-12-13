using System;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace KeyboardTrainer
{
    internal sealed partial class MainWindow : Window
    {
        Brush colorGrey = new SolidColorBrush(Color.FromRgb(181, 181, 181));
        Brush colorRed = new SolidColorBrush(Color.FromRgb(240, 119, 149));
        Brush colorYellow = new SolidColorBrush(Color.FromRgb(230, 240, 119));
        Brush colorBlue = new SolidColorBrush(Color.FromRgb(119, 190, 240));
        Brush colorPurple = new SolidColorBrush(Color.FromRgb(219, 119, 240));
        Brush colorOrange = new SolidColorBrush(Color.FromRgb(229, 187, 114));
        Brush colorGreen = new SolidColorBrush(Color.FromRgb(127, 240, 119));
        

        Brush colorPressed = new SolidColorBrush(Color.FromRgb(255, 0, 0));


        //int tempTimer = 0;
        int fails = 0;
        bool Start = false;
        int tempTimer = 0;

        
       
       
        DispatcherTimer timer = null;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);

        }
        
        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

            if (Start == true)
            {
                switch (e.Key)
                {
                    case Key.Q:
                        btnQ.Background = colorPressed;
                        YourText.Text += "q";
                        break;
                    case Key.W:
                        btnW.Background = colorPressed;
                        YourText.Text += "w";
                        break;
                    case Key.OemTilde:
                        btnOemTilde.Background = colorPressed;
                        YourText.Text += "`";
                        break;
                    case Key.Back:
                        btnBackSpace.Background = colorPressed;
                        fails++;
                        if (YourText.Text != "")
                        {
                            string s = YourText.Text.Remove(YourText.Text.Length - 1);
                            YourText.Text = s;

                        }
                        break;
                    case Key.E:
                        btnE.Background = colorPressed;
                        YourText.Text += "e";
                        break;
                    case Key.OemOpenBrackets:
                        btnOemOpenBrackets.Background = colorPressed;
                        YourText.Text += "[";
                        break;
                    case Key.D1:
                        btn1.Background = colorPressed;
                        YourText.Text += "1";
                        break;

                    case Key.D2:
                        btn2.Background = colorPressed;
                        YourText.Text += "2";
                        break;
                    case Key.D3:
                        btn3.Background = colorPressed;
                        YourText.Text += "3";
                        break;
                    case Key.D4:
                        btn4.Background = colorPressed;
                        YourText.Text += "4";
                        break;
                    case Key.D5:
                        btn5.Background = colorPressed;
                        YourText.Text += "5";
                        break;
                    case Key.D6:
                        btn6.Background = colorPressed;
                        YourText.Text += "6";
                        break;
                    case Key.D7:
                        btn7.Background = colorPressed;
                        YourText.Text += "7";
                        break;
                    case Key.D8:
                        btn8.Background = colorPressed;
                        YourText.Text += "8";
                        break;
                    case Key.D9:
                        btn9.Background = colorPressed;
                        YourText.Text += "9";
                        break;
                    case Key.D0:
                        btn0.Background = colorPressed;
                        YourText.Text += "0";
                        break;
                    case Key.OemMinus:
                        btnOemMinus.Background = colorPressed;
                        YourText.Text += "-";
                        break;
                    case Key.R:
                        btnR.Background = colorPressed;
                        YourText.Text += "r";
                        break;
                    case Key.Space:
                        btnSpace.Background = colorPressed;
                        YourText.Text += " ";
                        break;
                    case Key.T:
                        btnT.Background = colorPressed;
                        YourText.Text += "t";
                        break;
                    case Key.Y:
                        btnY.Background = colorPressed;
                        YourText.Text += "y";
                        break;
                    case Key.U:
                        btnU.Background = colorPressed;
                        YourText.Text += "u";
                        break;
                    case Key.I:
                        btnI.Background = colorPressed;
                        YourText.Text += "i";
                        break;
                    case Key.O:
                        btnO.Background = colorPressed;
                        YourText.Text += "o";
                        break;
                    case Key.P:
                        btnP.Background = colorPressed;
                        YourText.Text += "p";
                        break;
                    case Key.OemCloseBrackets:
                        btnClosedBrackets.Background = colorPressed;
                        YourText.Text += "]";
                        break;
                    case Key.OemSemicolon:
                        btnOemSemicolon.Background = colorPressed;
                        YourText.Text += ";";
                        break;
                    case Key.OemQuotes:
                        btnOemQuotes.Background = colorPressed;
                        YourText.Text += "'";
                        break;
                    case Key.OemQuestion:
                        btnOemQuestion.Background = colorPressed;
                        YourText.Text += "/";
                        break;
                    case Key.OemPlus:
                        btnOemplus.Background = colorPressed;
                        YourText.Text += "=";
                        break;
                    case Key.OemPipe:
                        btnOemPipe.Background = colorPressed;
                        YourText.Text += "|";
                        break;
                    case Key.A:
                        btnA.Background = colorPressed;
                        YourText.Text += "a";
                        break;
                    case Key.S:
                        btnS.Background = colorPressed;
                        YourText.Text += "s";
                        break;
                    case Key.D:
                        btnD.Background = colorPressed;
                        YourText.Text += "d";
                        break;
                    case Key.F:
                        btnF.Background = colorPressed;
                        YourText.Text += "f";
                        break;
                    case Key.G:
                        btnG.Background = colorPressed;
                        YourText.Text += "g";
                        break;
                    case Key.H:
                        btnH.Background = colorPressed;
                        YourText.Text += "h";
                        break;
                    case Key.J:
                        btnJ.Background = colorPressed;
                        YourText.Text += "j";
                        break;
                    case Key.K:
                        btnK.Background = colorPressed;
                        YourText.Text += "k";
                        break;
                    case Key.L:
                        btnL.Background = colorPressed;
                        YourText.Text += "l";
                        break;
                    case Key.Z:
                        btnZ.Background = colorPressed;
                        YourText.Text += "z";
                        break;
                    case Key.X:
                        btnX.Background = colorPressed;
                        YourText.Text += "x";
                        break;
                    case Key.C:
                        btnC.Background = colorPressed;
                        YourText.Text += "c";
                        break;
                    case Key.V:
                        btnV.Background = colorPressed;
                        YourText.Text += "v";
                        break;
                    case Key.B:
                        btnB.Background = colorPressed;
                        YourText.Text += "b";
                        break;
                    case Key.N:
                        btnN.Background = colorPressed;
                        YourText.Text += "n";
                        break;
                    case Key.M:
                        btnM.Background = colorPressed;
                        YourText.Text += "m";
                        break;
                    case Key.OemPeriod:
                        BtnDot.Background = colorPressed;
                        YourText.Text += ".";
                        break;
                    case Key.OemComma:
                        BtnComma.Background = colorPressed;
                        YourText.Text += ",";
                        break;
                }

            }


        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (Start == true) {
                switch (e.Key)
                {
                    case Key.Q:
                        btnQ.Background = colorRed;
                        break;
                    case Key.Back:
                        btnBackSpace.Background = colorGrey ;
                        break;
                    case Key.W:
                        btnW.Background = colorYellow;
                        break;
                    case Key.OemTilde:
                        btnOemTilde.Background = colorRed;
                        break;
                    case Key.E:
                        btnE.Background = colorGreen;
                        break;
                    case Key.OemOpenBrackets:
                        btnOemOpenBrackets.Background = colorGreen;
                        break;
                    case Key.D1:
                        btn1.Background = colorRed;
                        break;
                    case Key.D2:
                        btn2.Background = colorRed;
                        break;
                    case Key.D3:
                        btn3.Background = colorYellow;
                        break;
                    case Key.D4:
                        btn4.Background = colorGreen;
                        break;
                    case Key.D5:
                        btn5.Background = colorBlue;
                        break;
                    case Key.D6:
                        btn6.Background = colorBlue;
                        break;
                    case Key.D7:
                        btn7.Background = colorPurple;
                        break;
                    case Key.D8:
                        btn8.Background = colorPurple;
                        break;
                    case Key.D9:
                        btn9.Background = colorRed;
                        break;
                    case Key.D0:
                        btn0.Background = colorYellow;
                        break;
                    case Key.OemMinus:
                        btnOemMinus.Background = colorGreen;
                        break;
                    case Key.R:
                        btnR.Background = colorBlue;
                        break;
                    case Key.Space:
                        btnSpace.Background = colorOrange;
                        break;
                    case Key.T:
                        btnT.Background = colorBlue;
                        break;
                    case Key.Y:
                        btnY.Background = colorPurple;
                        break;
                    case Key.U:
                        btnU.Background = colorPurple;
                        break;
                    case Key.I:
                        btnI.Background = colorRed;
                        break;
                    case Key.O:
                        btnO.Background = colorYellow;
                        break;
                    case Key.P:
                        btnP.Background = colorGreen;
                        break;
                    case Key.OemCloseBrackets:
                        btnClosedBrackets.Background = colorGreen;
                        break;
                    case Key.OemSemicolon:
                        btnOemSemicolon.Background = colorGreen;
                        break;
                    case Key.OemQuotes:
                        btnOemQuotes.Background = colorGreen;
                        break;
                    case Key.OemQuestion:
                        btnOemQuestion.Background = colorGreen;
                        break;
                    case Key.OemPlus:
                        btnOemplus.Background = colorGreen;
                        break;
                    case Key.OemPipe:
                        btnOemPipe.Background = colorGreen;
                        break;
                    case Key.A:
                        btnA.Background = colorRed;
                        break;
                    case Key.S:
                        btnS.Background = colorYellow;
                        break;
                    case Key.D:
                        btnD.Background = colorGreen;
                        break;
                    case Key.F:
                        btnF.Background = colorBlue;
                        break;
                    case Key.G:
                        btnG.Background = colorBlue;
                        break;
                    case Key.H:
                        btnH.Background = colorPurple;
                        break;
                    case Key.J:
                        btnJ.Background = colorPurple;
                        break;
                    case Key.K:
                        btnK.Background = colorRed;
                        break;
                    case Key.L:
                        btnL.Background = colorYellow;
                        break;

                    case Key.Z:
                        btnZ.Background = colorRed;
                        break;
                    case Key.X:
                        btnX.Background = colorYellow;
                        break;
                    case Key.C:
                        btnC.Background = colorGreen;
                        break;
                    case Key.V:
                        btnV.Background = colorBlue;
                        break;
                    case Key.B:
                        btnB.Background = colorBlue;
                        break;
                    case Key.N:
                        btnN.Background = colorPurple;
                        break;
                    case Key.M:
                        btnM.Background = colorPurple;
                        break;
                    case Key.OemPeriod:
                        BtnDot.Background = colorYellow;
                        break;
                    case Key.OemComma:
                        BtnComma.Background = colorRed;
                        break;

                }
            }
                
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SliderDifficult.IsEnabled = false;
            RandomText.Text = "";
            YourText.Text = "";
            fails = 0;
            Start = true;
            RandomText.Text= RandomString("`1234567890-=qwertyuiop[]|asdfghjkl;'zxcvbnm,./ ", (int)SliderDifficult.Value);
          
            tempTimer = 0;
            timer.Start();
           
                       

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tempTimer++;
            Speed();
        }

        static string RandomString(string Alphabet, int Length)
        {
            Random ran = new Random();
            StringBuilder RandomString = new StringBuilder(Length - 1);
            int Position = 0;
            for (int i = 0; i < Length; i++)
            {
                Position = ran.Next(0, Alphabet.Length - 1);
                RandomString.Append(Alphabet[Position]);
            }
            return RandomString.ToString();
        }

        private void SliderDifficult_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int num = (int)SliderDifficult.Value;
            difficulty.Content = num.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Start = false;
            SliderDifficult.Value = SliderDifficult.Minimum;
            timer.Stop();
            tempTimer = 0;
            RandomText.Text = "";
            YourText.Text = "";
            
            SliderDifficult.IsEnabled = true;
            btnQ.Background = colorRed;

            btnBackSpace.Background = colorGrey;

            btnW.Background = colorYellow;

            btnOemTilde.Background = colorRed;

            btnE.Background = colorGreen;

            btnOemOpenBrackets.Background = colorGreen;

            btn1.Background = colorRed;

            btn2.Background = colorRed;

            btn3.Background = colorYellow;

            btn4.Background = colorGreen;

            btn5.Background = colorBlue;

            btn6.Background = colorBlue;

            btn7.Background = colorPurple;

            btn8.Background = colorPurple;

            btn9.Background = colorRed;

            btn0.Background = colorYellow;

            btnOemMinus.Background = colorGreen;

            btnR.Background = colorBlue;

            btnSpace.Background = colorOrange;

            btnT.Background = colorBlue;

            btnY.Background = colorPurple;

            btnU.Background = colorPurple;

            btnI.Background = colorRed;

            btnO.Background = colorYellow;

            btnP.Background = colorGreen;

            btnClosedBrackets.Background = colorGreen;

            btnOemSemicolon.Background = colorGreen;

            btnOemQuotes.Background = colorGreen;

            btnOemQuestion.Background = colorGreen;

            btnOemplus.Background = colorGreen;

            btnOemPipe.Background = colorGreen;

            btnA.Background = colorRed;

            btnS.Background = colorYellow;

            btnD.Background = colorGreen;

            btnF.Background = colorBlue;

            btnG.Background = colorBlue;

            btnH.Background = colorPurple;

            btnJ.Background = colorPurple;

            btnK.Background = colorRed;

            btnL.Background = colorYellow;

            btnZ.Background = colorRed;

            btnX.Background = colorYellow;

            btnC.Background = colorGreen;

            btnV.Background = colorBlue;

            btnB.Background = colorBlue;

            btnN.Background = colorPurple;

            btnM.Background = colorPurple;

            BtnDot.Background = colorYellow;

            BtnComma.Background = colorRed;
            Fails.Text = "0";
            SpeedChar.Text = "0";
        }



        private void Fails_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void YourText_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string str = RandomText.Text.Substring(0, YourText.Text.Length);
            if (YourText.Text.Equals(str))
            {
                
                YourText.Foreground = new SolidColorBrush(Colors.Black);
            }
            else
            {
                
                YourText.Foreground = new SolidColorBrush(Colors.Red);
                
            }
            if (YourText.Text.Length == RandomText.Text.Length&& YourText.Text!="")
            {

                timer.Stop();
                Speed();
                SliderDifficult.Value = SliderDifficult.Minimum;
                Start = false;
                MessageBox.Show($"Задание завершенно!\n Коилчество символов {RandomText.Text.Length}.\n Коилчество ошибок {fails}.\nДля завершения задания нажмите Stop.", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            Fails.Text = fails.ToString();
        }

        void Speed()
        {
            SpeedChar.Text = Math.Round(((double)YourText.Text.Length / tempTimer) * 60).ToString();
        }

       
    }
}