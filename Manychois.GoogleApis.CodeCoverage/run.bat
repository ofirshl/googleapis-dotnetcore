@ECHO OFF

SET DotNet="C:\Program Files\dotnet\dotnet.exe"
SET TargetDir=".\src\Manychois.GoogleApis.Tests"
SET OpenCover=".\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe"
SET ReportGenerator=".\packages\ReportGenerator.2.5.2\tools\ReportGenerator.exe"

SET DotNetArgs="test"
SET Filter="+[*]* -[xunit.*]* -[Manychois.GoogleApis.Tests]*"
SET OutputFile=".\Manychois.GoogleApis.CodeCoverage\bin\Debug\CodeCoverageResult.xml"
SET ReportDir=".\Manychois.GoogleApis.CodeCoverage\bin\Debug\Report"
SET HistoryDir=".\Manychois.GoogleApis.CodeCoverage\bin\Debug\History"

REM Working directory at solution level
CD ..

%OpenCover% -target:%DotNet% -targetargs:%DotNetArgs% -targetdir:%TargetDir% -output:%OutputFile% -filter:%Filter% -register:user -skipautoprops -oldstyle

%ReportGenerator% -reports:%OutputFile% -targetdir:%ReportDir% -reporttypes:Html;Badges -reports:%coveragefile% -historydir:%HistoryDir% -verbosity:Error

START chrome "%ReportDir%\index.htm"

REM (Optional) close the console window
EXIT