# RealTransWebApi

# **Prerequisites**

 -   **Supported Operating System:**  Windows 10 or later (64-bit) recommended. Check system requirements:  [https://learn.microsoft.com/en-us/visualstudio/releases/2022/system-requirements](https://learn.microsoft.com/en-us/visualstudio/releases/2022/system-requirements)  for full details.

-   **Disk Space:**  Minimum of 8 GB for the core install, more if you select additional workloads.
-   **Internet Connection:**  Required for download and installation.

**Installation**

1.  **Download Installer:** Get the latest Visual Studio 2022 Community Edition installer from the official Microsoft website: [https://visualstudio.microsoft.com/downloads/](https://visualstudio.microsoft.com/downloads/)
    
2.  **Run Installer:**
    
    -   Double-click the downloaded installer file (e.g.,  `vs_community.exe`).
    -   If prompted, allow it to make changes.
3.  **Workloads Selection:**
    
    -   **Essential Workload:**  Select ".NET desktop development" and "web development". This will include the core .NET components.
4.  **Individual Components:** (Optional)
    -   Under the "Individual components" tab, you can fine-tune your installation.
    -   Search for ".NET 8.0" and ensure the ".NET 8.0 Runtime" and ".NET 8.0 SDK" are checked, if not already selected by the workload.
5.  **Install:** Click "Install" and wait for the installation to complete.


# Project Structure
**API Folder**

This folder likely contains the core ASP.NET Web API application logic.

-   **Controllers** Folder likely contains controller classes that handle incoming API requests, process data, and return responses.
    
    -   **AccountsController.cs:**  This file  `AccountsController`  class that handles requests related to user accounts.
        -   The naming convention suggests it might be responsible for actions like creating, reading, updating, and deleting (CRUD) accounts.
    -   **CustomersController.cs:**  This file  `CustomersController`  class that deals with customer data.
        -   Similar to  `AccountsController.cs`, it might handle CRUD operations on customer information.
    -   **DesignGAController.cs:**  The purpose of this controller is to managing Design GAs, which could be a specific feature of the application.
    -   **MenusController.cs:**  This file  `MenusController`  class that deals with menu data, potentially for managing menus within the application.
    -   **BaseApiController.cs:**  This file might hold a base class for the API controllers, providing common functionality or properties inherited by the specific controllers.
-   **Extensions** Folder likely contains extension classes that add functionality to the core ASP.NET Web API framework.
    
    -   **AddSwaggerExtension.cs:**  This file might add Swagger integration for API documentation.
    -   **AppExtensions.cs:**  This file contain general application-level extensions.
-   **Log** Folder logging configuration or code for the application.
    
    -   **ErrorHandlerMiddleware.cs:**  This file  contains an  `ErrorHandlerMiddleware`  class that intercepts errors or exceptions and handles them appropriately, potentially including logging errors.
-   **Models** Folder contains model classes that represent the data structures used by the application.
    
    -   **GAModel.cs:**  This file defines a  `GAModel`  class, possibly related to Design GAs as suggested by the controller name.
    -   **GetCustomerStatementModel.cs:**  This file defines a  `GetCustomerStatementModel`  class, possibly used to represent the data structure for customer statements.
    -   **LoggedOutModel.cs:**  This file  defines a  `LoggedOutModel`  class, possibly used to represent data or status information related to user logouts.
-   **Services** Folder contains service classes that encapsulate application logic or interact with external systems.
    
    -   **AuthenticatedUserService.cs:**  This file  defines an  `AuthenticatedUserService`  class that handles tasks related to authenticated users, potentially including user information retrieval or authorization checks.

Overall, the project structure follows a Model-View-Controller (MVC) design pattern, separating concerns and promoting maintainability.
-   **Core**
    -   **RelTransCustomer.Application**   This folder contain the core application logic, business tier components, and domain models.
    -   **RelTransCustomer.Domain**  This folder hold the domain model classes representing the core entities and logic of the application.
-   **Infrastructure**
    -   **RelTransCustomer.Identity**  This folder contain code related to user authentication and authorization mechanisms.
    -   **RelTransCustomer.Persistence**  This folder holds the code for interacting with the data persistence layer, potentially including database access logic and data models.
-   **Shared**
    -   **RelTransCustomer.Shared**  This folder contain utility classes, helper functions, or code shared by different parts of the application.

```