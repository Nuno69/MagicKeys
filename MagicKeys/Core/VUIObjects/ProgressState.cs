﻿using System;

namespace MagicKeys
{
public partial class MagicKeys
{

public static string ProgressState(string Img, int X, int Y, int W, int H)
{
int[] S = ImgSearchArea(Img, P[1]+X, P[2]+Y, P[1]+X+W, P[2]+Y+H, 10);
if (S[0] == 1)
{
Speak((Convert.ToInt32((S[1]-P[1])/((W-X)/100))).ToString());
return ((Convert.ToInt32((S[1]-P[1])/((W-X)/100))).ToString());
}
else
{
Speak("0");
return "0";
}
}

}
}