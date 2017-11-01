#  
# Module manifest for module '%MODULE-NAME%'  
#  
# Generated by: Microsoft Corporation  
#  
# Generated on: %DATE%
#  

$PSDefaultParameterValues.Clear()
Set-StrictMode -Version Latest

# Import dependencies using required version, if it is allowed
if ($PSVersionTable.PSVersion.Major -ge 5)
{
%STRICT-DEPENDENCIES%
}
else
{
%DEPENDENCIES%
}

$nestedModules = %NESTED-MODULES%

$AllCmdlets = @()
$nestedModules | ForEach-Object {
    $dllPath = $_
    $Assembly = [Reflection.Assembly]::LoadFrom($dllPath)
    $dllCmdlets = $Assembly.GetTypes() | Where-Object {$_.CustomAttributes.AttributeType.Name -contains "CmdletAttribute"}
    $AllCmdlets.Add($dllCmdlets)
}

$FilteredCommands = @()
$AllCmdlets | ForEach-Object {
	$rgParameter = $_.GetProperties() | Where-Object {$_.Name -eq "ResourceGroupName"}
	if ($rgParameter -ne $null) {
		$parameterSets = $rgParameter.CustomAttributes | Where-Object {$_.AttributeType.Name -eq "ParameterAttribute"}
		$isMandatory = $true
		$parameterSets | ForEach-Object {
			$hasParameterSet = $_.NamedArguments | where {$_.MemberName -eq "ParameterSetName"}
			$MandatoryParam = $_.NamedArguments | where {$_.MemberName -eq "Mandatory"}
			if (($hasParameterSet -ne $null) -or (!$MandatoryParam.TypedValue.Value)) {
				$isMandatory = $false
			}
		}
		if ($isMandatory) {
			$FilteredCommands += $_
		}
	}
}

$FilteredCommands | ForEach-Object {
	$input = $_.GetCustomAttributes("System.Management.Automation.CmdletAttribute").VerbName + "-" + $_.GetCustomAttributes("System.Management.Automation.CmdletAttribute").NounName + ":ResourceGroupName"
	$global:PSDefaultParameterValues.Add($input,
		{
			$context = Get-AzureRmContext
			if ($context.ExtendedProperties.ContainsKey("Default Resource Group")) {
				$context.ExtendedProperties["Default Resource Group"]
			} 
		})
}
