SetMemoryMax(512)
SetMTMode(3,4)
LoadPlugin("D:\PooN\programming\Github\repositories\ZixEnc\bin\Debug\plugins\svpflow1.dll")
LoadPlugin("D:\PooN\programming\Github\repositories\ZixEnc\bin\Debug\plugins\svpflow2.dll")
Import("D:\PooN\programming\Github\repositories\ZixEnc\bin\Debug\plugins\InterFrame2.avsi")
DirectShowSource("<input:InRaw>", fps=23.976, audio=false, convertfps=true).AssumeFPS(24000,1001).ConvertToYV12()
SetMTMode(2)
#deinterlace
#crop
#denoise
#resize
InterFrame(Cores=4, GPU=true)