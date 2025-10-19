using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerstGame
{
    public class Map
    {
        public int WidthMap { get; }
        public int HeightMap { get; }
        public Map(int width, int height)
        {
            WidthMap = width;
            HeightMap = height;
        }
    }
    public class Sprite
    {
        public Vector2 Position { get; set; }
        public PictureBox PictureBox { get; set; }
        public int spriteWidth { set; get; }
        public int spriteHeight { set; get; }

        public Sprite(int x, int y, PictureBox pictureBox)
        {
            Position = new Vector2(x, y);
            PictureBox = pictureBox;
            PictureBox.Left = x;
            PictureBox.Top = y;
            // считываем размеры спрайта
            this.spriteWidth = pictureBox.Width;
            this.spriteHeight = pictureBox.Height;
        }

        public bool Intersection(Sprite other)
        {
            if (this.PictureBox.Bounds.IntersectsWith(other.PictureBox.Bounds))
                return true;
            return false;
        }

        // метод для перемещения спрайта по экрану
        public void Move(int deltaX, int deltaY)
        {
            PictureBox.Left = deltaX;
            PictureBox.Top = deltaY;
        }

        public void Show()
        {
            PictureBox.Visible = true;
        }

        public void Hide()
        {
            PictureBox.Visible = false;
        }
    }
    public class Block : Sprite
    {
        public Block(int x, int y, PictureBox pictureBox) : base(x, y, pictureBox)
        {
        }
    }

    public class Coin : Sprite
    {
        public Coin(int x, int y, PictureBox pictureBox) : base(x, y, pictureBox)
        {
        }
    }

    public class Persone : Sprite
    {
        public int speed { set; get; }
        public int heads { set; get; }
        public int coins { set; get; }
        public Persone(int x, int y, PictureBox pictureBox, int speed = 1, int heads = 5, int coins = 0) : base(x, y, pictureBox)
        {
            this.speed = speed;
            this.heads = heads;
            this.coins = coins;
        }

        // отталкивание об спрайт
        public void PushBack(PictureBox targetPictureBox, PictureBox obstaclePictureBox, float pushBackStrength, Map m)
        {
            Rectangle targetRect = new Rectangle(targetPictureBox.Left, targetPictureBox.Top, targetPictureBox.Width, targetPictureBox.Height);
            Rectangle obstacleRect = new Rectangle(obstaclePictureBox.Left, obstaclePictureBox.Top, obstaclePictureBox.Width, obstaclePictureBox.Height);

            if (targetRect.IntersectsWith(obstacleRect))
            {
                // Найдем центр объектов
                Point targetCenter = new Point(targetPictureBox.Left + targetPictureBox.Width / 2, targetPictureBox.Top + targetPictureBox.Height / 2);
                Point obstacleCenter = new Point(obstaclePictureBox.Left + obstaclePictureBox.Width / 2, obstaclePictureBox.Top + obstaclePictureBox.Height / 2);

                // Определим направление от объекта препятствия
                Vector2 direction = new Vector2(targetCenter.X - obstacleCenter.X, targetCenter.Y - obstacleCenter.Y);
                direction.Normalize();

                // Определите, какой край препятствия ближе к целевому объекту
                float pushX = Math.Abs(obstacleRect.Left - targetRect.Right) < Math.Abs(obstacleRect.Right - targetRect.Left) ?
                                (obstacleRect.Left - targetRect.Right) :
                                (obstacleRect.Right - targetRect.Left);

                float pushY = Math.Abs(obstacleRect.Top - targetRect.Bottom) < Math.Abs(obstacleRect.Bottom - targetRect.Top) ?
                                (obstacleRect.Top - targetRect.Bottom) :
                                (obstacleRect.Bottom - targetRect.Top);

                // Установить push direction
                if (Math.Abs(pushX) < Math.Abs(pushY))
                {
                    // Отталкиваем в горизонтальном направлении
                    targetPictureBox.Left += (int)(pushX * pushBackStrength);
                }
                else
                {
                    // Отталкиваем в вертикальном направлении
                    targetPictureBox.Top += (int)(pushY * pushBackStrength);
                }

                // Ограничиваем новое положение границами карты после отталкивания
                targetPictureBox.Left = Math.Max(0, Math.Min(targetPictureBox.Left, m.WidthMap - targetPictureBox.Width));
                targetPictureBox.Top = Math.Max(0, Math.Min(targetPictureBox.Top, m.HeightMap - targetPictureBox.Height));
            }
        }



        // функция передвижения
        // используем класс object для уневрсальности
        public virtual void Go(object e, List<Block> b, Map m)
        {
            if (e is KeyEventArgs keyEvent) // проверка на тип данных
            {
                // Новые переменные для хранения позиции после предполагаемого перемещения
                int newLeft = PictureBox.Left;
                int newTop = PictureBox.Top;

                // логика передвижения
                if (keyEvent.KeyCode == Keys.A || keyEvent.KeyCode == Keys.Left)
                {
                    newLeft -= speed;
                }
                else if (keyEvent.KeyCode == Keys.D || keyEvent.KeyCode == Keys.Right)
                {
                    newLeft += speed;
                }
                else if (keyEvent.KeyCode == Keys.W || keyEvent.KeyCode == Keys.Up)
                {
                    newTop -= speed;
                }
                else if (keyEvent.KeyCode == Keys.S || keyEvent.KeyCode == Keys.Down)
                {
                    newTop += speed;
                }


                // Ограничиваем новое положение границами карты
                PictureBox.Left = Math.Max(0, Math.Min(newLeft, m.WidthMap - PictureBox.Width));
                PictureBox.Top = Math.Max(0, Math.Min(newTop, m.HeightMap - PictureBox.Height));

                // Проверка столкновения с блоками на новом месте
                foreach (Block p in b)
                {
                    if (PictureBox.Bounds.IntersectsWith(p.PictureBox.Bounds))
                    {
                        PushBack(this.PictureBox, p.PictureBox, 1f, m);
                    }
                }
            }
        }
    }

    public class Foe : Persone
    {
        public int damage { set; get; }
        public Foe(int x, int y, PictureBox pictureBox, int speed = 1, int heads = 5, int coins = 0, int damage = 1) : base(x, y, pictureBox, speed, heads, coins)
        {
            this.speed = speed;
            this.heads = heads;
            this.coins = coins;
            this.damage = damage;

            // считываем размеры спрайта
            int spriteWidth = pictureBox.Width;
            int spriteHeight = pictureBox.Height;
        }

        // переопределяем функцию передвижения
        public override void Go(object e, List<Block> b, Map m)
        {
            if (e is Persone targetPerson)
            {
                // Новые переменные для хранения позиции после предполагаемого перемещения
                int newLeft = PictureBox.Left;
                int newTop = PictureBox.Top;

                int k = (int)(targetPerson.spriteHeight + targetPerson.spriteWidth) / 4;
                if (this.PictureBox.Left + k < targetPerson.PictureBox.Left) { newLeft += speed; }
                else if (this.PictureBox.Right > targetPerson.PictureBox.Left) { newLeft -= speed; }
                if (this.PictureBox.Top + k > targetPerson.PictureBox.Top) { newTop -= speed; }
                else if (this.PictureBox.Top - k / 2 < targetPerson.PictureBox.Top) { newTop += speed; }

                // Ограничиваем новое положение границами карты
                PictureBox.Left = Math.Max(0, Math.Min(newLeft, m.WidthMap - PictureBox.Width));
                PictureBox.Top = Math.Max(0, Math.Min(newTop, m.HeightMap - PictureBox.Height));

                // Проверка столкновения с блоками на новом месте
                foreach (Block p in b)
                {
                    if (PictureBox.Bounds.IntersectsWith(p.PictureBox.Bounds))
                    {
                        PushBack(this.PictureBox, p.PictureBox, 1f, m);
                    }
                }     
                
            }
        }

        // дамаг
        public void Damage(Persone e, Map m)
        {
            if (this.Intersection(e))
            {
                e.heads -= damage;
                // анимация отталкивания 
                PushBack(e.PictureBox, this.PictureBox, speed * 2, m);
            }

        }
    }
}
