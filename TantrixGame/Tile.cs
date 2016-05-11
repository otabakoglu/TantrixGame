using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

// -> Oyun Taslari icin
// -> For Game Tiles
public class Tile : PictureBox
{
    // -> Gelistirme Ekrani icin Ozellik eklenmesi
    // -> Add properties for Developer
    [Description("Taşlar Hareketli mi?"), Category("Data")]
    public bool Sabit_Hareketli_Taslar {
        get { return Sabit; }
        set { Sabit = value; }
     }

    private bool Sabit = false;
    public Tile()
    {
        // -> ilk boyut ayarlama
        // -> set first size
        Size = new Size(121, 108);

        // -> Bos Tas icin Resim    [kalip.PNG] 
        // -> Picture for Empty Tile
        Image = TantrixGame.Properties.Resources.kalip;
        SizeMode = PictureBoxSizeMode.StretchImage;

        // -> Arkaplan saydam
        // -> Transparent Background
        BackColor = Color.Transparent;

        // -> Altigen Alani Ayarlama
        // -> Adjusting Place for Hexagon
        setRegion();

        // -> imleci [parmak] Yapma
        // -> set Cursor [Hand]
        Cursor = Cursors.Hand;

        // -> Mouse Olaylari 
        // -> MouseEvent for Tiles
        MouseDown += new MouseEventHandler( tile_MouseDown );
        MouseMove += new MouseEventHandler( tile_MouseMove );
        MouseUp   += new MouseEventHandler( tile_MouseUp   );
       
    }

    private int x1, y1;
    bool mousedown = false;
    private void tile_MouseUp(object sender, MouseEventArgs e)
    {
        if (!Sabit) return;
        
        mousedown = false;
        Up(sender,e);
    }
    private void Up(object sender, MouseEventArgs e)
    {
        Tile mTile = (Tile)sender;

        String LevelName = "PanelLvl" + TantrixGame.GameScreen.lwl.ToString();
       
        // -> LINQ Power
        var c = from controls in Form.ActiveForm.Controls[LevelName].Controls.OfType<Tile>()
                where !controls.Sabit_Hareketli_Taslar
                select controls;
        // -> butun sabit duran taslar kontrol ediliyor.
        // -> Checking Fixed Tiles
        foreach (Tile _tile in c)
        {
            int x = _tile.Left;
            int y = _tile.Top;

            // -> imlec Koordinatlarinin kontrol edilmesi [e.X, e.Y] 
            // -> Checking Mouse Coordinates
            if (e.X + mTile.Left > x  && 
                e.Y + mTile.Top  > y  && 
                e.X + mTile.Left < x + _tile.Width && 
                e.Y + mTile.Top  < y + _tile.Height )
            {
                // -> Yer dolu ise tasi koyma
                // -> Checking Empty Tile
                if ( _tile.Tag.Equals("0") )
                {
                    mTile.Left = _tile.Left;
                    mTile.Top  = _tile.Top;
                   
                    // -> Taglari esitleyerek taslarin yerini kontrol etme.
                    _tile.Tag = mTile.Tag;
                }
            }

        }
    }
    // -> [ true = Hareketli |  false = Sabit ]
    // -> [ true = moving    |  false = fixed ] 
    private void tile_MouseMove(object sender, MouseEventArgs e)
    {
        // -> Tas Hareketli Mi?
        // -> Tile is Moving?
        if (!Sabit) return; 
        if (mousedown)
            Location = new Point(e.X + Left - x1, e.Y + Top - y1);
    }

    private void tile_MouseDown(object sender, MouseEventArgs e)
    {
        
        if (!Sabit) return;
        
        x1 = e.X; y1 = e.Y;
        mousedown = true;

        Tile mTile = (Tile)sender;

        String LevelName = "PanelLvl" + TantrixGame.GameScreen.lwl.ToString();
        
        // -> LINQ Power
        var c = from controls in Form.ActiveForm.Controls[LevelName].Controls.OfType<Tile>()
                where !controls.Sabit_Hareketli_Taslar
                select controls;

        foreach (Tile _tile in c)
        {
            if (mTile.Tag.Equals(_tile.Tag.ToString()))
                  _tile.Tag = "0";
        }

    }
    
    private PointF[] points = new PointF[6];

    // -> Kare Dugmeyi Altigen Bicimine Getirme.
    // -> Square Panel => Convert => Hexagon Panel.
    private void setRegion()
    {
        // -> Altigen Kenar Koordinatlari
        // -> Hexagon Edge Coordinates
        points[0] = new PointF(41,6);
        points[1] = new PointF(118, 6);
        points[2] = new PointF(157,72);
        points[3] = new PointF(121, 140);
        points[4] = new PointF(44, 140);
        points[5] = new PointF(7,68);
       
        // -> Yol Olusturma
        // ->Create Path
        GraphicsPath polygon_path = new GraphicsPath(FillMode.Winding);
        polygon_path.AddPolygon(points);
        SizeF mSizeF = new SizeF(121, 108);
      
        // -> 0.75 oraninda taslari kucultme
        // -> Tile Resize
        Matrix m = new Matrix();
        m.Scale((float)0.75, (float)0.75, MatrixOrder.Append);
        polygon_path.Transform(m);

        // -> Yolu Alana Uygulama
        // -> Adjust Path
        Region polygon_region = new Region(polygon_path);
        Region = polygon_region;
        
    }

    
    
}

