# Serilog sample usage in a WinUI project
Dependencies:

* CommunityToolkit.Mvvm
* CommunityToolkit.WinUI.Notifications
* CommunityToolkit.WinUI.UI
* CommunityToolkit.WinUI.UI.Controls
* Microsoft.Extensions.DependencyInjection
* Microsoft.WindowsAppSDK
* NETStandard.Library
* Serilog.Sinks.File



Structure:

* SerilogWinUISample: a WinUI project
* LoggerProject: Logger service project



Notes:

* This project uses Serilog to Log
* Logs wil be saved in %userprofile%\CRM_AppLogs path
* Only last 30 days logs will be kept!
* Log filesize limit disabled!
* This project shows windows notification for informing user of logging activity



Serilog and its extensions info:

* GitHub address:
  * https://github.com/serilog/serilog
  * Start date: Feb 10, 2013
  * Last commit date: Jan 24, 2022
  * Stars: 5.3K
  * Forks: 677
* Extensions:
  * Application Insight: 
    * Address: https://github.com/serilog-contrib/serilog-sinks-applicationinsights
    * Last commit date: Nov 12, 2021
  * File: 
    * Address: https://github.com/serilog/serilog-sinks-file
    * Last Commit date: Sep 21, 2021
