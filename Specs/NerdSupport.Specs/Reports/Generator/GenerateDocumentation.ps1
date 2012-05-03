#
# If the script requires signing, you could change your executionpolicy by using the following command
# 
# Set-ExecutionPolicy remotesigned
#

$scriptPath = $MyInvocation.MyCommand.Path
$dirPath = Split-Path $scriptpath
$dirPath = Split-Path -Parent $dirPath
$dirPath = Split-Path -Parent $dirPath
$dirPath = Split-Path -Parent $dirPath
$solutionDir = Split-Path -Parent $dirPath

Import-Module $solutionDir\Lib\Pickles.PowerShell\Pickles.PowerShell.dll
Pickle-Features -FeatureDirectory $solutionDir\Specs\NerdSupport.Specs -OutputDirectory $solutionDir\Specs\NerdSupport.Specs\Reports\Html -Language sv-SE -SystemUnderTestName NerdSupport -SystemUnderTestVersion 0.1 -TestResultsFile $solutionDir\Specs\NerdSupport.Specs\Reports\Generator\TestResult.trx -TestResultsFormat MsTest -DocumentationFormat Html

Read-Host