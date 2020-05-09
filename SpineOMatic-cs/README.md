SpineOMatic is a Windows application that works with Ex Libris' Alma to print spine labels, pocket labels, flag slips and other custom labels to a variety of desktop or networked printers, singly or in batches.

* Operation is simple--scan or type an item number, and SpineOMatic gets the label record from Alma and prints a label.
* SpineOMatic is flexible--print to any printer with a Windows print driver, singly or in batches.
* Let Ex Libris parse the label, or let SpineOMatic parse your LC, NLM, SuDoc or other label formats.
* Add holdings info to the label, as well as any other field in the Alma label record.
* Add Label Prefixes (REFERENCE, MEDIA, OVERSIZE, etc.) based on library and shelving location.
* Create spine labels, flag slips, pocket labels or custom labels using any data in the Alma label record.
* View reports of labeling activity for each workstation.
* Updates are easy--SpineOMatic will let you know if a new version is available, and install it automatically.

## System Requirements
An installation of Ex Libris' Alma
Credentials to access the Alma Label Print Web Service, including the path to the Alma server, an authorized user name, password and Ex Libris Institution Code
* A PC running Windows 7(preferred), Vista or XP.
* An up-to-date version of the .Net Framework (4 or higher)
* An up-to-date version of Java (1.7.xx or higher) is required to use the deprecated "SOAP" access method.
* An API key from Ex Libris

## Installation Instructions

