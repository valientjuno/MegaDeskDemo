# MegaDesk Quote Application

## Overview

MegaDesk is a Windows Forms application written in C#. The program allows a user to create and view desk quotes for customers. A quote includes desk dimensions, number of drawers, surface material, and delivery time. The application calculates the total desk size and stores the quote information for display.

This project demonstrates the use of:

* C# classes and objects
* Windows Forms UI development
* Multiple forms with navigation
* Basic data input and display

---

## Current Features

### Main Menu

The main menu provides navigation to the different parts of the application.

Available options:

* **Add Quote** – Opens the form used to enter desk quote information.
* **View All Quotes** – Opens a form that displays existing quotes.
* **Search Quote** – Opens a form to search for quotes by material.
* **Exit** – Closes the application.

---

### Add Quote

The Add Quote form allows the user to enter desk information and generate a quote.

User inputs include:

* Customer Name
* Desk Width
* Desk Depth
* Number of Drawers
* Surface Material
* Rush Order Delivery Time

When the user clicks **Submit**, the application:

1. Creates a Desk object.
2. Creates a DeskQuote object.
3. Calculates the total desk size.
4. Opens the Display Quote form to show the results.

A **Back** button allows the user to return to the main menu.

---

### Display Quote

The Display Quote form shows the quote information entered in the Add Quote form.

Displayed information includes:

* Customer Name
* Quote Date
* Desk Width
* Desk Depth
* Number of Drawers
* Total Desk Size (square inches)
* Surface Material
* Rush Delivery Time

A **Main Menu** button allows the user to return to the main menu.

---

### Search Quote

The Search Quote form allows the user to search for quotes based on the surface material selected.

---

### View All Quotes

The View All Quotes form displays the list of all stored quotes.

---

## Project Structure

The project contains the following main files:

```
MegaDeskDemo
│
├── Program.cs
├── Desk.cs
├── DeskQuote.cs
│
├── MainMenuForm.cs
├── AddQuote.cs
├── DisplayQuote.cs
├── SearchQuote.cs
└── ViewQuotes.cs
```

### Key Classes

**Desk**

* Stores desk dimensions
* Stores number of drawers
* Stores material type
* Calculates desk surface area

**DeskQuote**

* Stores customer information
* Stores quote date
* Contains desk information
* Calculates quote cost

---

## How to Run the Program

### Requirements

* Visual Studio
* .NET Windows Forms support

### Steps

1. Open **Visual Studio**.
2. Select **Open Project or Solution**.
3. Navigate to the project folder and open:

```
MegaDeskDemo.sln
```

4. Click **Start** or press:

```
F5
```

5. The **Main Menu** window will appear.

---

## How to Use the Application

### Creating a Quote

1. From the **Main Menu**, click **Add Quote**.
2. Enter the customer name.
3. Enter desk width and depth.
4. Enter the number of drawers.
5. Select a material type.
6. Select delivery time.
7. Click **Submit**.
8. The quote details will appear on the **Display Quote** screen.

### Returning to the Main Menu

Click the **Main Menu** button on any form to return.

---

## Known Limitations (Current Version)

* Quotes are not permanently saved to a file yet.
* Input validation is minimal.
* Search functionality is still being expanded.
* Pricing calculations may still be simplified.

---

## Future Improvements

Possible improvements for future versions:

* Save quotes to a JSON file
* Load existing quotes automatically
* Improve validation for numeric inputs
* Add full quote pricing calculations
* Improve UI layout and styling

---

## Author

Jesse Doake

Project created as part of a C# Windows Forms coursework assignment.
