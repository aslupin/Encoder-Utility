LoadPlugin("D:\Project zix\Zixmar+Fansub Encode Utility Version 0.4\plugins\vsfilter-aegisub32.dll")
LoadPlugin("D:\Project zix\Zixmar+Fansub Encode Utility Version 0.4\plugins\Convolution3DYV12.dll")
LoadPlugin("D:\Project zix\Zixmar+Fansub Encode Utility Version 0.4\plugins\VSFilterMod.dll")
DirectShowSource("<input:InRaw>", fps=59.940, audio=false, convertfps=true)

Convolution3D("animeHQ")
<input:Textsub>
#test
