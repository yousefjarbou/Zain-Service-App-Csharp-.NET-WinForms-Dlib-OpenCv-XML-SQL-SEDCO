# Zain Service App C#-.NET-WinForms-Dlib-OpenCv-XML-SQL SEDCO

This project was developed during my internship at SEDCO in the summer of 2024. It is a comprehensive customer service application designed to manage user data and streamline customer interactions. The project highlights my strong object-oriented programming (OOP) skills, advanced use of technologies, and ability to create flexible, scalable systems.

## Features

### **User Management:**
- Add, update, and delete customer profiles with detailed information.
- Verify customer activity based on subscription balance and expiry.

### **Package Management:**
- Manage SIM packages with details such as price, monthly fees, and type (prepaid/postpaid).
- Automatically handle the addition or removal of packages without requiring code changes.

### **Face Detection and Real-Time Verification:**
- Integrated a custom DLL built with OpenCvSharp and Dlib for face detection.  
- Differentiates between real users and static images by monitoring eye blinks, ensuring secure authentication.  
- For more details about this feature, see my [**Real vs. Static Face Detection Repository**](https://github.com/yousefjarbou/wallet-manager-Flutter).

### **Scalable OOP Design with Data Managers:**
- Built data managers to abstract the underlying implementation, enabling seamless switching between XML and SQL data storage.  
- This design, based on the **Single Responsibility Principle** and **Open-Closed Principle** in OOP, ensures that changes in one module (e.g., database) do not affect the entire system.  

### **XML and SQL Implementations:**
- Implemented XML-based storage for users and packages, with a design ready to integrate SQL for scalability.
- Provided robust data management features like retrieval, updates, and structured storage.

### **Modern UI:**
- Designed using Windows Forms for a responsive and dynamic user interface.  
- Demonstrated my ability to convert designs from concept to code by replicating Zain’s branding, including colors, logos, and layout patterns from their website.

## Technology Stack

- **Programming Language:** C#  
- **Framework:** .NET Framework  
- **Libraries:**  
  - **OpenCvSharp:** For face detection and image processing.  
  - **DlibDotNet:** For advanced blink detection and authentication.

## Videos

- [**App Testing Video**](https://youtu.be/5NQG6BgDbJw?si=6LRKsrf-UEa1_Io-) 
  *(A demonstration of the full application, including user and package management.)*  

- [**Face Detection DLL Testing Video**](https://youtu.be/QTPNf8ESYG4?si=qLKEbVo-wByAEj2G)
  *(A demonstration of the standalone face detection module using OpenCvSharp and Dlib.)*  

## Highlights

### **Custom Face Detection Module:**
The face detection module was implemented as a standalone DLL, making it reusable across different projects. It uses Dlib for precise eye tracking and OpenCvSharp for image processing. For more details, check out my [**Real vs. Static Face Detection Repository**](https://github.com/yousefjarbou/wallet-manager-Flutter).

### **Flexible and Maintainable Design:**
The application was built to dynamically adapt to changes, such as new packages or database types, without requiring major code modifications. My focus on maintainability ensures minimal effort for future updates.

### **Professional Application:**
Developed as part of my SEDCO internship, this project showcases my ability to deliver practical, high-quality solutions in a professional setting.

## Future Enhancements

- Fully integrate SQL for data storage to handle large-scale operations.  
- Add transaction history and analytics features.  
- Expand language support for a broader user base.

## Full Code
You can find the full code here: [**Full Project**](https://drive.google.com/drive/folders/1WGbpk7Qif8fS0jtQaUIng2wrPLTq7gP3?usp=sharing)




