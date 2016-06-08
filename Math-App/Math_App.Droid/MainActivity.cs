using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.Animations;
using Math_App.Validator;
using Android.Content.PM;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using System.Collections.Generic;
using Math_App.Xml;
using Math_App.Memory;
using Math_App.Logics;
using static System.Net.Mime.MediaTypeNames;

namespace Math_App.Droid
{
    [Activity(Label = "RekenApp", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait, Icon = "@drawable/App_icon")]
    public class MainActivity : Activity
    {


        // validator class
        private ValidatorCalc val = new ValidatorCalc();
        //  storage class
        private Storage sto = new Storage();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

			//Perform Tests
			if(Const.PERFORM_TESTS == true)
			{
				TestMainClass.performTests();
			}

			//ActionBar.SetDisplayShowHomeEnabled(true);
			//ActionBar.SetIcon(Resource.Drawable.Plus);

			// Prefix
			var resourcePrefix = "Math_App.Droid.";

            // set vibration
            Vibrator v = (Vibrator)this.GetSystemService(Context.VibratorService);

            // NumberPicker values
            string pickerB = "";
            string pickerC = "";

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Set button animation
            Animation animAlpha = AnimationUtils.LoadAnimation(this, Resource.Layout.ButtonAnimation);

            // Set calculation textview
            TextView textviewCalc = FindViewById<TextView>(Resource.Id.textView1);

            // Next page
            Button button = FindViewById<Button>(Resource.Id.ShowMe);
            button.Click += (sender, args) => button.StartAnimation(animAlpha);
            button.Click += delegate
            {
                string text = textviewCalc.Text.ToString();
                if (text.Length > 0 && val.lastChar(text.Substring(Math.Max(0, text.Length - 1)) ))
                {
                    // new page
                    var second = new Intent(this, typeof(SecondPage));
                    Bundle extras = new Bundle();
                    extras.PutString("calculation", textviewCalc.Text.ToString());
                    second.PutExtras(extras);
                    StartActivity(second);
                    // set memory
                    sto.AddEquation(text);
                }
                else
                {
                    // Vibrate for 500 milliseconds
                    v.Vibrate(200);
                }
            };

            // Remove all input
            Button buttonRevert = FindViewById<Button>(Resource.Id.Revert);
            buttonRevert.Click += (sender, args) => buttonRevert.StartAnimation(animAlpha);
            buttonRevert.Click += delegate
            {
                string text = textviewCalc.Text.ToString();
                if (text.Length > 0)
                {
                    text = text.Remove(text.Length - 1);
                    textviewCalc.Text = text;
                }                
            };

            // Remove last input
            Button buttonDelete = FindViewById<Button>(Resource.Id.Delete);
            buttonDelete.Click += (sender, args) => buttonDelete.StartAnimation(animAlpha);
            buttonDelete.Click += delegate
            {
                string text = textviewCalc.Text.ToString();
                if (text.Length > 0)
                {
                    textviewCalc.Text = "";
                }
            };

            // Number input
            Button buttonZero = FindViewById<Button>(Resource.Id.Zero);
            buttonZero.Click += (sender, args) => buttonZero.StartAnimation(animAlpha);
            buttonZero.Click += delegate
            {
                if (val.checkZero(textviewCalc.Text))
                {
                    textviewCalc.Text += "0";
                }
            };

            Button buttonOne = FindViewById<Button>(Resource.Id.One);
            buttonOne.Click += (sender, args) => buttonOne.StartAnimation(animAlpha);
            buttonOne.Click += delegate
            {
                textviewCalc.Text += "1";
            };

            Button buttonTwo = FindViewById<Button>(Resource.Id.Two);
            buttonTwo.Click += (sender, args) => buttonTwo.StartAnimation(animAlpha);
            buttonTwo.Click += delegate
            {
                textviewCalc.Text += "2";
            };

            Button buttonThree = FindViewById<Button>(Resource.Id.Three);
            buttonThree.Click += (sender, args) => buttonThree.StartAnimation(animAlpha);
            buttonThree.Click += delegate
            {
                textviewCalc.Text += "3";
            };

