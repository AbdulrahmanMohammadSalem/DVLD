# DVLD

In order to compile and thus use this software, you must have

1. the same database schema upon which this project was built. You have two options:
	- You can recreate the entire schema by executing the scripts found in `Database Design/Schema Creation Script.sql`, and optionally fill it with the data from my project using the scripts from `Database Design/Populating Tables With Data.sql`. This enables you to also choose another name for the database. Or
	- You can simply restore the entire database with all its data from the full backup found in `Database Design/Full Database Backup.bak`.
2. the necessary DLLs needed to complete initial and JIT compilation. You can find them in the `Assemblies/` directory.

>*This project uses Syncfusion® WinForms control library. You may face licensing issues keeping you from using this software. There's nothing I can do to solve that other than maybe stop using them if I want to publish a project as open-source.*

# License — Personal Use Only

- *This project is © 2026 Abdulrahman Mohammad Salem and is licensed under the [SALEM PERSONAL-USE LICENSE (SPUL) v1.0](https://github.com/AbdulrahmanMohammadSalem/My-Projects-Portfolio/blob/main/LICENSE).*
- *You may view and use the code for private, non-commercial projects only. You may NOT fork, modify, redistribute, or claim ownership.*
- *For permission beyond personal use contact: abdulrahmansalem.contact@gmail.com.*
