using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    static public class GUIFunctions
    {
        public static string StringAlign(string text)
        {
            char[] space = new char[59];
            for (int i = 0; i < space.Length; i++)
            {
                space[i] = ' ';
            }
            for (int i = 0; i < text.Length; i++)
            {
                space[i] = text[i];
            }
            return new string(space);
        }

        public static string StringAlign(string text, int num)
        {
            char[] space = new char[62];
            for (int i = 0; i < space.Length; i++)
            {
                space[i] = ' ';
            }
            for (int i = 0; i < text.Length; i++)
            {
                space[i + num] = text[i];
            }
            return new string(space);
        }

        public static string SquaregAlign()
        {
            char[] space = new char[64];
            for (int i = 0; i < space.Length; i++)
            {
                space[i] = '#';
            }
            return new string(space);
        }
    }
}