Download [`SpineLabeler.exe`](https://github.com/ExLibrisGroup/SpineOMatic/releases/tag/v8.0.0) into an empty directory. Click the application to launch.

The User's Manual can also be downloaded and viewed from SpineOMatic's "About" box. It contains a Quick Start guide that will help you get SpineOMatic installed quickly and easily.

## Changelog

DNS v.8.1
* Moved changelog to README.md
* Created CSharp project with UI. Renamed projects to SpineOMatic-cs and SpineOMatic-vb.
___

v. 8.0: Major release
* Includes checking GitHub for new version and linking to GitHub wiki for documentation. Removed references to BC license and server.

___

v. 7.0: Major release
* Includes option to use Alma's RESTful API URL to retrieve an item's XML file, as
well as the deprecated Java SOAP APIs.  The RESTful XML file is converted into
the SOAP XML format so that SpineOMatic can process the file without major 
modification to the software.

___

v. 6.12: Minor trial release
* Allows the ! (render as bar code) formatting code to be used in custom Pocket Labels.
Will be distributed to one user who wanted the feature, and included in subsequent
releases if it is acceptable.
        
v. 6.11: Minor release
* Clarified and changed LC/LC child lit./NLM and Dewey parsing behavior:
Tweak and Test panel for the LC... parser: "Decimal" break description was changed to
"Class Decimal".  Fixed a bug in "Break before decimal" that was causing a break
after the decimal rather than before. An option was added to allow break both before
or after the decimal.
* An option was added to the Dewey parser to allow breaking on the cutter decimal
string after a specific number of characters following the decimal.

v. 6.1: Minor release
* Fixed bug in "*" format code ("Suppress field display");
Added check for unbalanced quotation marks in "Quoted text" format code.

v. 6.0: Major release features:
* Holdings processor now lets user select no holdings, textual holdings parsed by SpineOMatic, or Ex Libris' Parsed Holdings fields.  If Parsed Holdings are specified but do not exist, SpineOMatic will parse the textual holdings.  The display will indicated which call number parser was used, and also which holdings parser was used.
* Asterisk (*) formatting code ("suppress" field display) suppresses display if the XML field is blank, or if the field is equal to any of three user-defined values.
* Tweak and Test SuDoc parser allows breaking on "Other" characters, with option
to remove characters. (Behavior is consistent with LC, Dewey and Other parsers.)
Dewey parser provides an option to print long numeric class numbers in groups of characters.
* New print option to send label text to a custom DOS batch file ("viados.bat"), which can print to legacy printers attached via LPT or COM ports, etc.
* Margins and line spacing can be entered in inches or centimeters.
* A decimal point or a comma can represent decimal fractions. Allows negative top margin and left margin settings. To insert XML field names into text boxes that allow it, items can be selected from a list of all XML fields (rather than typing the names).

___

v. 5.21: Minor release to handle unencoded ampersands in the item's XML record.
* Added the tilde (~) character to stand for space characters in the Tweak and Test 
Other Break text strings.
* Changed the "Hide cutter decimal" routine from removing all decimals to removing only
the first character, if it is a decimal.

v. 5.2: Minor release to fix a bug in the multi-label print to Desktop routine, which failed to
        change the print button from "Stop" to "Send to Desktop Printer".

v. 5.1: Minor release to fix the Holdings parser, which was causing spaces between elements
        to be removed.
* A "Break on spaces" checkbox was added to the Holdings parser's Tweak and Test panel;
Made improvements to the management of default settings for Spine, Custom, Custom/Flag slips and Pocket Labels
* A "copy to clipboard" feature was added to send Report text and CurrentXML/settings.som
text to the Windows clipboard.

v. 5.0: Major release to add Pocket Label printing; Repairs errors due to unencoded angle bracket characters appearing in the data of returned XML files.
Does not check the arc.bc.edu:8080 server at startup, but only when Check for
Updates is clicked.  (Due to occasional arc crashes that prevent SpineOMatic from
starting.)
Allows any call_number_type to be handled by any of SpineOMatic's parsing routines. 
Blank <call_number_type> can be converted to any specified type (0 - 8).
* Added option to the LC Tweak and Test panel to suppress the decimal that normally
precedes the cutter.
* Added a Holdings parser to the Tweak and Test panels.
Call number formats (Spine, Custom & Custom w/Flag Slips and Pocket Labels) each 
have their own separate set of margin settings and other defaults.
* Added formatting characters "^" to suppress newline after field, "*" to
suppresse display of a field if it is blank or zero, and "+" to look up <location_name>
in the Label Prefixes table and use the label text (that allows line breaks via semicolons).  
Increased maximum number of label copies from 5 to 99. 
* Added a "cancel print" option for Desktop printing, and added a warning for Batch 
and FTP printing if more than 5 label copies are requested.
* Added keyboard shortcut CTRL p to trigger a manual print without having to use 
the mouse.  
* Added a License Agreement that requires the user to either accept terms or cancel 
installation on first use of software, change of version, or relocation to a different PC.

___

v. 4.32: Minor release to fix wrapping (if wrapping was turned on for one field, it
stayed on for other fields that did not specify wrapping).  Added a formatting
code to add a text prefix to custom label fields, as well as to Spine fields
"Include holdings" and "Include other value".  Double quotes around text cause
text to be prefixed to the printed value. Eg: "copy: "<copy_id>
Redid the fix (originally in v. 4.3) that was supposed to prevent loss of Custom
fields upon saving.  

v. 4.31: Minor release to fix a bug that prevented "Include holdings" from working. This is the first release to use two digits after the decimal of the release number.

v. 4.3: Fixed a bug causing multi-cuttered LC call numbers to hide the decimal when
breaking on cutter.  Fixed bug that caused Custom fields to be lost when
user saved settings while Flag Slips checkbox was checked.
Replaced code written to parse the Ex Libris XML file with VB.NET's XML parser.
Also alerted user if errors were detected in
user-specified XML fields, i.e., not found, extraneous characters, etc.  
Checkbox added to either display error alert only, or to pop up a detailed message. 
Added ability for user to add formatting characters to Custom fields:
(%=parse call#, #=parse holdings, !=render as barcode, ~=add space) before entry. 
Also allowed space (~) to be added before "Other" field in Spine label section.
Added multi-label print capability, allowing label to be printed from 1 to 5 times.
        
v. 4.2: Fixed a bug to allow SpineOMatic to recognize international date settings. 
Added Tweak and Test panel to allow user to modify the behaviors of
SpineOMatic's parsing routines.
Added a Dewey Decimal and an "Other" parser.
Moved the Test Parsing section from Java Setup to
the Tweak and Test Parsing panel.  Removed the portrait/landscape distinction
when SpineOMatic parsed SuDoc numbers.  User can now set up parsing for one or
the other.
Added better checking for Java URL problems and credential issues.
If the customer's PC cannot connect to BC servers due to blocking by their 
proxy server, a message tells them to whitelist the BC servers.

v. 4.1: Changes to wording and layout of Print Flag Slips checkbox and Label Printing
Web Service Credentials. 

v. 4.0: Removed need to provide a folder to receive Alma XML file.  The installation
directory will be used by default;
Imported graphic background for the About box that contains the BC seal graphic; 
Java app class file and alma-sdk files are now automatically downloaded if needed, 
without manual intervention;
Added separate margin/orientation/maximum settings for Flag Slips.  Toggling the 
"print flag slips" checkbox calls up Flag Slip settings or returns to standard settings;
The Java application is now run as a process from within vb rather than as an
external .bat file. Java installation is verified, and problems locating or 
accessing java are reported to the user.
A list of servers can be specified from which to obtain updates (i.e., the updatePath.
If the default server fails, each server in the list is tried in turn to try to find
a working server.  If none can be found, a "fail" message is displayed.
___

v. 3.3: Added SuDoc parsing for portrait and landscape modes; Changes to error checking
        and AboveCall#Text behavior; 

v. 3.2: Added ability to put an additional field (e.g., <copy_id>) at end of spine label;
        Ensured label text in OutputBox does not end with unnecessary cr/lf;
        Fixed bug in Above Call# Text that produced incorrect matching.
        Limited User ID to 8 alpha characters.

v. 3.1: Added Station name and User ID; Reports; Test Parsing; better LC/LC Children's lit/NLM
        call number parsing.

v. 3.0: Cosmetic changes to admin panels; added "About" box with download/view
        of associated documentation. Added access to Alma Label Printing Web Service
        via desktop java app; Added option to use Ex Libris parsed call numbers.

___

v. 2.6: for "Custom" labels, text not enclosed in angle brackets (<...>) will print as-is on the label
        Bug fix: manual print button now checks line lengths against max. chars/line;

v. 2.5: adds textbox for url to Alma Label Printing Web Service

v. 2.4: adds barcode font dialog selection for use in flag slips;

v. 2.3: dlgSettings.UseEXDialog = True to enable print dialog selection in Windows 7

v. 2.2: corrects spacing & punctuation errors in incoming call numbers (for TML);

v. ...: 