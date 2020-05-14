using System;
using System.Windows.Controls;

namespace ScriptsClassLibrary
{
    public class VariableMover
    {
        public static int CrushinСounter = 0;
        public static Random Rand = new Random();
        public static Grid CenterScrin_GridNull;
        
        public static void MethodForMovingVariables(Grid MethodCenterScrin_GridNull, TextBox MethodTextBoxGenerator, TextBlock MethodTextBlockGenerator)
        {
            CenterScrin_GridNull = MethodCenterScrin_GridNull;
            
            CrushinСounter += Convert.ToInt32(MethodTextBoxGenerator.Text);

            DivideIntoBlocks.MethodDivideIntoBlocks(Convert.ToInt32(MethodTextBoxGenerator.Text)); 
            MethodTextBlockGenerator.Text = Convert.ToString(CrushinСounter) + " / " + Math.Round(10.0 * CrushinСounter / 16, 0);
        }
    }
}