            Button buttonFour = FindViewById<Button>(Resource.Id.Four);
            buttonFour.Click += (sender, args) => buttonFour.StartAnimation(animAlpha);
            buttonFour.Click += delegate
            {
                textviewCalc.Text += "4";
            };

            Button buttonFive = FindViewById<Button>(Resource.Id.Five);
            buttonFive.Click += (sender, args) => buttonFive.StartAnimation(animAlpha);
            buttonFive.Click += delegate
            {
                textviewCalc.Text += "5";
            };

            Button buttonSix = FindViewById<Button>(Resource.Id.Six);
            buttonSix.Click += (sender, args) => buttonSix.StartAnimation(animAlpha);
            buttonSix.Click += delegate
            {
                textviewCalc.Text += "6";
            };

            Button buttonSeven = FindViewById<Button>(Resource.Id.Seven);
            buttonSeven.Click += (sender, args) => buttonSeven.StartAnimation(animAlpha);
            buttonSeven.Click += delegate
            {
                textviewCalc.Text += "7";
            };

            Button buttonEight = FindViewById<Button>(Resource.Id.Eight);
            buttonEight.Click += (sender, args) => buttonEight.StartAnimation(animAlpha);
            buttonEight.Click += delegate
            {
                textviewCalc.Text += "8";
            };

            Button buttonNine = FindViewById<Button>(Resource.Id.Nine);
            buttonNine.Click += (sender, args) => buttonNine.StartAnimation(animAlpha);
            buttonNine.Click += delegate
            {
                textviewCalc.Text += "9";
            };

            // Equation type input
            Button buttonMinus = FindViewById<Button>(Resource.Id.Minus);
            buttonMinus.Click += (sender, args) => buttonMinus.StartAnimation(animAlpha);
            buttonMinus.Click += delegate
            {
                string text = textviewCalc.Text.ToString();
                if (text.Length > 0)
                {
                    char cLastCharacter = textviewCalc.Text.ToString()[textviewCalc.Text.ToString().Length - 1];
                    if (val.checkCharacters(cLastCharacter.ToString(), "-"))
                    {
                        textviewCalc.Text += "-";
                    }
                }
            };

            Button buttonMultiply = FindViewById<Button>(Resource.Id.Multiply);
            buttonMultiply.Click += (sender, args) => buttonMultiply.StartAnimation(animAlpha);
            buttonMultiply.Click += delegate
            {
                string text = textviewCalc.Text.ToString();
                if (text.Length > 0)
                {
                    char cLastCharacter = textviewCalc.Text.ToString()[textviewCalc.Text.ToString().Length - 1];
                    if (val.checkCharacters(cLastCharacter.ToString(), "x"))
                    {
                        textviewCalc.Text += "x";
                    }
                }
            };

            Button buttonDevide = FindViewById<Button>(Resource.Id.Devide);
            buttonDevide.Click += (sender, args) => buttonDevide.StartAnimation(animAlpha);
            buttonDevide.Click += delegate
            {
                string text = textviewCalc.Text.ToString();
                if (text.Length > 0)
                {
                    char cLastCharacter = textviewCalc.Text.ToString()[textviewCalc.Text.ToString().Length - 1];
                    if (val.checkCharacters(cLastCharacter.ToString(), "÷"))
                    {
                        textviewCalc.Text += "÷";
                    }
                }
            };

            Button buttonAddition = FindViewById<Button>(Resource.Id.Addition);
            buttonAddition.Click += (sender, args) => buttonAddition.StartAnimation(animAlpha);
            buttonAddition.Click += delegate
            {
                string text = textviewCalc.Text.ToString();
                if (text.Length > 0)
                {
                    char cLastCharacter = textviewCalc.Text.ToString()[textviewCalc.Text.ToString().Length - 1];
                    if (val.checkCharacters(cLastCharacter.ToString(), "+"))
                    {
                        textviewCalc.Text += "+";
                    }
                }
            };

