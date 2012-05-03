if Exist TestResult.trx del TestResult.trx 

"%ProgramFiles(x86)%\Microsoft Visual Studio 10.0\Common7\IDE\mstest.exe" /testcontainer:../../bin/debug/NerdSupport.Specs.dll /resultsfile:TestResult.trx 

"%ProgramFiles(x86)%\TechTalk\SpecFlow\SpecFlow.exe" mstestexecutionreport ../../NerdSupport.Specs.csproj /testResult:TestResult.trx /out:../Html/ImplementationReport.html

pause
