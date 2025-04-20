using System;
using System.Collections.Generic;
using System;
using System.Text;
using System.Drawing;

public static class WBCode
{
    public static Bitmap ConvertTextToBitmap(string text)
    {
        string bin = StringToBinary(text + "EOF");
        System.Windows.Forms.MessageBox.Show(bin);
        Bitmap bitmap = new Bitmap(256, 256);
        int initialIndex = 0;

        for (int i = 0; i < bitmap.Width; i++)
        {
            for (int j = 0; j < bitmap.Height; j++)
            {
                if (initialIndex >= bin.Length)
                {
                    bitmap.SetPixel(i, j, Color.White);
                }
                else
                {
                    if (bin[initialIndex] == '0')
                    {
                        bitmap.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        bitmap.SetPixel(i, j, Color.White);
                    }

                    initialIndex++;
                }
            }
        }

        return bitmap;
    }

    public static string ConvertBitmapToText(Bitmap bitmap)
    {
        string bin = "";
        bool finish = false;

        for (int i = 0; i < bitmap.Width; i++)
        {
            if (!finish)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    if (!finish)
                    {
                        if (bitmap.GetPixel(i, j).R == 0)
                        {
                            bin += '0';
                        }
                        else
                        {
                            bin += '1';
                        }

                        if (bin.EndsWith("010001010100111101000110"))
                        {
                            finish = true;
                            break;
                        }
                    }
                }
            }
        }

        bin = BinaryToString(bin);
        bin = bin.Substring(0, bin.Length - 3);

        return bin;
    }

    private static string StringToBinary(string data)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in data.ToCharArray())
        {
            sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
        }

        return sb.ToString();
    }

    private static string BinaryToString(string data)
    {
        List<Byte> byteList = new List<Byte>();

        for (int i = 0; i < data.Length; i += 8)
        {
            try
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            catch
            {
                break;
            }
        }

        return Encoding.ASCII.GetString(byteList.ToArray());
    }
}