// Fig. 13.25: ChessPiece.cs
// Storage class for chess piece attributes.

using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Cards
{
   /// <summary>
   /// represents a chess piece
   /// </summary>
   public class Piece
   {
      // define chess-piece type constants
      public enum Suit
      {
         S,
         C,
         H,
         D,
      }

      private int currentType; // this object's type

	   public int iValue = 0;
	   public int iSuit	 = 0;
      private Bitmap pieceImage; // this object's image

      // default display location
      private Rectangle targetRectangle = 
         new Rectangle( 0, 0, 85, 120 );

      // construct piece
      public Piece( int type, int xLocation, 
         int yLocation, Bitmap sourceImage, int isuit, int ivalue )
      {
         currentType = type; // set current type
		  iValue = ivalue;
		  iSuit = isuit;
         targetRectangle.X = xLocation; // set current x location
         targetRectangle.Y = yLocation; // set current y location

         // obtain pieceImage from section of sourceImage
         pieceImage = sourceImage.Clone( 
            new Rectangle( xLocation, 0, 85, 120 ), 
            System.Drawing.Imaging.PixelFormat.DontCare );
      }

      // draw chess piece
      public void Draw( Graphics graphicsObject )
      {
		  Color lowerColor = Color.FromArgb(0,0,240);
		  Color upperColor = Color.FromArgb(0,0,255);
		  ImageAttributes imageAttr = new ImageAttributes();
		  imageAttr.SetColorKey(lowerColor, upperColor, ColorAdjustType.Default);


		  graphicsObject.DrawImage(pieceImage, targetRectangle, 0, 0, 85, 120, GraphicsUnit.Pixel, imageAttr); 

    //     graphicsObject.DrawImage( pieceImage, targetRectangle );

      } 
	   public void DrawAt( Graphics graphicsObject, int x, int y )
	   {
		   Color lowerColor = Color.FromArgb(0,0,255);
		   Color upperColor = Color.FromArgb(0,0,255);
		   ImageAttributes imageAttr = new ImageAttributes();
		   imageAttr.SetColorKey(lowerColor, upperColor, ColorAdjustType.Default);
			
		   targetRectangle.X = x;
		   targetRectangle.Y = y;

		   graphicsObject.DrawImage(pieceImage, targetRectangle, 0, 0 , 85, 120, GraphicsUnit.Pixel, imageAttr); 

		//   graphicsObject.DrawImage( pieceImage, x,y, 85, 120 );

	   } 

      // obtain this piece's location rectangle
      public Rectangle GetBounds()
      {
         return targetRectangle;

      } // end method GetBounds

      // set this piece's location
      public void SetLocation( int xLocation, int yLocation )
      {
         targetRectangle.X = xLocation;
         targetRectangle.Y = yLocation;

      } // end method SetLocation

   } // end class ChessPiece
}

/*
 **************************************************************************
 * (C) Copyright 2003 by Deitel & Associates, Inc. and Prentice Hall.     *
 * All Rights Reserved.                                                   *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************
*/

