; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "TelegramBot"
#define MyAppVersion "1.0"
#define MyAppPublisher "My Company, Inc."
#define MyAppURL "http://www.example.com/"
#define MyAppExeName "TelegramBot.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{4FE66E6D-2198-446D-A36B-C52D5C9CA795}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableDirPage=yes
DefaultGroupName={#MyAppName}
OutputDir=C:\IndustrialMonitoring\TelegramBot\Inno
OutputBaseFilename=TelegramBot
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\TelegramBot.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\BACnetLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\BACnetLib.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\EntityFramework.SqlServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\EntityFramework.SqlServer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\EntityFramework.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\MathNet.Numerics.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\MathNet.Numerics.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\MonitoringServiceLibrary.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\MonitoringServiceLibrary.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\NationalInstruments.Common.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\NationalInstruments.Common.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\NationalInstruments.MStudioCLM.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\NationalInstruments.NetworkVariable.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\NationalInstruments.NetworkVariable.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\NationalInstruments.NiLmClientDLL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\SharedLibrary.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\SharedLibrary.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\System.Net.Http.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\System.Net.Http.Extensions.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\System.Net.Http.Formatting.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\System.Net.Http.Formatting.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\System.Net.Http.Primitives.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\System.Net.Http.Primitives.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\Telegram.Bot.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\TelegramBot.application"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\TelegramBot.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\TelegramBot.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\TelegramBot.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\TelegramBot.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\TelegramBot.vshost.application"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\TelegramBot.vshost.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\TelegramBot.vshost.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\IndustrialMonitoring\TelegramBot\bin\Release\TelegramBot.vshost.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon