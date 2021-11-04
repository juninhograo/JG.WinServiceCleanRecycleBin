# Windows Service for Recycle Bin
Creating a robot to recycle the Windows bin once a day or for a customized time

<h3>Options</h3>

![image](https://user-images.githubusercontent.com/5727040/140395533-5cdba656-c660-4b97-97e5-35d33bef73dc.png)
- SERVICE_NAME - The name of the Service. The Default value is "JG_RecycleBinRobot";
- SERVICE_DISPLAY_NAME - The display name in the Windows Services app. The Default value is "JG Reclycle Bin Robot";
- SERVICE_DESCRIPTION - The description that will be shown in the Windows Services app. The Default value is "JG Reclycle Bin Robot";
- MINUTES - How much time the robot will wait for the next task. The Default value "60";
- TIME_TO_START - The robot will run since this time. The Default value is "09:00:00 AM";
- TIME_TO_END - The robot will run until this time. The Default value is "10:00:00 PM";


<h3>Installation</h3>
- Download and unzip the package in the best place you need. Run the file "JG.RecycleBinRobot.exe"

![image](https://user-images.githubusercontent.com/5727040/140397230-7ddc3143-6840-45e5-a407-eac27ce28818.png)


<h3>Installation App as a Windows Service</h3>
- Open the Windows CMD as Administrator
- Run the command to open the folder where the files where unzipped, ex: cd C:\tmp 
- Press the Enter key
- Run the command to install the app as a Windows Service: JG.RecycleBinRobot.exe install start
- Press the Enter key
![image](https://user-images.githubusercontent.com/5727040/140396325-1a20dacf-9f20-4bbe-8907-63db185f36b6.png)

- Go to Service Service and make sure the app is running there:
![image](https://user-images.githubusercontent.com/5727040/140398716-7d61b74f-3f09-45ea-b9aa-7265fafa38c8.png)


<h3>Uninstall</h3>
- Open the Windows CMD as Administrator
- Run the command to open the folder where the files where unzipped, ex: cd C:\tmp 
- Press the Enter key
- Run the command to uninstall the app as a Windows Service: JG.RecycleBinRobot.exe uninstall
- Press the Enter key
![image](https://user-images.githubusercontent.com/5727040/140399350-3415b99d-afa0-4ccd-a884-75f751973d02.png)


<h3>References</h3>
Tim Corey: https://www.youtube.com/watch?v=y64L-3HKuP0&t=171s

Abhishek Kumar Ravi: https://www.c-sharpcorner.com/UploadFile/167ad2/empty-recycle-bin-using-C-Sharp/
