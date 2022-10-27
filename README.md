# UnityTools
### Setup tutorial
#### 1. *ResizeParent.cs* is a script for responsive resizing the parent according to the child *(percentage)*
- Attach ***ResizeParent.cs*** script to the object which you want to resize according to max width child in it
- Check what you want to resize ***w_check** for width, **h_check** for height*
- Set the number ***width*** and ***height*** for the ***child-parent*** *width/height* ratio
- Add some amount of *vertical/horizontal* ***padding*** and set the ***fixed amount*** which will be multiplied by *vertical/horizontal* padding
#### 2. *ResizeChild.cs* is a script for responsive resizing the child according to the parent *(percentage)*
- Attach ***ResizeChild.cs*** script to the object which you want to resize according to width of the parrent
- Check what you want to resize ***w_check** for width, **h_check** for height*
- Set the number ***width*** and ***height*** for the ***parent-child*** *width/height* ratio
