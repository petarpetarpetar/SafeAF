# SafeAF

C# Password Manager project that I am currently working on for school.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.
Please see [server repo](https://github.com/petarpetarpetar/SafeAF-server) as well. You will need to set it up for yourself in order to run the code. Don't worry I will write detailed instructions on how to do so.

### Prerequisites

What things you need to install the software and how to install them:

- [Visual Studio for .NET develeopement](https://visualstudio.microsoft.com/vs/features/net-development/) if you are on Windows
or
- [Mono](https://www.mono-project.com/docs/about-mono/languages/csharp/) if you are on Linux

### Installing

Once you have installed your prefered environment just download/clone this repo with

```
git init
git clone https://github.com/petarpetarpetar/SafeAF.git
```

In order to run this successfully, you will need to download 'n' run safeAF server:
(see [the server repo](https://github.com/petarpetarpetar/SafeAF-server) (it is currently under construction))
```
git init
git clone https://github.com/petarpetarpetar/
```

tbw

### Running/Testing

#### Server side
You should first run the server either by running .exe or running it from IDE, you will be presented with something like this:
<img align="center" src="https://github.com/petarpetarpetar/SafeAF-server/blob/master/Resources/serverStart.PNG" width="80%" />
Note that it requires you to input server's mail password, you can use temp mail that I've set up for testing purpose only and that is "safeafpassword1". 

#### Client side
Once you have started the server you can start the client program, and it will look something like this:
<img align="center" src="https://github.com/petarpetarpetar/SafeAF-server/blob/master/Resources/clientStart.PNG" width="50%" />
As of yet I didn't implement any testing accounts, however I am planning on adding "test@example.com" with password "testpassword" as a test account, you can try to use these in case I didn't update this readme file.


##### Register form
<img align="center" src="https://github.com/petarpetarpetar/SafeAF-server/blob/master/Resources/registerStart.PNG" width="50%" />

## Built With

* [Visual Studio for .NET development](https://visualstudio.microsoft.com/vs/features/net-development/) - The IDE/Compiler used
* [Check-host](https://check-host.net/check-tcp?lang=en) - Web app used to test TCP connections of client and server
