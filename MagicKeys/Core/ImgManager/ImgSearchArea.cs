using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MagicKeys
{
    public partial class MagicKeys
{
public static int[] ImgSearchArea(string imgPath, int X, int Y, int W, int H, int Variant)
{
string PImg = imgPath;
string[] TPImg = imgPath.Split(@"\");
if (TPImg.Length == 1)
{
PImg = API.GetImgPath()+imgPath;
}
IntPtr result = ImageSearch(X, Y, W, H, "*"+Variant+" "+PImg+".bmp");
String res = Marshal.PtrToStringAnsi(result);
if (res == "0")
{
int[] Ar = new int[1] {Convert.ToInt32(res)};
return Ar;
}
String[] data = res.Split('|');
int r; int x; int y; int w; int h;
int.TryParse(data[0], out r);
int.TryParse(data[1], out x);
int.TryParse(data[2], out y);
int.TryParse(data[3], out w);
int.TryParse(data[4], out h);
int cx = (w/2)+x;
int cy = (h/2)+y;
int[] pos = new int[7] {r, x, y, w, h, cx, cy};
result = IntPtr.Zero;
return pos;
}

}
}