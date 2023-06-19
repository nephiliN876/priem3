using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Doctor> Doctors { get; set; }
        public ObservableCollection<Service> Services { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Services = new ObservableCollection<Service>();
            Services.Add(new Service { Name = "Массаж", Price = 1100 });
            Services.Add(new Service { Name = "Водолечебница", Price = 1000 });
            Services.Add(new Service { Name = "Галокамера", Price = 800 });
            Services.Add(new Service { Name = "Диагностика", Price = 1000 });
            Services.Add(new Service { Name = "Косметология", Price = 1000 });
            Services.Add(new Service { Name = "Озонотерапия", Price = 1000 });
            Services.Add(new Service { Name = "Гинекология", Price = 1000 });

            Doctors = new ObservableCollection<Doctor>();
            Doctors.Add(new Doctor { FullName = "Владимир Зеленский", Specialization = "Массажист" });
            Doctors.Add(new Doctor { FullName = "Евгений Пригожин", Specialization = "Косметолог" });
            Doctors.Add(new Doctor { FullName = "Владимир Путин", Specialization = "Хирург" });
            Doctors.Add(new Doctor { FullName = "Дмитрий Анатольевич", Specialization = "Гинеколог" });

            DataContext = this;
            foreach (var doctor in Doctors)
            {
                Console.WriteLine(doctor.FullName);
            }
        }

        private void servicesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (servicesComboBox.SelectedIndex >= 0)
            {
                Service selectedService = (Service)servicesComboBox.SelectedItem;
            }
        }

        private void doctorsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (doctorsComboBox.SelectedIndex >= 0)
            {
                Doctor selectedDoctor = (Doctor)doctorsComboBox.SelectedItem;
            }
        }

        private void bookAppointmentButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Запись на приём успешно сохранена!");
        }
    }

    public class Service
    {
        public string Name { get; set; } = "";
        public int Price { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Doctor
    {
        public string FullName { get; set; } = "";
        public string Specialization { get; set; } = "";

        public override string ToString()
        {
            return FullName;
        }
    }
}

