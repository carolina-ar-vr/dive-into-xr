# [Dive into XR with Unity](https://www.canva.com/design/DAF9onXCYgw/9DLdK4ZBMWq_j3zfLWbuTA/view?utm_content=DAF9onXCYgw&utm_campaign=designshare&utm_medium=link&utm_source=editor)
A Carolina AR/VR workshop that will enable you to build immersive experiences in Unity – created by Ashley Neall and Arryn O'Brien.

## An Introduction
This workshop introduces students to extended reality (XR) development within Unity – a popular game engine used to develop mobile AR, VR, and MR experiences for various platforms. With Unity's powerful capabilities, the possibilities are endless for XR applications! Today, we will create an underwater VR experience in Unity, using the XR Interaction Toolkit (XRI) and Android Build Support module _(so that we can build this app for Meta Quest devices)_. We'll begin with a conceptual overview of how Unity works _(i.e. what it hides 'behind the scenes' for us as developers)_ and its user-interface. Then we'll import some pre-created underwater assets _(e.g. sound effects, 3D models, textures)_ and start developing! Since this workshop is only one hour long, **you _must_ ENTIRELY complete the pre-workshop setup below BEFORE THE WORKSHOP BEGINS**!

## Pre-Workshop Setup
Please make sure to complete the following steps ***before* the workshop begins**, as you will not have time during the workshop. Don't worry, everything below is free:

### General Setup
1. Bookmark this repository (as you will be using its assets during _and_ after our workshop)!
2. Follow the [**Unity Setup**](https://github.com/carolina-ar-vr/dive-into-xr/blob/main/README.md#unity-setup) below.
3. Follow the [**Asset Setup**](https://github.com/carolina-ar-vr/dive-into-xr/blob/main/README.md#asset-setup) below. 
4. Watch this video on basics of XRI _(adding later)_
5. (Optional) Watch this tutorial to [design haptic experiences with bHaptics](https://www.youtube.com/watch?v=Pyq9GHdchzc).
6. (Optional) Watch this tutorial to [add spatial audio in Unity](https://www.youtube.com/watch?v=hNpNuDKSmgE&t=618s).
8. Come to the workshop – prepared with your **laptop** (with **Unity** and your **XR Assets** already setup), a **mouse**, and your excitement!

### Unity Setup
1. [Create a **Unity account**](https://id.unity.com/account/new). _Although it's not required, we also suggest activating a **free** [Student License](https://unity.com/products/unity-student), which basically gives you Unity Pro for free as a student!_
2. Download the [**Unity Hub**](https://unity.com/download); _this is the hub where you will be able to access your projects and install different modules_.
3. Install the latest **Unity Editor** LTS version _(as of February 2024, we suggest version **2022.3.18f1**)_
  a. When selecting the modules to install along with the Editor, make sure to also check off the following modules:
    * **Visual Studio** – _this is for your IDE, so that you can program interactions later!_
    * **Android Build Support** – _this includes modules needed to develop XR experiences for Android-based platforms (e.g. Quest 3, Quest Pro)_
      - OpenJDK
      - Android SDK & NDK Tools
    * _Feel free to add additional modules, though we will only need the ones listed above for the purposes of building for Meta Quest platforms_.
  <img width="1446" alt="Screenshot 2024-03-05 at 12 16 15 PM" src="https://github.com/carolina-ar-vr/dive-into-xr/assets/111532673/bc958eea-97ec-437c-b4bf-aab06d1c16fb">
  <img width="1022" alt="image" src="https://github.com/carolina-ar-vr/dive-into-xr/assets/111532673/f7ebbbb1-1b41-4282-bf48-c9416a00251d">
4. Make a new directory _(i.e. folder)_ called **Unity Projects** somewhere locally on your device where you can find it.

### Asset Setup
1. Download the [Scuba Diving FBX 3D Model](https://drive.google.com/file/d/1EQMjcjfbxa9RuM8i69xwxL5xSSQ-gdTU/view?usp=drive_link)
2. Download the [Underwater Skybox JPEG Image](https://drive.google.com/file/d/1isEe6SkgC_9Mxhk7Vd2-0688MWpNApuI/view?usp=sharing)
3. Download the [Ambient Underwater WAV Audio](https://drive.google.com/file/d/1HQQoTkU3Exndjyvla9tmJNw3v0Lyuzkv/view?usp=sharing)
4. Make a new directory _(i.e. folder)_ called **XR Assets** somewhere locally on your device where you can find it.
   - Make 3 new subdirectory _(i.e. folders within **XR Assets**_) and call them the following:
     - **3D Models**
     - **Textures**
     - **Sound Effects**

## Workshop Outline
Since this workshop only lasts for an hour, this will help gauge what we will spend our time on:
1. [Dive into XR with Unity introductory slides](https://www.canva.com/design/DAF9onXCYgw/9DLdK4ZBMWq_j3zfLWbuTA/view?utm_content=DAF9onXCYgw&utm_campaign=designshare&utm_medium=link&utm_source=editor) – 10 minutes
   - Introduction (3D Graphics + Game Engines)
   - Verify your development environment setup (**Unity**, **Visual Studio**, **Repository**)
   - Unity Hub Basics
   - Unity Programming Basics (**C# Scripting** + components)
2. Follow along in Unity – 40 minutes
   - Unity Project Setup + Version Control
   - Basics of Unity Editor
   - Navigating in a 3D scene
   - Adding assets
   - C# Script + Components _(swarm fish movement)_
   - Particle Effects _(bubbles)_
   - Testing _(more info about device emulator in Unity after the workshop)_
3. Experience XR _(Quest 2, 3, and Pro)_– 10 minutes
   - USB connection to development devices -> **Build and Run**
   - Navigate to **Unknown Sources** on Meta Quest -> run .apk app
4. Next Steps & Upcoming Events – 5 minutes
   - Join the Carolina AR/VR Discord for more guidance and inspiration!
   - Post-workshop resources
   - Upcoming Events

## Post-Workshop Feedback and Resources
* Finalized repository w/ Unity Project (will post after the workshop)
* Post-workshop resources (will post after the workshop)
* At the conclusion of this workshop, we encourage students to read the extra slides and explore linked resources as they ideate XR projects to work on this semester and in future semesters :) Feel free to reach out to me with any questions, and if this workshop has sparked an interest in XR and graphics, consider [joining Carolina AR/VR](https://linktr.ee/carvr)!

### Contact Information
* Ashley Neall – aneall@unc.edu
* Arryn O'Brien – arrynco@unc.edu
