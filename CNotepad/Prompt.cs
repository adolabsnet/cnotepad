﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CNotepad
{
    class Prompt
    {
        public static string ShowDialog(string msg = "Enter Password")
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Authentication",
                StartPosition = FormStartPosition.CenterParent
            };

            Label textLbl = new Label() { Left = 50, Top = 20, Width=150, Text = msg, Font = new Font("Arial", 11) };
            TextBox txtBox = new TextBox() { Left = 50, Top = 45, Width = 400, PasswordChar = '#', TextAlign = HorizontalAlignment.Center, Font = new Font("Arial", 12) };
            Button btnConfirm = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 73, DialogResult = DialogResult.OK };

            prompt.Controls.Add(textLbl);
            prompt.Controls.Add(txtBox);
            prompt.Controls.Add(btnConfirm);

            return prompt.ShowDialog() == DialogResult.OK ? txtBox.Text : "";
        }
    }
}
