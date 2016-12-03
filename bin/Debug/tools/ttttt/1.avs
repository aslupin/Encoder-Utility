LoadPlugin("D:\Project zix\Zixmar+Fansub Encode Utility Version 0.4\plugins\vsfilter-aegisub32.dll")
LoadPlugin("D:\Project zix\Zixmar+Fansub Encode Utility Version 0.4\plugins\Convolution3DYV12.dll")
LoadPlugin("D:\Project zix\Zixmar+Fansub Encode Utility Version 0.4\plugins\VSFilterMod.dll")
DirectShowSource("D:\Zixmar+_Fs\Test Program\zix0.5\[SP] KanColle Nanchatte PV (WEB x264 aac 360p) [C8553F66].mkv", fps=59.940, audio=false, convertfps=true)

Convolution3D("animeHQ")
TextSub("D:\Zixmar+_Fs\Test Program\zix0.5\Pv.ass",1)
#TextSubMod("<input:PathAss>",1)
#trim(0,120)+trim(121,0).TextSub("<input:PathAss>",1)
#trim(0,120)+trim(121,0).TextSubMod("<input:PathAss>",1)


#test

