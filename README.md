# DBS-V-SEMESTER-GAME-VAULT
 
Objective:
The core objective of the "Game Library Organizer" project is to offer gamers a streamlined and user-friendly platform for efficiently managing their video game collections. This encompassing software solution simplifies various aspects of game management, including listing games, keeping track of ownership, monitoring completion progress, facilitating user reviews, and implementing effective categorization. Through the power of automation and a secure SQL database, the system aims to simplify game organization, elevate user experience, and empower gamers to make well-informed decisions.

Scope:
This project focuses on developing a user-friendly software solution for effective video game collection management. It includes features like game listing, ownership tracking, completion status, user reviews, and categorization. The scope encompasses process automation to enhance organization and user experience.

Project Description:
The "Game Library Organizer" is a sophisticated software system designed to cater to the multifaceted needs of gamers seeking to efficiently manage their video game collections. This comprehensive solution revolves around four primary user roles: User, Game, Copy, and Review. Additionally, the system incorporates a Genre table to enable effective game categorization, enhancing the organization and accessibility of game collections.

User Mode:
In this mode, users are empowered to create personalized accounts, log in securely, and gain access to a user-friendly interface for managing their game libraries. They can seamlessly add new games, indicate the completion status of each game, and provide insightful ratings and reviews. Navigating through their collection is made effortless, with the ability to explore and search through games with ease.

Game Mode:
The pivotal Game table within the system serves as the repository for comprehensive information about each video game in the user's collection. It includes essential fields such as game title, release date, developer, publisher, genre, and platform. Users are granted the capability to effortlessly add, update, and remove games, ensuring that their collection remains up-to-date and accurate.

Copy Mode:
The Copy table introduces an indispensable feature that enables users to meticulously track multiple copies or editions of each owned game. This function becomes invaluable for both physical and digital game copies. Information such as a unique copy ID, associated user ID (foreign key), corresponding game ID (foreign key), purchase date, and condition are stored, ensuring meticulous monitoring of the user's entire collection.

Review Mode:
Empowering user engagement and informed decision-making, the Review table provides a platform for users to contribute their personal insights through ratings and reviews. Fields encompass a unique review ID, user ID (foreign key), game ID (foreign key), rating, and review text. The system undertakes the task of calculating average user ratings and seamlessly displays reviews, aiding users in selecting games based on community feedback.

Genre Mode:
To enhance effective cataloging and filtering, the Genre mode features a dedicated table. This table includes vital fields such as genre ID and genre name, enabling users to assign genres to their games. This results in a streamlined collection with improved accessibility and categorization.
This meticulously crafted database structure establishes a robust foundation for an organized and highly efficient platform that empowers gamers to meticulously manage their collections. The careful establishment of relationships between tables through foreign keys ensures the utmost data accuracy and user-friendly interaction. The "Game Library Organizer" project is poised to revolutionize the way gamers engage with their collections, ultimately fostering a more enriched and enjoyable gaming journey.

Hardware Requirements:
Processor:  Intel dual core or above
Processor Speed: 1.0GHZ or above
RAM:  1 GB RAM or above
Hard Disk:  20 GB hard disk or above

Software Requirements:
Language: Express.js, Node.js, HTML, CSS, JavaScript
Database:  Oracle
