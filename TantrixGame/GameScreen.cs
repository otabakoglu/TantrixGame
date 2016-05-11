using System;
using System.Linq;
using System.Windows.Forms;

namespace TantrixGame
{
    public partial class GameScreen : Form
    {
        public static int lwl;

        public GameScreen()
        {
            InitializeComponent();
        }

        public GameScreen(int lwl)
        {
            InitializeComponent();
            refleshForm(lwl);
        }

        // -> Yeni Seviyeler icin Panelerin Ayarlanmasi(goster/gizle)
        // -> Adjust Panels (show/hide) for New Levels.
        private void refleshForm(int lwl)
        {
            GameScreen.lwl = lwl;
            lbl_level.Text = "SEVİYE  " + GameScreen.lwl;
         // ->
            PanelSelect();
        }

        private void tile_MouseUp(object sender, MouseEventArgs e)
        {
            GameEndControl(null);
            // -> Lvl 4 ise -alternatif cozume- de bak
            // -> alternative solution for level 4.
            if ( GameScreen.lwl == 4 )
                GameEndControl( getLwlAlternativeTiles( 4 ) );
            if (GameScreen.lwl == 8)
                GameEndControl(getLwlAlternativeTiles( 8 ));
        }

        // -> Seviye Sonu Kontrolu
        // -> Finish This Level?
        private void GameEndControl(Tile[] rectiles)
        {
            Tile[] tiles = rectiles;

            if ( tiles == null )
                     tiles = getLwlTiles();

            // -> Bos Yer Var Mı?          [Bos   = 0]
            // -> Do you have empty place? [Empty = 0]
            for (int i = 0; i < tiles.Length; i++)
                if ( tiles[i].Tag.Equals( "0" ) )
                    return;

            // -> Taglerin Kontrol Edilmesi.
            // -> Checking the Tag.
            // -> tiles[x-1].tag = [x]
            for (int i = 1; i < tiles.Length+1; i++)
                if ( !tiles[i-1].Tag.Equals( i.ToString() ) )
                    return;

            // -> Son Seviye Kontrolu
            // -> Checking The Final Level
            if (GameScreen.lwl == 8)
            {
                MessageBox.Show( "Tüm Seviyeleri Bitirdiniz..", "Bravo!" );
                this.Close();
            }
            else {
            // -> Sonraki Seviyeye Geciliyor.
            // -> For Next Level 
                MessageBox.Show( "Sonraki Seviye Açılacak", "Seviye Bitti.." );
                GameScreen.lwl += 1;
                refleshForm( GameScreen.lwl );
            }
        }

        // -> Her Seviye icin Farkli Taslar.
        // -> Different  Tiles for Different Level.
        private Tile[] getLwlTiles()
        {
            switch ( GameScreen.lwl )
            {
                case 1:
                    return new Tile[] { lwl1tile3, lwl1tile2, lwl1tile1 };
                case 2:
                    return new Tile[] { lwl2tile1, lwl2tile2, lwl2tile3, lwl2tile4 };
                case 3:
                    return new Tile[] { lwl3tile1, lwl3tile2, lwl3tile3, lwl3tile4, lwl3tile5 };
                case 4:
                    return new Tile[] { lwl4tile1, lwl4tile2, lwl4tile3, lwl4tile4, lwl4tile5, lwl4tile6 };
                case 5:
                    return new Tile[] { lwl5tile1, lwl5tile2, lwl5tile3, lwl5tile4, lwl5tile5, lwl5tile6, lwl5tile7 };
                case 6:
                    return new Tile[] { lwl6tile1, lwl6tile2, lwl6tile3, lwl6tile4, lwl6tile5, lwl6tile6, lwl6tile7, lwl6tile8 };
                case 7:
                   return new Tile[] { lwl7tile1, lwl7tile2, lwl7tile3, lwl7tile4, lwl7tile5, lwl7tile6, lwl7tile7, lwl7tile8, lwl7tile9 };
                case 8:
                    return new Tile[] { lwl8tile1, lwl8tile2, lwl8tile3, lwl8tile4, lwl8tile5, lwl8tile6, lwl8tile7, lwl8tile8, lwl8tile9, lwl8tile10 };
                default:
                    return new Tile[] { lwl1tile3, lwl1tile2, lwl1tile1 };
            }
           
        }

        // -> 4.seviye icin ozel durum.
        // -> Special Status for Level 4.
        private Tile[] getLwlAlternativeTiles(int lwl)
        {
            if( lwl == 4 )
                return new Tile[] { lwl4tile1, lwl4tile2, lwl4tile4, lwl4tile3, lwl4tile5, lwl4tile6 };
            if (lwl == 8)
                return new Tile[] { lwl8tile1, lwl8tile9, lwl8tile3, lwl8tile5, lwl8tile4, lwl8tile7, lwl8tile6, lwl8tile8, lwl8tile2, lwl8tile10 };
            return null;            
        }


        // -> Yeni Seviyeler icin Panelerin Ayarlanmasi(goster/gizle)
        // -> Adjust Panels (show/hide) for New Levels.
        private void PanelSelect()
        {
            String panelName;
            // -> Butun Panelleri Sakla.
            // -> Hide all Panels.
            for (int i = 1; i < 9; i++)
            {
                panelName = "PanelLvl" + i.ToString();
                this.Controls[panelName].Hide();
            }

            // -> istenilen Seviye icin Paneli Goster.
            // -> Show Panel for the Current Level.
            panelName = "PanelLvl" + GameScreen.lwl;
            this.Controls[panelName].Show();
          
        }

        #region  Timers for Opacity Effect.
        private void btn_clk_back(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1;
            if (Opacity >= 1)
                timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.1;
            if (Opacity <= 0)
                Close();
        }
        #endregion
  
    }
}
