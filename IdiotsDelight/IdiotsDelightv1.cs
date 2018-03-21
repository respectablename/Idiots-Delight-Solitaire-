using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Cards
{
   /// <summary>
   ///
   /// </summary>
   public class IdiotsDelight : System.Windows.Forms.Form
   {
	   private const string m_sVersion = "1.0";

      private System.Windows.Forms.PictureBox pieceBox;
      private System.Windows.Forms.MainMenu GameMenu;
      private System.Windows.Forms.MenuItem gameItem;
      private System.Windows.Forms.MenuItem newGameItem;
        private IContainer components;

        // ArrayList for board tile images
        ArrayList chessTile = new ArrayList();

      // ArrayList for chess pieces
      ArrayList cards = new ArrayList();
	   ArrayList cardsLeft = new ArrayList();

	   private bool bMoving = false;

      // define index for selected piece
      int selectedIndex = -1;
	   int removed = 0;
	  Point lastIndex = new Point(0,0);
      int[,] board = new int[ 13, 4 ]; // board array

      // define chess tile size in pixels
      private const int TILEHEIGHT = 120;
   	private System.Windows.Forms.Button btnDeal;
   	private System.Windows.Forms.Label lblCards;
   	private System.Windows.Forms.MenuItem menuItem1;
   	private System.Windows.Forms.MenuItem menuItem2;
   	private System.Windows.Forms.MenuItem menuItem3;
   	private System.Windows.Forms.MenuItem menuItem4;
   	private System.Windows.Forms.MenuItem menuItem5;
   	private System.Windows.Forms.MenuItem menuItem6;
   	private System.Windows.Forms.ListBox lstRemoved;
   	private System.Windows.Forms.Label lblRemoved;
   	private System.Windows.Forms.MenuItem menuHighScore;
	  private const int TILEWIDTH = 85;

      public IdiotsDelight()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }

		#region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdiotsDelight));
            this.pieceBox = new System.Windows.Forms.PictureBox();
            this.GameMenu = new System.Windows.Forms.MainMenu(this.components);
            this.gameItem = new System.Windows.Forms.MenuItem();
            this.newGameItem = new System.Windows.Forms.MenuItem();
            this.menuHighScore = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.btnDeal = new System.Windows.Forms.Button();
            this.lblCards = new System.Windows.Forms.Label();
            this.lblRemoved = new System.Windows.Forms.Label();
            this.lstRemoved = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pieceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pieceBox
            // 
            this.pieceBox.BackColor = System.Drawing.Color.DarkGreen;
            this.pieceBox.Location = new System.Drawing.Point(0, 0);
            this.pieceBox.Name = "pieceBox";
            this.pieceBox.Size = new System.Drawing.Size(392, 496);
            this.pieceBox.TabIndex = 1;
            this.pieceBox.TabStop = false;
            this.pieceBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pieceBox_Paint);
            this.pieceBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pieceBox_MouseDown);
            this.pieceBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pieceBox_MouseMove);
            this.pieceBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pieceBox_MouseUp);
            // 
            // GameMenu
            // 
            this.GameMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.gameItem,
            this.menuItem3});
            // 
            // gameItem
            // 
            this.gameItem.Index = 0;
            this.gameItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.newGameItem,
            this.menuHighScore,
            this.menuItem1,
            this.menuItem2});
            this.gameItem.Text = "Game";
            // 
            // newGameItem
            // 
            this.newGameItem.Index = 0;
            this.newGameItem.Shortcut = System.Windows.Forms.Shortcut.F2;
            this.newGameItem.Text = "New Game";
            this.newGameItem.Click += new System.EventHandler(this.newGameItem_Click);
            // 
            // menuHighScore
            // 
            this.menuHighScore.Index = 1;
            this.menuHighScore.Text = "&High Scores";
            this.menuHighScore.Visible = false;
            this.menuHighScore.Click += new System.EventHandler(this.menuHighScore_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.Text = "E&xit";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6,
            this.menuItem5,
            this.menuItem4});
            this.menuItem3.Text = "&Help";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "H&ow to Play";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.Text = "-";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "&About";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(416, 24);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "Deal";
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // lblCards
            // 
            this.lblCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCards.Location = new System.Drawing.Point(408, 56);
            this.lblCards.Name = "lblCards";
            this.lblCards.Size = new System.Drawing.Size(120, 24);
            this.lblCards.TabIndex = 3;
            this.lblCards.Text = "Cards Left : 44";
            this.lblCards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemoved
            // 
            this.lblRemoved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoved.Location = new System.Drawing.Point(408, 80);
            this.lblRemoved.Name = "lblRemoved";
            this.lblRemoved.Size = new System.Drawing.Size(120, 24);
            this.lblRemoved.TabIndex = 4;
            this.lblRemoved.Text = "Cards Removed : 0";
            this.lblRemoved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstRemoved
            // 
            this.lstRemoved.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstRemoved.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRemoved.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstRemoved.ItemHeight = 14;
            this.lstRemoved.Location = new System.Drawing.Point(408, 112);
            this.lstRemoved.Name = "lstRemoved";
            this.lstRemoved.Size = new System.Drawing.Size(120, 368);
            this.lstRemoved.Sorted = true;
            this.lstRemoved.TabIndex = 5;
            // 
            // IdiotsDelight
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(532, 488);
            this.Controls.Add(this.lstRemoved);
            this.Controls.Add(this.lblRemoved);
            this.Controls.Add(this.lblCards);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.pieceBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(552, 552);
            this.Menu = this.GameMenu;
            this.MinimumSize = new System.Drawing.Size(552, 552);
            this.Name = "IdiotsDelight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idiot\'s Delight";
            this.Load += new System.EventHandler(this.ChessGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ChessGame_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pieceBox)).EndInit();
            this.ResumeLayout(false);

	  }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new IdiotsDelight() );
      }

      // load tile bitmaps and reset game
      private void ChessGame_Load(
         object sender, System.EventArgs e)
      {
         // load chess board tiles
      //   chessTile.Add( Bitmap.FromFile( "lightTile1.png" ) );
        // chessTile.Add( Bitmap.FromFile( "lightTile2.png" ) );
//         chessTile.Add( Bitmap.FromFile( "darkTile1.png" ) );
  //       chessTile.Add( Bitmap.FromFile( "darkTile2.png" ) );

         ResetBoard(); // initialize board
         Invalidate(); // refresh form
      
      } // end method ChessGame_Load

      // initialize pieces to start and rebuild board
	private void ResetBoard()
	{
		int current = -1;
		Piece piece;
		Random random = new Random();
		bool light = true;
		int type;

		for (int ix=0;ix<13;ix++)
			for (int iy=0;iy<4;iy++)
				board[ix,iy] = -1;

		cards = new ArrayList();
		cardsLeft = new ArrayList();
		for (int iCards = 0; iCards < 52; iCards++) 
		{
			cardsLeft.Add(iCards);
		}

		GetRow(45);

		lstRemoved.Items.Clear();
		lblRemoved.Text = "Cards Removed : 0";

		removed = 0;

		current = 0;
		// load whitepieces image
		Bitmap whitePieces = 
		( Bitmap )Image.FromFile( "aces.png" );
		Bitmap selected = whitePieces;

		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
			column * TILEWIDTH, 0 * TILEHEIGHT, 
			selected, column, 12 );
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		whitePieces = 
			( Bitmap )Image.FromFile( "twos.png" );
		selected = whitePieces;

		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
				column * TILEWIDTH, 0 * TILEHEIGHT, 
				selected ,column, 0);
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		whitePieces = 
			( Bitmap )Image.FromFile( "threes.png" );
		selected = whitePieces;
		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
				column * TILEWIDTH, 0 * TILEHEIGHT, 
				selected , column, 1);
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		whitePieces = 
			( Bitmap )Image.FromFile( "fours.png" );
		selected = whitePieces;
		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
				column * TILEWIDTH, 0 * TILEHEIGHT, 
				selected , column, 2);
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		whitePieces = 
			( Bitmap )Image.FromFile( "fives.png" );
		selected = whitePieces;
		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
				column * TILEWIDTH, 0 * TILEHEIGHT, 
				selected , column, 3);
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		whitePieces = 
			( Bitmap )Image.FromFile( "sixes.png" );
		selected = whitePieces;
		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
				column * TILEWIDTH, 0 * TILEHEIGHT, 
				selected , column, 4);
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		whitePieces = 
			( Bitmap )Image.FromFile( "sevens.png" );
		selected = whitePieces;
		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
				column * TILEWIDTH, 0 * TILEHEIGHT, 
				selected , column, 5);
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		whitePieces = 
			( Bitmap )Image.FromFile( "eights.png" );
		selected = whitePieces;
		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
				column * TILEWIDTH, 0 * TILEHEIGHT, 
				selected , column, 6);
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		whitePieces = 
			( Bitmap )Image.FromFile( "nines.png" );
		selected = whitePieces;
		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
				column * TILEWIDTH, 0 * TILEHEIGHT, 
				selected , column, 7);
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		whitePieces = 
			( Bitmap )Image.FromFile( "tens.png" );
		selected = whitePieces;
		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
				column * TILEWIDTH, 0 * TILEHEIGHT, 
				selected , column, 8);
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		whitePieces = 
			( Bitmap )Image.FromFile( "jacks.png" );
		selected = whitePieces;
		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
				column * TILEWIDTH, 0 * TILEHEIGHT, 
				selected , column, 9);
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		whitePieces = 
			( Bitmap )Image.FromFile( "queens.png" );
		selected = whitePieces;
		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
				column * TILEWIDTH, 0 * TILEHEIGHT, 
				selected , column, 10);
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		whitePieces = 
			( Bitmap )Image.FromFile( "kings.png" );
		selected = whitePieces;
		for ( int column = 0; column <= board.GetUpperBound( 1 ); column++ )
		{
			// if first or last row, organize pieces
			

			// create current piece at start position
			piece = new Piece( current, 
				column * TILEWIDTH, 0 * TILEHEIGHT, 
				selected , column, 11);
			current ++;

			// add piece to arraylist
			cards.Add( piece );
		}
		

	} // end method ResetBoard

      // display board in form OnPaint event
	private void ChessGame_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
	{
		// obtain graphics object
		Graphics graphicsObject = e.Graphics;
	} 

	private int FindLastY(int x)
	{
		int iLast = -1;
		for (int y=0; y<13; y++)
		{
			if (board[y,x] > -1)
				iLast = y;
		}
		return iLast;
	}

	private int CheckValue(Point point) 
	{

		int icS=-1;
		int icV=45;

		int x = point.X / 98;
		if (x > 3) x = 3;
		if (x < 0) x = 0;

		int y = FindLastY(x);
		
		if (y != -1) 
		{
			icS = GetPiece(board[y,x]).iSuit;
			icV = GetPiece(board[y,x]).iValue;
		}


		for (int ix=0; ix < 4; ix ++) 
		{
			int iy = FindLastY(ix);
			if (iy > -1) 
			{
				int iS = GetPiece(board[iy,ix]).iSuit;
				int iV = GetPiece(board[iy,ix]).iValue;

				if (iS == icS && iV > icV)
				{
					board[y,x] = -1;
					removed ++;
					lblRemoved.Text = "Cards Removed : " + removed.ToString();
					string sCard = "";
					switch (icS)
					{
						case 0:
							sCard = "Spade   - ";
							break;
						case 1:
							sCard = "Club    - ";
							break;
						case 2:
							sCard = "Heart   - ";
							break;
						case 3:
							sCard = "Diamond - ";
							break;
					}
					switch (icV)
					{
						case 11:
							sCard += "K";
							break;
						case 10:
							sCard += "Q";
							break;
						case 9:
							sCard += "J";
							break;
						default:
							sCard += icV + 2;
							break;
					}
					lstRemoved.Items.Add(sCard);
					bMoving = false;
					selectedIndex = -1;
					return 1;
				}
			}
		}
		
		return 0;
		
	}

	private int CheckBounds( Point point, int exclude )
	{
		int x = point.X / 96;
		if (x > 3) x = 3;
		if (x < 0) x = 0;

		int y = FindLastY(x);
		if (y != -1) 
		{
			int iSel = board[y,x];
			board[y,x] = -1;
			lastIndex.X = x;
			lastIndex.Y = y;
			return iSel;
		}
		else
			return y;
	} 

      // handle pieceBox paint event
	private void pieceBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
	{
		int iExtra = 8;
		// draw all pieces
		for ( int x = 0; x < 4; x++ )
			for (int y = 0; y < 13;y++) 
				try 
				{
					
					GetPiece( board[y,x] ).DrawAt( e.Graphics, (x*85)+12 + (iExtra * x) ,(y*30)+4  );
					
				} 
				catch (System.Exception ex) 
				{
					string s = ex.Message;
				}
		if (bMoving == true)
		{
			GetPiece(selectedIndex).Draw(e.Graphics);
		}
	} // end method pieceBox_Paint

      private void pieceBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e )
      {
		  
		  if (CheckValue(new Point(e.X,e.Y)) == 0) 
		  {

			  // determine selected piece
			  selectedIndex = 
				  CheckBounds( new Point( e.X, e.Y ), -1 );
		  }
      
      } // end method pieceBox_MouseDown

      // if piece is selected, move it
      private void pieceBox_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e )
      {
         if ( selectedIndex > -1 )
         {
			 bMoving = true;
            Rectangle region = new Rectangle( 
               e.X - TILEWIDTH * 2, e.Y - TILEHEIGHT * 2, 
               TILEWIDTH * 4, TILEHEIGHT * 4 );

            // set piece center to mouse
            GetPiece( selectedIndex ).SetLocation( 
               e.X - TILEWIDTH / 2, e.Y - TILEHEIGHT / 2 );

            // refresh immediate area
            pieceBox.Invalidate( region );
         }
      
      } 

      
      private void pieceBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e )
      {
         int remove = -1;

         
         if ( selectedIndex > -1 )
         {
			 Point current = new Point( e.X, e.Y);
			 int x = current.X / (98);
			 if (x > 3) x = 3;
			 if (x < 0) x = 0;
			 int y = FindLastY(x);
			 if (y == -1)
			 {
				 board[y+1,x] = selectedIndex;
			 }
			 else
				 board[lastIndex.Y, lastIndex.X] = selectedIndex;

			 bMoving = false;
			 selectedIndex = -1;

			 

       /*     Point current = new Point( e.X, e.Y );
            Point newPoint = new Point( 
               current.X - ( current.X % TILEWIDTH ),
               current.Y - ( current.Y % (TILEHEIGHT/3) ) );

            // check bounds with point, exclude selected piece
            remove = CheckBounds( current, selectedIndex );

            // snap piece into center of closest square
			 if (remove > -1 ) 
			 {
				newPoint.Y += 25;
			 }
            GetPiece( selectedIndex ).SetLocation( newPoint.X,
               newPoint.Y );

            // deselect piece
            selectedIndex = -1;
*/
            // remove taken piece
        //    if ( remove > -1 )
          //     cards.RemoveAt( remove );

         }

         // refresh pieceBox to ensure artifact removal
         pieceBox.Invalidate();
      
      } // end method pieceBox_MouseUp

      // helper function to convert 
      // ArrayList object to ChessPiece
      private Piece GetPiece( int i )
      {
         return (Piece)cards[ i ];
      } // end method GetPiece
		
	   private void GetRow(int iCount) 
	   {
		   if (cardsLeft.Count > 0) 
		   {

			   Random r = new Random(Convert.ToInt32(DateTime.Now.Millisecond) + iCount);
			   
			   for (int ix=0; ix < 4; ix++) 
			   {
				   int iNum = r.Next(0,cardsLeft.Count);
				   int iy = FindLastY(ix);
				   iy++;

				   board[iy,ix] = (int)cardsLeft[iNum];
				   cardsLeft.RemoveAt(iNum);
			   }
			   pieceBox.Invalidate(); 
			   lblCards.Text = "Cards Left : "  + cardsLeft.Count.ToString();

		   }
		    
	   }
      // handle NewGame menu option click
      private void newGameItem_Click(object sender, System.EventArgs e)
      {
         ResetBoard(); // reinitialize board
         Invalidate(); // refresh form
		  
      
      }

   	private void btnDeal_Click(object sender, System.EventArgs e)
	   {
			Random r = new Random(DateTime.Now.Millisecond);
			GetRow((r.Next(0,1000)));
			
	   }

   	private void menuItem2_Click(object sender, System.EventArgs e)
	   {
			this.Close();
	   }

	private void menuItem6_Click(object sender, System.EventArgs e)
	{
		frmHow how = new frmHow();
		how.ShowDialog();
	}

   	private void menuItem4_Click(object sender, System.EventArgs e)
	   {
		About about = new About(m_sVersion);
		about.ShowDialog();
	   }

   	private void menuHighScore_Click(object sender, System.EventArgs e)
	   {
		HighScore hs = new HighScore();
		hs.ShowDialog();
	   } 

   } 
}

