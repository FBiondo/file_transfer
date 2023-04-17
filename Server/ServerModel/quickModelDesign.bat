SET SERVER_MODEL=%cd%
cd "..\..\Model Compiler\build\bin\Release\net6.0"
.\Opc.Ua.ModelCompiler.exe compile -d2 %SERVER_MODEL%\ModelDesign.xml  -cg  %SERVER_MODEL%\Compile\ModelDesign.csv -o2  %SERVER_MODEL%\Compile\
pause