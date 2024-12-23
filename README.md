


# Hotel API

## Overview
This project is a simple REST API built using C# and ASP.NET Core to serve hotel-related data from a JSON file. The API provides endpoints to retrieve a list of hotels and details of a specific hotel by its ID.

## Table of Contents
- [Overview](#overview)
- [Requirements](#requirements)
- [Getting Started](#getting-started)
  - [Clone the Repository](#clone-the-repository)
  - [Install Dependencies](#install-dependencies)
  - [Run the Application](#run-the-application)
- [Endpoints](#endpoints)
  - [GET /api/hotels](#get-apihotels)
  - [GET /api/hotels/{id}](#get-apihotelsid)
- [Error Handling](#error-handling)
- [Project Structure](#project-structure)
- [Technical Constraints](#technical-constraints)


## Requirements
- .NET 6.0 SDK or later

## Getting Started

### Clone the Repository
First, clone the repository to your local machine:

```bash/terminal
git clone https://github.com/Ashwini-eng77/HotelAPI.git
cd HotelAPI


##Install Dependencies:
1)NewtonsoftJson:
     dotnet add package Newtonsoft.Json

2)AspNetCore.OpenApi:
     dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson

   
Restore the dependencies using the following command:
    dotnet restore

##Run the Application:
Run the application using the following command:
   dotnet restore

The application will start and listen on http://localhost:5299.

##Endpoints:
1)GET /api/hotels
Fetches a list of all hotels.

Example Request:
Use Browser or curl -X GET http://localhost:5299/hotels
Example Response:
[
  {
    "id": 1,
    "name": "Hotel One",
    "location": "City A",
    "rating": 4.5,
    "imageUrl": "https://example.com/images/hotel-one.jpg",
    "datesOfTravel": ["2024-01-01", "2024-01-15"],
    "boardBasis": "All Inclusive",
    "rooms": [
      {
        "roomType": "Standard Room",
        "amount": 10
      },
      {
        "roomType": "Luxury Room",
        "amount": 2
      }



    ]
  },
  ...
]


2)GET /api/hotels/{id}
    Fetches details of a single hotel by its ID.

  Example Request
  Use Browser or curl -X GET http://localhost:5299/hotels/1
  {
    "id": 1,
    "name": "Hotel One",
    "location": "City A",
    "rating": 4.5,
    "imageUrl": "https://example.com/images/hotel-one.jpg",
    "datesOfTravel": ["2024-01-01", "2024-01-15"],
    "boardBasis": "All Inclusive",
    "rooms": [
      {
        "roomType": "Standard Room",
        "amount": 10
      },
    {
      "roomType": "Luxury Room",
      "amount": 2
     }
   ]
  }

##Error Handling
Hotel Not Found (404): If the hotel does not exist, the API returns a 404 status code with an appropriate error message.
Example Response:
  {
     "Message": "Hotel not found"
   }

Server or Data Reading Errors (500): If there are server or data reading errors, the API returns a 500 status code with a descriptive error message.
  {
      "Message": "An error occurred while retrieving hotel data.",
       "Details": "Error details here"
  }

##Project Structure:
Controllers/HotelsController.cs: Contains the API endpoints.
Services/HotelService.cs: Contains the logic to read data from the JSON file.
Data/hotels.json: The data source for the API.

##Technical Constraints:
The API is built using C# and ASP.NET Core.
The JSON file is used for data storage; no database is required.