            // Bracket type input
            Button buttonBracketLeft = FindViewById<Button>(Resource.Id.BracketLeft);
            buttonBracketLeft.Click += (sender, args) => buttonBracketLeft.StartAnimation(animAlpha);
            buttonBracketLeft.Click += delegate
            {
                string text = textviewCalc.Text.ToString();
                if (text.Length > 0)
                {
                    char cLastCharacter = textviewCalc.Text.ToString()[textviewCalc.Text.ToString().Length - 1];
                    if (val.checkCharacters(cLastCharacter.ToString(), "("))
                    {
                        textviewCalc.Text += "(";
                    }
                }
            };          
            
            Button buttonBracketRight = FindViewById<Button>(Resource.Id.BracketRight);
            buttonBracketRight.Click += (sender, args) => buttonBracketRight.StartAnimation(animAlpha);
            buttonBracketRight.Click += delegate
            {
                string text = textviewCalc.Text.ToString();
                if (text.Length > 0)
                {
                    char cLastCharacter = textviewCalc.Text.ToString()[textviewCalc.Text.ToString().Length - 1];
                    if (val.checkCharacters(cLastCharacter.ToString(), ")"))
                    {
                        textviewCalc.Text += ")";
                    }
                }
            };

            // NumberPicker dialogs
            Button FracB = FindViewById<Button>(Resource.Id.FracionB);
            FracB.Click += (sender, args) => buttonBracketRight.StartAnimation(animAlpha);
            FracB.Click += delegate
            {
                NumberPicker picker = new NumberPicker(this);
                picker.MaxValue = 10;
                picker.MinValue = 1;
                AlertDialog.Builder builder = new AlertDialog.Builder(this).SetView(picker);
                builder.SetTitle("Number");
                builder.SetNegativeButton(Resource.String.Dialog_Cancel, (s, a) => { });
                builder.SetPositiveButton(Resource.String.Dialog_Ok, (s, a) => {
                    pickerB = Convert.ToString(picker.Value);
                    FracB.Text = Convert.ToString(picker.Value);
                });
                builder.Show();
            };

            Button FracC = FindViewById<Button>(Resource.Id.FracionC);
            FracC.Click += (sender, args) => buttonBracketRight.StartAnimation(animAlpha);
            FracC.Click += delegate
            {
                NumberPicker picker = new NumberPicker(this);
                picker.MaxValue = 10;
                picker.MinValue = 1;
                AlertDialog.Builder builder = new AlertDialog.Builder(this).SetView(picker);
                builder.SetTitle("Number");
                builder.SetNegativeButton(Resource.String.Dialog_Cancel, (s, a) => { });
                builder.SetPositiveButton(Resource.String.Dialog_Ok, (s, a) => {
                    pickerC = Convert.ToString(picker.Value);
                    FracC.Text = Convert.ToString(picker.Value);
                    
                });
                builder.Show();
            };

            Button FracAdd = FindViewById<Button>(Resource.Id.FracionAdd);
            FracAdd.Click += (sender, args) => buttonBracketRight.StartAnimation(animAlpha);
            FracAdd.Click += delegate
            {
                textviewCalc.Text += val.CreateFraction(pickerB, pickerC);                
                pickerC = "";
                pickerB = "";
            };

            // Memory buttons
            int counter = 0;
            ImageButton MemBack = FindViewById<ImageButton>(Resource.Id.memBack);
            ImageButton MemNext = FindViewById<ImageButton>(Resource.Id.memNext);
            MemNext.Enabled = false;

            MemBack.Click += (sender, args) => MemBack.StartAnimation(animAlpha);
            MemBack.Click += delegate
            {
                if (counter < 4 && sto.CheckIfEmpty(counter + 1))
                {
                    MemNext.Enabled = true;
                    counter += 1;
                    Console.WriteLine(counter);
                    textviewCalc.Text = sto.ReturnEquation(counter);
                    if(counter == 4)
                    {
                        MemBack.Enabled = false;
                    }
                }                
            };            
           
            MemNext.Click += (sender, args) => MemNext.StartAnimation(animAlpha);
            MemNext.Click += delegate
            {
                if (counter > 0 && sto.CheckIfEmpty(counter -1))
                {
                    MemBack.Enabled = true;
                    counter -= 1;
                    Console.WriteLine(counter);
                    textviewCalc.Text = sto.ReturnEquation(counter);
                    if(counter == 0)
                    {
                        MemNext.Enabled = false;
                    }
                }                
            };
        }
    }
}


