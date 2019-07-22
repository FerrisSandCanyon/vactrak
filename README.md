# VACTrak#
A multipurpose tool for managing Steam accounts
<table>
    <tr><td><b>State</b></td><td>Dev</td></tr>
    <tr><td><b>Version</b></td><td>0.1.0</td></tr>
    <tr><td><b>Latest Release</b></td><td>N/A</td></tr>
    <tr><td><b>License</b></td><td>GPL 3.0</td></tr>
</table>

<img src="ss.png"/>

## Requirements
* <a href="https://dotnet.microsoft.com/download/dotnet-framework">.NET Framework</a> (4.5 or <b>Higher</b>)

## (Planned) Features
* Multiple Loadable Profiles for different set of accounts.
* Auto-Login
* Cooldown Tracker
* Profile Editor
* Protection of information (Encryption/Obfuscation + Hashing)
* Easily import accounts from <a href="https://github.com/Ashesh3/Steam-Account-Generator">Steam Account Generator</a>
* Directly generate accounts from  <a href="https://accgen.cathook.club">Cathook's Account Generator</a>

## Configuring VACTrak#
You can configure VACTrak# through the options form or manually through the <i>config.json</i> file located at the base of VACTrak#.

```json
{
    "steamPath":"C:/Program Files (x86)/Steam",
    "defaultProfile":"default",
    "cooldownRefresh":500,
    "forceStatus":false
}
```

## Importing from <a href="https://github.com/Ashesh3/Steam-Account-Generator">Steam Account Creator</a>
* You can import accounts generated by SAC through SAC's <i>accounts.txt</i> account dump.
* Make sure you are atleast running SAG <b>v1.1.2-pre7</b> or higher.
* Make sure you are using the <i>"Original Formatting"</i> format. You can change this at the "File Writing" Tab
* Make sure that the <i>accounts.txt</i> dump is properly formatted.
* Make sure that "Write to file" is checked.

<img src="ss2.png"/>

## Licenses / Built with / Credits
* Json .NET (<a href="https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md">MIT License</a>)
* StatTrak Logo - Valve
* Flat Icons + Graphics - <a href="https://www.flaticon.com/">FlatIcon</a> (Creative Commons)

## Development
### Prerequisite
* <a href="https://www.newtonsoft.com/json">Json .NET</a> Framework for handling the Json format. (<a href="https://www.nuget.org/packages/Newtonsoft.Json/">NuGet</a>)
