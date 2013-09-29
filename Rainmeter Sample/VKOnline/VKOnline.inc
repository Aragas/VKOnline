[Variables] 
URL=file://%APPDATA%\Rainmeter\Plugins\VKPlugin\OnlineUsers.tmp
URL1=http://vk.com
URL2=http://vk.com/images/camera_c.gif
FontColor=255, 255, 255, 255
FontColorOn=128, 192, 255, 255

[MeasureInfo]
Measure=Plugin
Plugin=Plugins\WebParser.dll
Url=#URL#
RegExp="(?siU)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&(.*)&.*"
-----------------------------------------------------------------------------------

[MeasurePlugin]
Measure=Plugin
Plugin=VKPlugin.dll
Type=OnlineInfo

-----------------------------------------------------------------------------------

[MeasureMessages]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=26
RegExpSubstitute=1
Substitute="1":"message.png","0":""

-----------------------------------------------------------------------------------

[MeasureUID1]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=1

[MeasureUID2]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=6

[MeasureUID3]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=11

[MeasureUID4]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=16

[MeasureUID5]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=21
==========================================

[MeasureOnlineIcon1]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=5
RegExpSubstitute=1
Substitute="1":"Online\mobile.png","0":""

[MeasureOnlineIcon2]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=10
RegExpSubstitute=1
Substitute="1":"Online\mobile.png","0":""

[MeasureOnlineIcon3]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=15
RegExpSubstitute=1
Substitute="1":"Online\mobile.png","0":""

[MeasureOnlineIcon4]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=20
RegExpSubstitute=1
Substitute="1":"Online\mobile.png","0":""

[MeasureOnlineIcon5]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=25
RegExpSubstitute=1
Substitute="1":"Online\mobile.png","0":""
==========================================

[MeasureImage1]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=4
Download=1

[MeasureImage2]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=9
Download=1

[MeasureImage3]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=14
Download=1

[MeasureImage4]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=19
Download=1

[MeasureImage5]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=24
Download=1
==========================================

[MeasureFName1]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=2

[MeasureFName2]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=7

[MeasureFName3]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=12

[MeasureFName4]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=17

[MeasureFName5]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=22

[MeasureLName1]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=3

[MeasureLName2]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=8

[MeasureLName3]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=13

[MeasureLName4]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=18

[MeasureLName5]
Measure=Plugin
Plugin=Plugins/WebParser.dll
Url=[MeasureInfo]
StringIndex=23
-----------------------------------------------------------------------------------

[TitleVK]
Meter=String
Text=ВКонтакте
X=60
Y=20
StringStyle=BOLD
FontFace=Calibri
FontSize=12
FontColor=250,250,250,255
AntiAlias=1
Hidden=1
LeftMouseUpAction=["#URL1#"]
MouseOverAction=[!SetOption "#CURRENTSECTION#" "FontColor" "#FontColorOn#"][!UpdateMeter #CURRENTSECTION#][!Redraw]
MouseLeaveAction=[!SetOption "#CURRENTSECTION#" "FontColor" "#FontColor#"][!UpdateMeter #CURRENTSECTION#][!Redraw]
==========================================

[StyleNames]
FontFace=Calibri
FontSize=11
FontColor=247,247,247,255
AntiAlias=1
Text=%1 %2
ClipString=1
StringStyle=BOLD
W=200
H=15
X=50
Y=30R
MouseOverAction=[!SetOption "#CURRENTSECTION#" "FontColor" "#FontColorOn#"][!UpdateMeter #CURRENTSECTION#][!Redraw]
MouseLeaveAction=[!SetOption "#CURRENTSECTION#" "FontColor" "#FontColor#"][!UpdateMeter #CURRENTSECTION#][!Redraw]

[MeterName1]
Meter=String
MeterStyle=StyleNames
MeasureName=MeasureFName1
MeasureName2=MeasureLName1
Y=20
LeftMouseUpAction=["http://vk.com/id[MeasureUID1]"]

[MeterName2]
Meter=String
MeterStyle=StyleNames
MeasureName=MeasureFName2
MeasureName2=MeasureLName2
LeftMouseUpAction=["http://vk.com/id[MeasureUID2]"]

[MeterName3]
Meter=String
MeterStyle=StyleNames
MeasureName=MeasureFName3
MeasureName2=MeasureLName3
LeftMouseUpAction=["http://vk.com/id[MeasureUID3]"]

[MeterName4]
Meter=String
MeterStyle=StyleNames
MeasureName=MeasureFName4
MeasureName2=MeasureLName4
LeftMouseUpAction=["http://vk.com/id[MeasureUID4]"]


[MeterName5]
Meter=String
MeterStyle=StyleNames
MeasureName=MeasureFName5
MeasureName2=MeasureLName5
LeftMouseUpAction=["http://vk.com/id[MeasureUID5]"]
==========================================

[StyleOnlineIcons]
X=53
Y=45r

[MeterOnlineIcon1]
Meter=Image
MeterStyle=StyleOnlineIcons
MeasureName=MeasureOnlineIcon1
Y=10

[MeterOnlineIcon2]
Meter=Image
MeasureName=MeasureOnlineIcon2
MeterStyle=StyleOnlineIcons

[MeterOnlineIcon3]
Meter=Image
MeasureName=MeasureOnlineIcon3
MeterStyle=StyleOnlineIcons

[MeterOnlineIcon4]
Meter=Image
MeasureName=MeasureOnlineIcon4
MeterStyle=StyleOnlineIcons

[MeterOnlineIcon5]
Meter=Image
MeasureName=MeasureOnlineIcon5
MeterStyle=StyleOnlineIcons
==========================================

[StyleImages]
PreserveAspectRatio=1
W=40
H=40
X=10
Y=45r

[MeterImage1]
Meter=IMAGE
MeasureName=MeasureImage1
MeterStyle=StyleImages
Y=10

[MeterImage2]
Meter=IMAGE
MeasureName=MeasureImage2
MeterStyle=StyleImages

[MeterImage3]
Meter=IMAGE
MeasureName=MeasureImage3
MeterStyle=StyleImages

[MeterImage4]
Meter=IMAGE
MeasureName=MeasureImage4
MeterStyle=StyleImages

[MeterImage5]
Meter=IMAGE
MeasureName=MeasureImage5
MeterStyle=StyleImages
==========================================

[MeterMessages]
Meter=Image
MeasureName=MeasureMessages
X=179
Y=26
LeftMouseUpAction=["http://vk.com/im"]