# How to Rotate WinForms Carousel Programmatically
## Overview
This example demonstrates how to rotate the WinForms Carousel control programmatically. The Carousel control provides a visually engaging way to display a collection of items in a circular or elliptical layout, commonly used in dashboards, galleries, or product showcases.

## Why Programmatic Rotation?
In real-world applications, developers often need to control carousel rotation manually. Examples include:
- Rotating to a specific item based on user input.
- Continuous rotation for a slideshow effect.
- Rotation triggered by timers or events.

This sample shows how to implement such functionality using straightforward C# code.

## Key Features Demonstrated
- Initialize Carousel with a custom collection of items.
- Rotate programmatically using a button click.
- Customize rotation speed and direction.
- Enhance user experience with intuitive navigation.

## Code Example
``` C#
#region Windows Form Designer generated code
/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
{
    // Designer code for initializing carousel and button
}
#endregion

private int index = 0;

private void buttonAdv_Click(object sender, EventArgs e)
{
    // Rotate carousel to the next item
    this.carousel1.ActiveItem = this.carousel1.Items[index];
    this.label2.Text = this.carousel1.ActiveItem.Text;

    index++;
    if (index >= this.carousel1.Items.Count)
    {
        index = 0; // Reset index for continuous rotation
    }
}
```

## How It Works
- **carousel1.ActiveItem** sets the currently active item in the carousel.
- **index** tracks the current position and loops back when reaching the end.
- Button click triggers rotation to the next item.
