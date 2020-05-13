using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ScriptsClassLibrary
{
    public class VariableMover
    {
        public static int CrushinСounter = 0;
        public static Grid CenterScrin_GridNull;
        
        public static void MethodForMovingVariables(Grid MethodCenterScrin_GridNull, TextBox MethodTextBoxGenerator, TextBlock MethodTextBlockGenerator)
        {
            CenterScrin_GridNull = MethodCenterScrin_GridNull;
            
            CrushinСounter += Convert.ToInt32(MethodTextBoxGenerator.Text);

            DivideIntoBlocks.MethodDivideIntoBlocks(Convert.ToInt32(MethodTextBoxGenerator.Text)); Marker();
            MethodTextBlockGenerator.Text = Convert.ToString(CrushinСounter);
        }

        private static void Marker()
        {
            Random Rand = new Random();
            Border Person = new Border
            {
                //Background = new SolidColorBrush(Color.FromArgb((byte)Rand.Next(255), (byte)Rand.Next(255), (byte)Rand.Next(255), (byte)Rand.Next(255))),
                Background = (Brush)new BrushConverter().ConvertFrom("#FF474747"),
            };
            Grid.SetColumn(Person, 0);
            Grid.SetRow(Person, 0);

            CenterScrin_GridNull.Children.Add(Person);
        }
    }
}