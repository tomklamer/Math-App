﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.Animations;
using Math_App.Validator;

namespace Math_App.Droid
{
    [Activity(Label = "RekenApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity      {

        private ValidatorCalc val = new ValidatorCalc();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);            

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Animation animAlpha = AnimationUtils.LoadAnimation(this, Resource.Layout.ButtonAnimation);

            TextView textviewCalc = FindViewById<TextView>(Resource.Id.textView1);

            Button button = FindViewById<Button>(Resource.Id.ShowMe);
            button.Click += (sender, args) => button.StartAnimation(animAlpha);
            button.Click += delegate
            {              
                //button.Text = string.Format("{0} user clicks!", 20);
                var second = new Intent(this, typeof(SecondPage));
                StartActivity(typeof(SecondPage));
            };

            Button buttonRevert = FindViewById<Button>(Resource.Id.Revert);
            buttonRevert.Click += (sender, args) => buttonRevert.StartAnimation(animAlpha);
            buttonRevert.Click += delegate
            {                
                string text = textviewCalc.Text.ToString();
                if(text.Length > 0)
                {
                    text = text.Remove(text.Length - 1);
                    textviewCalc.Text = text;
                }
            };

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

            Button buttonZero = FindViewById<Button>(Resource.Id.Zero);
            buttonZero.Click += (sender, args) => buttonZero.StartAnimation(animAlpha);
            buttonZero.Click += delegate
            {
                textviewCalc.Text += "0";
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

            Button buttonMinus = FindViewById<Button>(Resource.Id.Minus);
            buttonMinus.Click += (sender, args) => buttonMinus.StartAnimation(animAlpha);
            buttonMinus.Click += delegate
            {
                char cLastCharacter = textviewCalc.Text.ToString()[textviewCalc.Text.ToString().Length - 1];
                if (val.checkCharacters(cLastCharacter.ToString(), "-"))
                {
                    textviewCalc.Text += "-";
                }                
            };

            Button buttonMultiply = FindViewById<Button>(Resource.Id.Multiply);
            buttonMultiply.Click += (sender, args) => buttonMultiply.StartAnimation(animAlpha);
            buttonMultiply.Click += delegate
            {
                char cLastCharacter = textviewCalc.Text.ToString()[textviewCalc.Text.ToString().Length - 1];
                if (val.checkCharacters(cLastCharacter.ToString(), "x"))
                {
                    textviewCalc.Text += "x";
                }                    
            };

            Button buttonDevide = FindViewById<Button>(Resource.Id.Devide);
            buttonDevide.Click += (sender, args) => buttonDevide.StartAnimation(animAlpha);
            buttonDevide.Click += delegate
            {
                char cLastCharacter = textviewCalc.Text.ToString()[textviewCalc.Text.ToString().Length - 1];
                if (val.checkCharacters(cLastCharacter.ToString(), "x"))
                {
                    textviewCalc.Text += "/";
                }                
            };

            Button buttonAddition = FindViewById<Button>(Resource.Id.Addition);
            buttonAddition.Click += (sender, args) => buttonAddition.StartAnimation(animAlpha);
            buttonAddition.Click += delegate
            {
                char cLastCharacter = textviewCalc.Text.ToString()[textviewCalc.Text.ToString().Length - 1];
                if (val.checkCharacters(cLastCharacter.ToString(), "x"))
                {
                    textviewCalc.Text += "+";
                }                
            };

            Button buttonBracketLeft = FindViewById<Button>(Resource.Id.BracketLeft);
            buttonBracketLeft.Click += (sender, args) => buttonBracketLeft.StartAnimation(animAlpha);
            buttonBracketLeft.Click += delegate
            {
                char cLastCharacter = textviewCalc.Text.ToString()[textviewCalc.Text.ToString().Length - 1];
                if (val.checkCharacters(cLastCharacter.ToString(), "x"))
                {
                    textviewCalc.Text += "(";
                }
            };

            Button buttonBracketRight = FindViewById<Button>(Resource.Id.BracketRight);
            buttonBracketRight.Click += (sender, args) => buttonBracketRight.StartAnimation(animAlpha);
            buttonBracketRight.Click += delegate
            {
                char cLastCharacter = textviewCalc.Text.ToString()[textviewCalc.Text.ToString().Length - 1];
                if (val.checkCharacters(cLastCharacter.ToString(), "x"))
                {
                    textviewCalc.Text += ")";
                }
            };
        }


    }
}


