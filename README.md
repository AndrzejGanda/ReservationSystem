# ReservationSystem

* [General info](#general-info)
* [Manual](#manual)
* [Technologies](#technologies)
* [Configuration](#configuration)

## General info

ReservationSystem is a simple API for organizing and signing up for meetings, events, seminaries.
With it's help user can: create and delete meetings, display meetings list and enroll a participant for a meeting.
The meeting is limited to 25 participants.
In order to sign up for a meeting, the participant has to provide name and e-mail address.

## Manual

### API shows:
1)Booking: 
"POST" button to enroll a participant for the meeting
2)Meeting:
"GET" button to display meetings list
"POST" button to create new meeting
"DELETE" button to delete meeting

### Example of use:
#### POST:
```
time:2020-01-01 name:meeting1
```
#### Get:
```
[
  {
    "date": "2020-02-01T23:00:00Z",
    "name": "meeting1",
    "participants": [],
    "id": 1
  }
]
```

## Technologies

The application was written in C# using the .NET 5.0 platform.
MongoDB database is used in the application.

## Configuration

Before starting the program, the user should connect the program to the working MongoDB installation.
The other way is to change DataBaseMeetingRepository>() to InMemomryMeetingRepository>()
### Warning:
Secound solution doesn't save changes. It is for testing purpose only.