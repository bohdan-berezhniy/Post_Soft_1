namespace Publications
{
    partial class ПрийняттяПредоплати
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ПрийняттяПредоплати));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ВидПередоплати = new System.Windows.Forms.ComboBox();
            this.ВидПослуги = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.КількістьКупівля = new System.Windows.Forms.TextBox();
            this.Назва = new System.Windows.Forms.ComboBox();
            this.Індекс = new System.Windows.Forms.ComboBox();
            this.Передоплатник = new System.Windows.Forms.GroupBox();
            this.Квартира = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Корпус = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Будинок = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Вулиця = new System.Windows.Forms.TextBox();
            this.НомерТелефону = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Область = new System.Windows.Forms.TextBox();
            this.ПоБатькові = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.НаселенийПункт = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Імя = new System.Windows.Forms.TextBox();
            this.ПоштовийІндекс = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Прізвище = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Країна = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ЗагальнаВартість = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ВартістьПослуги = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ВартістьВидання = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Друк = new System.Windows.Forms.LinkLabel();
            this.Додати = new System.Windows.Forms.LinkLabel();
            this.ГоловнеМеню = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Оновити = new System.Windows.Forms.LinkLabel();
            this.ДатаПочатку = new System.Windows.Forms.DateTimePicker();
            this.ДатаКінця = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Кількість = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.sendTo = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Передоплатник.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ВидПередоплати);
            this.groupBox1.Controls.Add(this.ВидПослуги);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Послуга";
            // 
            // ВидПередоплати
            // 
            this.ВидПередоплати.FormattingEnabled = true;
            this.ВидПередоплати.Items.AddRange(new object[] {
            "Рік",
            "Півроку"});
            this.ВидПередоплати.Location = new System.Drawing.Point(143, 19);
            this.ВидПередоплати.Name = "ВидПередоплати";
            this.ВидПередоплати.Size = new System.Drawing.Size(121, 21);
            this.ВидПередоплати.TabIndex = 2;
            this.ВидПередоплати.Text = "Вид передоплати";
            this.ВидПередоплати.SelectedIndexChanged += new System.EventHandler(this.ВидПередоплати_SelectedIndexChanged);
            // 
            // ВидПослуги
            // 
            this.ВидПослуги.FormattingEnabled = true;
            this.ВидПослуги.Items.AddRange(new object[] {
            "Передоплата\t",
            "Купівля\t"});
            this.ВидПослуги.Location = new System.Drawing.Point(6, 19);
            this.ВидПослуги.Name = "ВидПослуги";
            this.ВидПослуги.Size = new System.Drawing.Size(121, 21);
            this.ВидПослуги.TabIndex = 1;
            this.ВидПослуги.Text = "Вид послуги";
            this.ВидПослуги.SelectedIndexChanged += new System.EventHandler(this.ВидПослуги_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.КількістьКупівля);
            this.groupBox2.Controls.Add(this.Назва);
            this.groupBox2.Controls.Add(this.Індекс);
            this.groupBox2.Location = new System.Drawing.Point(9, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 55);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Видання";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(283, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 16);
            this.label20.TabIndex = 23;
            this.label20.Text = "Кількість";
            this.label20.Visible = false;
            // 
            // КількістьКупівля
            // 
            this.КількістьКупівля.Location = new System.Drawing.Point(354, 20);
            this.КількістьКупівля.Name = "КількістьКупівля";
            this.КількістьКупівля.Size = new System.Drawing.Size(100, 20);
            this.КількістьКупівля.TabIndex = 23;
            this.КількістьКупівля.Text = "1";
            this.КількістьКупівля.Visible = false;
            this.КількістьКупівля.MouseClick += new System.Windows.Forms.MouseEventHandler(this.КількістьКупівля_MouseClick);
            this.КількістьКупівля.KeyUp += new System.Windows.Forms.KeyEventHandler(this.КількістьКупівля_KeyUp);
            // 
            // Назва
            // 
            this.Назва.FormattingEnabled = true;
            this.Назва.Location = new System.Drawing.Point(143, 19);
            this.Назва.Name = "Назва";
            this.Назва.Size = new System.Drawing.Size(121, 21);
            this.Назва.TabIndex = 2;
            this.Назва.Text = "Назва";
            this.Назва.SelectedIndexChanged += new System.EventHandler(this.Назва_SelectedIndexChanged);
            // 
            // Індекс
            // 
            this.Індекс.FormattingEnabled = true;
            this.Індекс.Location = new System.Drawing.Point(6, 19);
            this.Індекс.Name = "Індекс";
            this.Індекс.Size = new System.Drawing.Size(121, 21);
            this.Індекс.TabIndex = 1;
            this.Індекс.Text = "Індекс";
            this.Індекс.SelectedIndexChanged += new System.EventHandler(this.Індекс_SelectedIndexChanged);
            // 
            // Передоплатник
            // 
            this.Передоплатник.Controls.Add(this.Квартира);
            this.Передоплатник.Controls.Add(this.label15);
            this.Передоплатник.Controls.Add(this.Корпус);
            this.Передоплатник.Controls.Add(this.label14);
            this.Передоплатник.Controls.Add(this.Будинок);
            this.Передоплатник.Controls.Add(this.label13);
            this.Передоплатник.Controls.Add(this.Вулиця);
            this.Передоплатник.Controls.Add(this.НомерТелефону);
            this.Передоплатник.Controls.Add(this.label9);
            this.Передоплатник.Controls.Add(this.label8);
            this.Передоплатник.Controls.Add(this.Область);
            this.Передоплатник.Controls.Add(this.ПоБатькові);
            this.Передоплатник.Controls.Add(this.label10);
            this.Передоплатник.Controls.Add(this.НаселенийПункт);
            this.Передоплатник.Controls.Add(this.label7);
            this.Передоплатник.Controls.Add(this.label11);
            this.Передоплатник.Controls.Add(this.Імя);
            this.Передоплатник.Controls.Add(this.ПоштовийІндекс);
            this.Передоплатник.Controls.Add(this.label5);
            this.Передоплатник.Controls.Add(this.label12);
            this.Передоплатник.Controls.Add(this.Прізвище);
            this.Передоплатник.Controls.Add(this.label4);
            this.Передоплатник.Controls.Add(this.Країна);
            this.Передоплатник.Controls.Add(this.label6);
            this.Передоплатник.Location = new System.Drawing.Point(9, 266);
            this.Передоплатник.Name = "Передоплатник";
            this.Передоплатник.Size = new System.Drawing.Size(779, 157);
            this.Передоплатник.TabIndex = 9;
            this.Передоплатник.TabStop = false;
            this.Передоплатник.Text = "Передоплатник";
            // 
            // Квартира
            // 
            this.Квартира.Location = new System.Drawing.Point(636, 110);
            this.Квартира.Name = "Квартира";
            this.Квартира.Size = new System.Drawing.Size(100, 20);
            this.Квартира.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(559, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Квартира";
            // 
            // Корпус
            // 
            this.Корпус.Location = new System.Drawing.Point(444, 113);
            this.Корпус.Name = "Корпус";
            this.Корпус.Size = new System.Drawing.Size(100, 20);
            this.Корпус.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(383, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Корпус";
            // 
            // Будинок
            // 
            this.Будинок.Location = new System.Drawing.Point(269, 113);
            this.Будинок.Name = "Будинок";
            this.Будинок.Size = new System.Drawing.Size(100, 20);
            this.Будинок.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(193, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Будинок";
            // 
            // Вулиця
            // 
            this.Вулиця.Location = new System.Drawing.Point(71, 114);
            this.Вулиця.Name = "Вулиця";
            this.Вулиця.Size = new System.Drawing.Size(100, 20);
            this.Вулиця.TabIndex = 23;
            // 
            // НомерТелефону
            // 
            this.НомерТелефону.Location = new System.Drawing.Point(673, 47);
            this.НомерТелефону.Name = "НомерТелефону";
            this.НомерТелефону.Size = new System.Drawing.Size(100, 20);
            this.НомерТелефону.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(9, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Вулиця";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(546, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Номер телефону";
            // 
            // Область
            // 
            this.Область.Location = new System.Drawing.Point(572, 78);
            this.Область.Name = "Область";
            this.Область.Size = new System.Drawing.Size(100, 20);
            this.Область.TabIndex = 21;
            // 
            // ПоБатькові
            // 
            this.ПоБатькові.Location = new System.Drawing.Point(433, 47);
            this.ПоБатькові.Name = "ПоБатькові";
            this.ПоБатькові.Size = new System.Drawing.Size(100, 20);
            this.ПоБатькові.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(503, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Область";
            // 
            // НаселенийПункт
            // 
            this.НаселенийПункт.Location = new System.Drawing.Point(386, 78);
            this.НаселенийПункт.Name = "НаселенийПункт";
            this.НаселенийПункт.Size = new System.Drawing.Size(100, 20);
            this.НаселенийПункт.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(341, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "По-батькові";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(247, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Населений пункт";
            // 
            // Імя
            // 
            this.Імя.Location = new System.Drawing.Point(226, 47);
            this.Імя.Name = "Імя";
            this.Імя.Size = new System.Drawing.Size(100, 20);
            this.Імя.TabIndex = 11;
            // 
            // ПоштовийІндекс
            // 
            this.ПоштовийІндекс.Location = new System.Drawing.Point(133, 78);
            this.ПоштовийІндекс.Name = "ПоштовийІндекс";
            this.ПоштовийІндекс.Size = new System.Drawing.Size(100, 20);
            this.ПоштовийІндекс.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(193, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Імя";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(9, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Поштовий індекс";
            // 
            // Прізвище
            // 
            this.Прізвище.Location = new System.Drawing.Point(85, 47);
            this.Прізвище.Name = "Прізвище";
            this.Прізвище.Size = new System.Drawing.Size(100, 20);
            this.Прізвище.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Прізвище";
            // 
            // Країна
            // 
            this.Країна.Location = new System.Drawing.Point(66, 19);
            this.Країна.Name = "Країна";
            this.Країна.Size = new System.Drawing.Size(100, 20);
            this.Країна.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Країна";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ЗагальнаВартість);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.ВартістьПослуги);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.ВартістьВидання);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(9, 429);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(779, 61);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вартість";
            // 
            // ЗагальнаВартість
            // 
            this.ЗагальнаВартість.Location = new System.Drawing.Point(627, 21);
            this.ЗагальнаВартість.Name = "ЗагальнаВартість";
            this.ЗагальнаВартість.Size = new System.Drawing.Size(100, 20);
            this.ЗагальнаВартість.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(493, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 16);
            this.label18.TabIndex = 34;
            this.label18.Text = "Загальна вартість";
            // 
            // ВартістьПослуги
            // 
            this.ВартістьПослуги.Location = new System.Drawing.Point(373, 21);
            this.ВартістьПослуги.Name = "ВартістьПослуги";
            this.ВартістьПослуги.Size = new System.Drawing.Size(100, 20);
            this.ВартістьПослуги.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(247, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 16);
            this.label17.TabIndex = 32;
            this.label17.Text = "Вартість послуги";
            // 
            // ВартістьВидання
            // 
            this.ВартістьВидання.Location = new System.Drawing.Point(132, 21);
            this.ВартістьВидання.Name = "ВартістьВидання";
            this.ВартістьВидання.Size = new System.Drawing.Size(100, 20);
            this.ВартістьВидання.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(9, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "Вартість видання";
            // 
            // Друк
            // 
            this.Друк.AutoSize = true;
            this.Друк.Enabled = false;
            this.Друк.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Друк.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Друк.Location = new System.Drawing.Point(808, 432);
            this.Друк.Name = "Друк";
            this.Друк.Size = new System.Drawing.Size(40, 16);
            this.Друк.TabIndex = 10;
            this.Друк.TabStop = true;
            this.Друк.Text = "Друк";
            this.Друк.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Друк_LinkClicked);
            // 
            // Додати
            // 
            this.Додати.AutoSize = true;
            this.Додати.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Додати.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Додати.Location = new System.Drawing.Point(808, 468);
            this.Додати.Name = "Додати";
            this.Додати.Size = new System.Drawing.Size(131, 16);
            this.Додати.TabIndex = 11;
            this.Додати.TabStop = true;
            this.Додати.Text = "Додати й зберегти";
            this.Додати.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Додати_LinkClicked);
            // 
            // ГоловнеМеню
            // 
            this.ГоловнеМеню.AutoSize = true;
            this.ГоловнеМеню.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ГоловнеМеню.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ГоловнеМеню.Location = new System.Drawing.Point(1221, 468);
            this.ГоловнеМеню.Name = "ГоловнеМеню";
            this.ГоловнеМеню.Size = new System.Drawing.Size(101, 16);
            this.ГоловнеМеню.TabIndex = 13;
            this.ГоловнеМеню.TabStop = true;
            this.ГоловнеМеню.Text = "Головне меню";
            this.ГоловнеМеню.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ГоловнеМеню_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(794, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 166);
            this.dataGridView1.TabIndex = 14;
            // 
            // Оновити
            // 
            this.Оновити.AutoSize = true;
            this.Оновити.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Оновити.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Оновити.Location = new System.Drawing.Point(1032, 468);
            this.Оновити.Name = "Оновити";
            this.Оновити.Size = new System.Drawing.Size(65, 16);
            this.Оновити.TabIndex = 15;
            this.Оновити.TabStop = true;
            this.Оновити.Text = "Оновити";
            this.Оновити.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Оновити_LinkClicked);
            // 
            // ДатаПочатку
            // 
            this.ДатаПочатку.Location = new System.Drawing.Point(32, 19);
            this.ДатаПочатку.MinDate = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            this.ДатаПочатку.Name = "ДатаПочатку";
            this.ДатаПочатку.Size = new System.Drawing.Size(200, 20);
            this.ДатаПочатку.TabIndex = 0;
            this.ДатаПочатку.Value = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            this.ДатаПочатку.ValueChanged += new System.EventHandler(this.ДатаПочатку_ValueChanged);
            // 
            // ДатаКінця
            // 
            this.ДатаКінця.Location = new System.Drawing.Point(286, 19);
            this.ДатаКінця.MinDate = new System.DateTime(2018, 5, 1, 0, 0, 0, 0);
            this.ДатаКінця.Name = "ДатаКінця";
            this.ДатаКінця.Size = new System.Drawing.Size(200, 20);
            this.ДатаКінця.TabIndex = 1;
            this.ДатаКінця.ValueChanged += new System.EventHandler(this.ДатаКінця_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "З";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(247, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "по";
            // 
            // Кількість
            // 
            this.Кількість.Location = new System.Drawing.Point(584, 19);
            this.Кількість.Name = "Кількість";
            this.Кількість.Size = new System.Drawing.Size(100, 20);
            this.Кількість.TabIndex = 7;
            this.Кількість.Text = "1";
            this.Кількість.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Кількість_MouseClick);
            this.Кількість.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Кількість_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(503, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Кількість";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(9, 52);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 16);
            this.label19.TabIndex = 9;
            this.label19.Text = "Помісячно";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Розривка предоплати";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(12, 98);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(54, 98);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(100, 98);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(140, 98);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Enabled = false;
            this.radioButton5.Location = new System.Drawing.Point(177, 98);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Enabled = false;
            this.radioButton6.Location = new System.Drawing.Point(214, 98);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(31, 17);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Enabled = false;
            this.radioButton8.Location = new System.Drawing.Point(295, 98);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(31, 17);
            this.radioButton8.TabIndex = 18;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "8";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Enabled = false;
            this.radioButton9.Location = new System.Drawing.Point(332, 98);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(31, 17);
            this.radioButton9.TabIndex = 19;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Enabled = false;
            this.radioButton10.Location = new System.Drawing.Point(373, 98);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(37, 17);
            this.radioButton10.TabIndex = 20;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "10";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Enabled = false;
            this.radioButton11.Location = new System.Drawing.Point(416, 98);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(37, 17);
            this.radioButton11.TabIndex = 21;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "11";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Enabled = false;
            this.radioButton12.Location = new System.Drawing.Point(459, 98);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(37, 17);
            this.radioButton12.TabIndex = 22;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "12";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton12);
            this.groupBox3.Controls.Add(this.radioButton11);
            this.groupBox3.Controls.Add(this.radioButton10);
            this.groupBox3.Controls.Add(this.radioButton9);
            this.groupBox3.Controls.Add(this.radioButton8);
            this.groupBox3.Controls.Add(this.radioButton7);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Кількість);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ДатаКінця);
            this.groupBox3.Controls.Add(this.ДатаПочатку);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(9, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(779, 126);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Передоплата";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Enabled = false;
            this.radioButton7.Location = new System.Drawing.Point(255, 98);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(31, 17);
            this.radioButton7.TabIndex = 17;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "7";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.sendTo);
            this.panel6.Location = new System.Drawing.Point(794, 191);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(177, 45);
            this.panel6.TabIndex = 16;
            // 
            // sendTo
            // 
            this.sendTo.Enabled = false;
            this.sendTo.Location = new System.Drawing.Point(4, 13);
            this.sendTo.Name = "sendTo";
            this.sendTo.Size = new System.Drawing.Size(167, 20);
            this.sendTo.TabIndex = 3;
            this.sendTo.Text = "Введіть e-mail отримувача";
            this.sendTo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sendTo_MouseClick);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendEmail.BackgroundImage")));
            this.btnSendEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSendEmail.Enabled = false;
            this.btnSendEmail.Location = new System.Drawing.Point(972, 191);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(44, 45);
            this.btnSendEmail.TabIndex = 17;
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // ПрийняттяПредоплати
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 500);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.Оновити);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ГоловнеМеню);
            this.Controls.Add(this.Додати);
            this.Controls.Add(this.Друк);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Передоплатник);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ПрийняттяПредоплати";
            this.Text = "Прийняття передоплати";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ПрийняттяПредоплати_FormClosing);
            this.Load += new System.EventHandler(this.ПрийняттяПредоплати_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Передоплатник.ResumeLayout(false);
            this.Передоплатник.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ВидПередоплати;
        private System.Windows.Forms.ComboBox ВидПослуги;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Назва;
        private System.Windows.Forms.ComboBox Індекс;
        private System.Windows.Forms.GroupBox Передоплатник;
        private System.Windows.Forms.TextBox Країна;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Прізвище;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox НомерТелефону;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ПоБатькові;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Імя;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Корпус;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Будинок;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Вулиця;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Область;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox НаселенийПункт;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ПоштовийІндекс;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Квартира;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox ЗагальнаВартість;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ВартістьПослуги;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ВартістьВидання;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.LinkLabel Друк;
        private System.Windows.Forms.LinkLabel Додати;
        private System.Windows.Forms.LinkLabel ГоловнеМеню;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox КількістьКупівля;
        private System.Windows.Forms.LinkLabel Оновити;
        private System.Windows.Forms.DateTimePicker ДатаПочатку;
        private System.Windows.Forms.DateTimePicker ДатаКінця;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Кількість;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox sendTo;
        private System.Windows.Forms.Button btnSendEmail;
    }
}