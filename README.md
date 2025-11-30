# Programmatic Rotation Demo for Syncfusion WinForms Carousel
This sample demonstrates how to control and rotate items programmatically in the Syncfusion WinForms Carousel control. It showcases navigating to specific items, step-wise rotation via UI actions, and continuous slideshow-like movement driven by timers or events. The Carousel provides a visually engaging circular/elliptical layout ideal for dashboards, galleries, and product showcases.

## Features
- Rotate to a specific item programmatically (by index or reference)
- Step through items using buttons (Next/Previous)
- Optional continuous rotation using a Timer for slideshow behavior
- Adjustable rotation speed and direction
- Visual focus via ActiveItem updates and status display

## Getting Started
1. Create a new Windows Forms App (.NET Framework) project in Visual Studio.
2. Install NuGet package: Syncfusion.Tools.Windows.
3. Add using directive in your form code if needed:
   - using Syncfusion.Windows.Forms.Tools;
4. Drop a Carousel control and a Button onto the form (or create them in code).
5. Populate the Carousel with items (e.g., images or labeled controls), then wire up event handlers to rotate programmatically.

## Usage Tips
- Jump directly to an item: set carousel1.ActiveItem to the desired item from carousel1.Items.
- For continuous rotation, use a System.Windows.Forms.Timer and advance the index each tick.
- Update a label with the current item’s text to confirm navigation.
- Debounce or disable UI while animating if you add custom transitions.

## How It Works
- carousel1.ActiveItem sets the currently focused/active item in the carousel.
- index tracks the current position and wraps to the start when it reaches the end.
- The button click advances to the next item; you can add a Timer to auto-advance for a slideshow.

## About the Sample
This sample is a concise starting point for adding programmatic navigation to a Syncfusion WinForms Carousel. Extend it with Previous/Next buttons, direct navigation by index or search, and a timer-driven slideshow. You can also bind richer content (images, user controls) and style the control to match your application’s branding.
