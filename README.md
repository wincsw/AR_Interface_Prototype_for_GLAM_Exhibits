# AR Interface Prototype for GLAM Exhibits

## Description
The AR Interface Prototype for GLAM (Galleries, Libraries, Archives, and Museums) Exhibits is an augmented reality (AR) solution designed to enhance visitor engagement and educational outcomes within exhibit spaces. The project focuses on leveraging AR technology to provide an interactive interface for displaying exhibit information in various multimedia formats, including audio, text, and images. By integrating AR elements, the prototype aims to elevate the visitor's engagement level while maintaining the focus on the exhibited pieces.

## Features
### QR Code Tracking and Object Placement
The QR code tracking feature is a crucial component of the AR interface prototype. It allows for precise placement of virtual components in the real-world environment. The QR code tracking is controlled by the QR code SDK and consists of three main game objects: QR code manager, QR code panel, and QR code visualizer.

### AR Interactive Components
The prototype includes various interactive components designed to enhance user engagement. These components include buttons and slates for displaying information about exhibited pieces. Hand gesture controls are used for interaction with these components.

### Hand Gesture Control
Hand gesture control is utilized for interaction with virtual elements within the AR environment. Two types of gesture input models, point and commit, and direct manipulation, are supported. These gestures enable users to interact with virtual objects using natural hand movements.

## Tech Stack and Hardware
- **Development Platform**: Unity 2020.3.37f1
- **Programming Language**: C#
- **AR Headset**: Microsoft HoloLens 2
- **AR Toolkit**: [MRTK2](https://learn.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/mrtk2/?view=mrtkunity-2022-05)
- **QR Code SDK**: [NuGet package for QR code tracking](https://www.nuget.org/Packages/Microsoft.MixedReality.QR)
- **XR Platform**: Windows Mixed Reality
- **Hand Gesture Control**: Built-in hand tracking feature of Microsoft HoloLens 2

## Installation

###Quick Install: 
1. Clone the project repository from GitHub.
2. Open file `Build/AR_Exhibit_Interface.sln` with Visual Studio.
3. Connect your Microsoft HoloLens 2 device to your development machine.
4. Choose Solution Configuration as **_Release_** and Solution Platform as **_ARM64_**.
5. Deploy project on HoloLens 2 by **_Start Without Debugging_**.
6. Put on the HoloLens 2 device and open application named **_AR Exhibit Interface_**

###Full Install:
1. Ensure you have **Unity 2020.3.37f1** installed on your development machine.
2. Clone the project repository from GitHub.
3. Open the project in Unity.
4. Go to **_Build Setting_** and build the project in an empty folder.
5. Open file `AR_Exhibit_Interface.sln` the folder the build is placed with Visual Studio.
6. Follow step 3-6 of Quick Install.
