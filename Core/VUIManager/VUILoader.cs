using System;
using System.IO;
using System.Collections.Generic;

namespace MagicKeys
{
    public partial class MagicKeys
{

public static void VUILoader(string File)
{
KeyUnReg();
VUIKeys.Clear();
SoundPlay("ChangeVUI.ogg", 0);
string VUIFile = @"VUI\"+File;
PluginsList[0]["VUI"] = @File;
PluginsList[0]["PClass"] = GetFullClassName(Ini.IniRead(VUIFile, "Info", "PClass"));
if (Ini.IniRead(VUIFile, "Info", "BClass") == "None")
{
PluginsList[0]["BClass"] = "None";
}
else
{
PluginsList[0]["BClass"] = GetFullClassName(Ini.IniRead(VUIFile, "Info", "BClass"));
}
PluginsList[0]["VUIName"] = Ini.IniRead(VUIFile, "Info", "VUIName");
PluginsList[0]["ActiveKey"] = Ini.IniRead(VUIFile, "Info", "ActiveKey");
Count = Ini.IniCountSections(VUIFile)-1;
if (Ini.IniSectionExists(VUIFile, "Keys") == true)
{
Count = Ini.IniCountSections(VUIFile)-2;
}
VUIObjects.Clear();
for (int I = 1; I <= Count; I++)
{
VUIObjects.Add(I, new Dictionary<string, string>());
VUIObjects[I].Add("Active", "true");
VUIObjects[I].Add("Text", Ini.IniRead(VUIFile, I.ToString(), "Text"));
VUIObjects[I].Add("ObjectType", Ini.IniRead(VUIFile, I.ToString(), "ObjectType"));
VUIObjects[I].Add("Help", Ini.IniRead(VUIFile, I.ToString(), "Help"));
if (Ini.IniKeyExists(VUIFile, I.ToString(), "AutoFunc") == true)
{
VUIObjects[I].Add("AutoFunc", Ini.IniRead(VUIFile, I.ToString(), "AutoFunc"));
}
VUIObjects[I].Add("Func", Ini.IniRead(VUIFile, I.ToString(), "Func"));
if (Ini.IniKeyExists(VUIFile, I.ToString(), "Param") == true)
{
VUIObjects[I].Add("Param", Ini.IniRead(VUIFile, I.ToString(), "Param"));
}
if (Ini.IniKeyExists(VUIFile, I.ToString(), "Key") == true)
{
VUIObjects[I].Add("Key", Ini.IniRead(VUIFile, I.ToString(), "Key"));
}
}
VUIObjectsUpdate(true);
KeyLoader();
KeyReg();
}

}
}