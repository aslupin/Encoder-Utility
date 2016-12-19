Import("D:\PooN\programming\Github\repositories\ZixEnc\bin\Debug\tools\ffms2\FFMS2.avsi")
LoadPlugin("D:\PooN\programming\Github\repositories\ZixEnc\bin\Debug\tools\ffms2\x64\ffms2.dll")
LoadPlugin("D:\PooN\programming\Github\repositories\ZixEnc\bin\Debug\plugins\vsfilter-aegisub32.dll")
LoadPlugin("D:\PooN\programming\Github\repositories\ZixEnc\bin\Debug\plugins\MSharpen.dll")
LoadPlugin("D:\PooN\programming\Github\repositories\ZixEnc\bin\Debug\plugins\aWarpSharp.dll")

awarpsharp(12,2)
msharpen(3,85) 

FFMpegSource2("<input:InRaw>")
<input:Textsub>