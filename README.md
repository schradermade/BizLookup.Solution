<div align="center">
  <h1>Tualatin Business Directory</h1>
  <br>
  <small>Project by:</small>
  <h3>Nathan Schrader</h3>
  <h4>Created Jan 23th, 2021.</h4>
</div>


<p align="center">
    <!-- Project Image -->
    <br>
    <a>
        <img src="BizLookupMvc/wwwroot/img/businesslisting.jpeg">
    </a>
    <p align="center">
      ___________________________
    </p>
    <!-- Project GitHub Link -->
    <p align="center">
        <a href="https://github.com/schradermade/BizLookup.Solution">
            <strong>Link to this project's GitHub Repo</strong>
        </a> 
    </p>
</p>
<br>




# 🗄 Table of Contents

  - <a href="#📖-project-description">Project Description</a>
  - <a href="#🦠-known-bugs">Known Bugs</a>
  - <a href="#🛠-technologies-used">Technologies Used</a>
  - <a href="#🧩-getting-started">Getting Started</a>
  - <a href="#📂-setup-and-use">Setup and Use</a>
  - <a href="#🔎-api-information">API Information</a>
  - <a href="#☎️-contact-and-support">Contact</a>
  - <a href="#🛡-license">License</a>


# 📖 Project Description

This project was created in Week 11 of the Epicodus Coding School, using C#/.NET MVC. The objective was to build a web application to be a business directory where users can add, edit or delete a business listing.

# 🦠 Known Bugs

At this time, there are no known bugs. If you see spot a bug feel free to make a pull request.

# 🛠 Technologies Used

- [Visual Studio Code](https://code.visualstudio.com/)
- [C# 7.3](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET Core 2.2](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
- [MySQL](https://dev.mysql.com/)
- [Git](https://git-scm.com/)
- [Swagger](https://swagger.io/docs/)
- [MySql Workbench](https://www.mysql.com/products/workbench/)
- [Entity Framework Core 2.2.6](https://docs.microsoft.com/en-us/ef/core/)
- [MSTest](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest)
- [Object Oriented Programming](https://www.freecodecamp.org/news/object-oriented-programming-concepts-21bb035f7260/)
- [Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-5.0&tabs=visual-studio)

# 🧩 Getting Started

### Install .NET Core

- On macOS Mojave or later
  - [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
- On Windows 10 x64 or later
  - [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

### Install dotnet script

Enter the command `dotnet tool install -g dotnet-script` in Terminal for macOS or PowerShell for Windows.

### Install MySQL Workbench

[Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

### Code Editor

To view or edit the code, you will need an code editor or text editor. The popular open-source choices for an code editor are Atom and VisualStudio Code.

1. Code Editor Download:
   - Option 1: [Atom](https://nodejs.org/en/)
   - Option 2: [VisualStudio Code](https://www.npmjs.com/)
2. Click the download most applicable to your OS and system.
3. Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
4. Optionally, create a [GitHub Account](https://github.com)

<hr>

# 📂 Setup and Use

### Download Project from Github

1. Open your terminal and navigate to a directory that you wish to download this project to.
2. Type the following line of code into your terminal, and press 'Enter'. Project will automatically begin downloading to your current directory.

    <code>git clone https://github.com/schradermade/BizLookup.Solution.git</code>
3. Once the project has finished downloading, use the terminal to navigate to the “__BizLookup.Solution__" folder of the project.
4. Now, navigate to __BizLookupMvc__ directory and run these commands:
    - `dotnet restore`
    - `dotnet run`


### Database Setup

1. In the __BusinessLookup.Solution/__ directory, create a new file and name it "appsettings.json".  Copy and paste the following code into your new appsettings.json file.

2. Code to paste into __appsettings.json__
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=bizlookup;uid=root;pwd=epicodus;"
  }
}
```
3. Also in `appsettings.json`: In the above block of code, within the `"DefaultConnection"`, you will need to change the `uid` and `pwd` to the corresponding UserName and Password you set for your MySQL WorkBench.

4. Save the `appsettings.json` file.
5. In the terminal, navigate to the `BizLookupApi` folder inside of the `BizLookup.Solution` directory, and run these commands:
    - `dotnet ef database update`
    - Optional step: To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

---

# 🔎 API Information

## Swagger

<a href="https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-5.0&tabs=visual-studio">Click Here to see Swashbuckle documention</a>

Or..

To view the 'BizLookup' API with Swashbuckle, run these commands in terminal:

<code>dotnet run</code>

and navigate to:

<code>http://localhost:5003/swagger/index.html</code>

## Endpoints

#### Base URL: 
```
https://localhost:5003
```

#### HTTP Request Structure:

```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

## Businesses

<b>Access the name, industry, address, hours, url and phone for the businesses.</b>
 

#### HTTP Request Structure: 

```
GET /api/businesses
POST /api/businesses
GET /api/businesses/{id}
PUT /api/businesses/{id}
DELETE /api/businesses/{id}
```

#### Example of a Search Query
```
http://localhost:5003/api/Businesses/2
```

#### JSON Response:
```
  {
    "businessId": 2,
    "name": "Christian's Bakery",
    "industry": "Food & Beverage",
    "address": "Tualatin, Oregon",
    "hours": "8am-6pm, Mon-Fri",
    "url": null,
    "phone": null
  }

```

# ☎️ Contact and Support

If you have any feedback or concerns, please contact <natecschrader@gmail.com>.


# 🛡 License

This repository is licensed under the MIT license.

Copyright (c) 2020 by _Nathan Schrader_

```

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

```