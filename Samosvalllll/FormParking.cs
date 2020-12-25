using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NLog;


namespace Samosvalllll
{
    public partial class FormParking : Form
    {
        private readonly ParkingCollection parkingCollection;

        private readonly Stack<Vehicle> carStack;

        private readonly Logger logger;

        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            carStack = new Stack<Vehicle>();
            logger = LogManager.GetCurrentClassLogger();
            Draw();
        }

        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >=
            listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index <
            listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }

        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название гаража", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }
        private void buttonDeleteParking_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить гараж { listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили гараж {textBoxNewLevelName.Text}");
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }

        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormCarConfig();
            formCarConfig.AddEvent(AddCar);
            formCarConfig.Show();
        }

        private void AddCar(Vehicle car)
        {
            if (car != null && listBoxParkings.SelectedIndex > -1)
            {
                try
                {
                    if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + car)
                    {
                        Draw();
                        logger.Info($"Добавлена машина {car}");
                    }
                    else
                    {
                        MessageBox.Show("Машину не удалось припарковать");
                    }
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Переполнение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Машину не удалось припарковать");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка");
                }
            }
        }

       
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                try
                {
                    var car = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                    if (car != null)
                    {
                        logger.Info($"Изъята {car} с места {maskedTextBox.Text}");
                        carStack.Push(car);
                    }
                    Draw();
                }

                catch (CarNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Не найдено");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка");
                }    
            }
        }

        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info($"Перешли в гараж {listBoxParkings.SelectedItem.ToString()}");
            Draw();
        }

        private void ButtonUnparkingCars_Click(object sender, EventArgs e)
        {
            if (carStack.Count() > 0)
            {
                FormCar form = new FormCar();
                form.SetCar(carStack.Pop());
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Все машины просмотрены");
            }
        }

        private void СохранитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка при сохранении");
                }         
            }
        }

        private void СохранитьВыбраннуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.SaveData(saveFileDialog.FileName, listBoxParkings.SelectedItem.ToString());
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неверный формат файла");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка при сохранении");
                }
            }
        }

        private void ЗагрузитьВсеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Файл не найден");
                }

                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неверный формат файла");
                }

                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Обращение к NULL объекту", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Обращение к NULL объекту");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка при загрузке");
                }
            }
        }

        private void ЗагрузитьОднуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.LoadOneStage(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Файл не найден");
                }

                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неверный формат файла");
                }

                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message, "Обращение к NULL объекту", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Обращение к NULL объекту");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Fatal("Неизвестная ошибка при загрузке");
                }
            }
        }
    }
}

