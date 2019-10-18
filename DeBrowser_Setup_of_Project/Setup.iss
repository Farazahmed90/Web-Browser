; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "DeBrowser"
#define MyAppVersion "1.0"
#define MyAppPublisher "DeTech, Inc."
#define MyAppExeName "Web_Browser.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{2B329D8A-DCA0-4FA9-B1FA-8F72FAFEE96B}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
LicenseFile=E:\Licence.txt
InfoBeforeFile=E:\Licence.txt
InfoAfterFile=E:\ReadMe.txt
OutputDir=C:\Users\Abdul Moid\Desktop\Setup
OutputBaseFilename=Setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "french"; MessagesFile: "compiler:Languages\French.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"
Name: "turkish"; MessagesFile: "compiler:Languages\Turkish.isl"
Name: "ukrainian"; MessagesFile: "compiler:Languages\Ukrainian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "C:\Users\Abdul Moid\Desktop\Release\Web_Browser.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Abdul Moid\Desktop\Release\Bussiness.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Abdul Moid\Desktop\Release\Data.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Abdul Moid\Desktop\Release\Model.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Abdul Moid\Desktop\Release\Web_Browser.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Abdul Moid\Desktop\Release\DeBrowser\*"; DestDir: "C:\Users\Public"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
