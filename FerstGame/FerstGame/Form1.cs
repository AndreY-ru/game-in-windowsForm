using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FerstGame
{
    public partial class Form : System.Windows.Forms.Form
    {
        bool win = false;
        bool lose = false;
        int k = 1;

        int PersonX = 150;
        int PersonY = 50;
        int FoeX = 150;
        int FoeY = 150;

        public Persone persone;
        public Foe monster;
        public Map map;

        public List<Block> blocks;
        public List<Coin> coins;
        public Form()
        {
            InitializeComponent();
            map = new Map(this.Width, this.Height);

            gg.Top = PersonY;
            gg.Left = PersonX;
            foe.Top = FoeY;
            foe.Left = FoeX;

            persone = new Persone(PersonX, PersonY, gg, 5, 5, 0);
            monster = new Foe(FoeX, FoeY, foe, 2, 5, 0, 1);

            blocks = new List<Block>();
            CreateBlocks(5); // создаем стены

            coins = new List<Coin>();
            CreateCoins(5); // Создаем монеты


            // элементы меню проигрыша
            labelLose.Visible = false;
            Replay.Visible = false;
            Exit.Visible = false;
            KeyPreview = true;
            labelCoins.Visible = false;
            labelwin.Visible = false;

            level.Text = "Уровень " + k.ToString();

            timer.Stop();
        }

        private void CreateBlocks(int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                start:
                int Width = random.Next(2, map.WidthMap - persone.spriteWidth * 2);
                int Hight = random.Next(2, map.HeightMap - persone.spriteHeight * 2);

                int x = random.Next(persone.spriteWidth, map.WidthMap - Width - persone.spriteWidth);
                int y = random.Next(persone.spriteWidth, map.HeightMap - Hight - persone.spriteWidth);


                PictureBox blockPicture = CreatePicture(x, y, Width, Hight, Color.Black);
                
                if (blockPicture.Bounds.IntersectsWith(persone.PictureBox.Bounds) ||
                blockPicture.Bounds.IntersectsWith(monster.PictureBox.Bounds))
                {
                    goto start;
                }
                

                this.Controls.Add(blockPicture); // Добавление на форму
                blocks.Add(new Block(x, y, blockPicture));
            }
        }

        private void CreateCoins(int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                start:
                int x = random.Next(0, map.WidthMap - 8);
                int y = random.Next(0, map.HeightMap - 8);

                PictureBox coinPicture = CreatePicture(x, y, 8, 8, Color.Yellow);
                foreach (Block b in blocks) {
                    if (coinPicture.Bounds.IntersectsWith(b.PictureBox.Bounds) ||
                        coinPicture.Bounds.IntersectsWith(persone.PictureBox.Bounds))
                    {
                        goto start;
                    }
                }

                this.Controls.Add(coinPicture); // Добавление на форму
                coins.Add(new Coin(x, y, coinPicture));
            }
        }

        // Метод для создания PictureBox
        private PictureBox CreatePicture(int x, int y, int Width, int Height,Color color)
        {
            PictureBox coinPicture = new PictureBox();
            coinPicture.Width = Width; // Ширина монеты
            coinPicture.Height = Height; // Высота монеты
            coinPicture.BackColor = color; // Установка желтого цвета
            coinPicture.Top = y;
            coinPicture.Left = x;

            return coinPicture;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Создаем массив для монеток и очков жизни
            var head = new[] { Heat1, Heat2, Heat3, Heat4, Heat5 };

            // логика передвижения врага
            monster.Go(persone, blocks, map);
            
            // Проверка на визуальное касание
            if (persone.Intersection(monster))
            {
                head[persone.heads-1].Visible = false;

                monster.Damage(persone, map);

                if (persone.heads <= 0)
                {
                    timer.Stop();
                    lose = true;
                    labelLose.Visible = true;
                    Replay.Visible = true;
                    Exit.Visible = true;
                    labelCoins.Visible = true;
                    labelCoins.Text = "Собрано монет: " + persone.coins.ToString();
                }
            }            

            foreach (Coin coin in coins)
            {
                if (coin.PictureBox.Bounds.IntersectsWith(gg.Bounds))
                {
                    if (coin.PictureBox.Visible == true)
                    {
                        persone.speed += 1;
                        persone.coins += 1;
                    }
                    coin.PictureBox.Visible = false;
                }
            }

            if (persone.coins == 5 && k == 1)
            {
                win = true;
                timer.Stop();
                k++;
                level.Text = "Уровень " + k.ToString();

                level.Visible = true;
                btnStart.Visible = true;
                labelCoins.Visible = true;
                labelCoins.Text = "Собрано монет: " + persone.coins.ToString();
            }
            else if (k == 2 && persone.coins == 10) 
            {
                win = true;

                timer.Stop();
                k++;
                level.Text = "Уровень " + k.ToString();

                level.Visible = true;
                btnStart.Visible = true;
                labelCoins.Visible = true;
                labelCoins.Text = "Собрано монет: " + persone.coins.ToString();
            }
            else if (k == 3 && persone.coins == 15)
            {
                win = true;

                timer.Stop();

                labelwin.Visible = true;
                Replay.Visible = true;
                Exit.Visible = true;
                labelCoins.Visible = true;
                labelCoins.Text = "Собрано монет: " + persone.coins.ToString();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose == false && win == false)
            {
                persone.Go(e, blocks, map);
            }
        }
        // обработчик перетаскивания формы
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Replay_Click(object sender, EventArgs e)
        {
            win = false;
            lose = false;
            k = 1;

            // Создаем массив для очков жизни
            var heads = new[] { Heat1, Heat2, Heat3, Heat4, Heat5 };
            foreach (var head in heads) { head.Visible = true; }

            // Удаление монеток
            foreach (Coin coin in coins.ToList())
            {
                this.Controls.Remove(coin.PictureBox);
            }
            coins.Clear(); // Очистка списка монеток

            // Удаление блоков
            foreach (Block block in blocks.ToList())
            {
                this.Controls.Remove(block.PictureBox);
            }
            blocks.Clear(); // Очистка списка 

            // персонажи
            persone.coins = 0;
            persone.heads = 5;
            persone.speed = 5;
            persone.Move(PersonX, PersonY);
            monster.Move(FoeX, FoeY);


            CreateBlocks(5);
            CreateCoins(5);


            level.Text = "Уровень " + k.ToString();
            level.Visible = true;
            btnStart.Visible = true;
            // элементы меню проигрыша
            labelLose.Visible = false;
            Replay.Visible = false;
            Exit.Visible = false;
            KeyPreview = true;
            labelCoins.Visible = false;
            labelwin.Visible = false;

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void level_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            win = false;
            labelCoins.Visible = false;
            level.Visible = false;
            btnStart.Visible = false;
            if (k != 1)
            {
                // Создаем массив для очков жизни
                var heads = new[] { Heat1, Heat2, Heat3, Heat4, Heat5 };

                foreach (var head in heads) { head.Visible = true; }

                // Удаление монеток
                foreach (Coin coin in coins.ToList())
                {
                    this.Controls.Remove(coin.PictureBox);
                }
                coins.Clear(); // Очистка списка монеток

                // Удаление блоков
                foreach (Block block in blocks.ToList())
                {
                    this.Controls.Remove(block.PictureBox);
                }
                blocks.Clear(); // Очистка списка блоков

                // персонажи
                persone.heads = 5;
                persone.Move(PersonX, PersonY);
                monster.Move(FoeX, FoeY);


                CreateBlocks(5);
                CreateCoins(5);
            }
            timer.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}