; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{20CB23DF-1B0C-4E02-A2BE-64EE5BFC2AEB}
AppName=wxMudClient
AppVerName=wxMudClient 1.0
AppPublisher=Zeta Centauri
AppPublisherURL=http://zetacentauri.com/
AppSupportURL=http://basternae.org/
AppUpdatesURL=http://basternae.org/blog
DefaultDirName={pf}\wxMudClient
DefaultGroupName=wxMudClient
OutputBaseFilename=wxMudClientSetup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\Release\wxMudClient.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\tiles\*"; DestDir: "{app}\tiles"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: "vcredist_x86.exe"; DestDir: "{app}"; Flags: ignoreversion deleteafterinstall

[Icons]
Name: "{group}\wxMudClient"; Filename: "{app}\wxMudClient.exe"; WorkingDir: "{app}"
Name: "{group}\{cm:ProgramOnTheWeb,wxMudClient}"; Filename: "http://basternae.org/blog"
Name: "{commondesktop}\wxMudClient"; Filename: "{app}\wxMudClient.exe"; Tasks: desktopicon; WorkingDir: "{app}"
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\wxMudClient"; Filename: "{app}\wxMudClient.exe"; Tasks: quicklaunchicon; WorkingDir: "{app}"

[Run]
Filename: "{app}\vcredist_x86.exe"; Parameters: "/q:a"; WorkingDir: "{app}";  StatusMsg: "Installing Visual C++ 2010 Redistributable..."; Flags: waituntilterminated
Filename: "{app}\wxMudClient.exe"; Description: "{cm:LaunchProgram,wxMudClient}"; Flags: nowait postinstall skipifsilent

