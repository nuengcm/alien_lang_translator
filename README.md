# UBCO_alien_lang_translator Application
** Build Step ** 
After clone the repository on your device already. Please follow the process below to build the application file (.exe).
1. Make sure your computer has the following programs installed: .NET 8.0, IDE (such as VS, VSCode) or .NET Cli
2. Using IDE
	- open your project path with IDE
	- build project by IDE
	- The successfully built program is located at ..\bin\Debug\net8.0\UBCO_alien_lang_translator.exe
3. Using .NET Cli
	- open your command prompt or terminal and change directory to your project path.
	- type the command : dotnet build
	- The successfully built program is located at ..\bin\Debug\net8.0\UBCO_alien_lang_translator.exe
4. Run the exe file to test the program.

![image](https://github.com/nuengcm/UBCO_alien_lang_translator/assets/7628395/f1bdd9ac-cdbf-4d24-88fb-5a207c3bfe91)

Documentation
1. Solution
* validate receive input text
* using loop for shift each character
* For each loop work it can be described with sudo code as follows code.
	- result_text = "UBCO " , word_count = 1;
	- IF <char> is Vowel? => result_text + <char> + <char>;
	- ELSE IF <char> is Consonants? => {new_char = <char> + shift index by one; result_text + new_char;}
	- ELSE (<char> is other characters)
		IF is " "? => word_count = word_count + 1;
		ELSE => result_text + <char>;
	- result_text = result_text + word_count;
	- print result_text
	
2. Reasons for the technical decisions you have made
+ I choose the console application to create this project. Because the program require to receive text values for translate language. It not a complex business logic. Therefore, the console application was chosen because it can complete a small projects quickly. and light weight.
+ In the coding part ,"String.Contain()" method was use to check each letter. Because It is a simple and basic method easy for other developer to read
	I expected this program will receive text input value from the user's typing. It is expected that the number of characters will not be many.
	So there is no need to worry about performance. And if it is necessary to support a larger number of messages. I'm may have to switch to another method instead, such as comparing with stored HashSet or List of String etc.
- But there are limitations on the device to open it.

3. What other things you would implement if you had more time, or what
you would do differently in a ‘real world’ scenario

If I have more time to develop this program even better.
- Add upload file function to receive input by text files.
- Can export translated text to file(incase large messages).
- Add voice-to-text input and read the text with an AI voice output after it has been translated.
