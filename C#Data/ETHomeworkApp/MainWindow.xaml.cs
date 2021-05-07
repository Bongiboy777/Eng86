using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ETScaffoldHomework;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ETHomeworkApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
            DisplayAll();
           
        }
        public void DisplayAll()
        {
            using (var db = new ENG86Context())
            {
                (from tre in db.Trainees
                 select tre.TraineeName).ToList().ForEach(x => traineebox.Items.Add(x));

                (from trr in db.Trainers
                 select trr.TrainerName).ToList().ForEach(x => trainerbox.Items.Add(x));

                (from cou in db.Courses
                 select cou.CourseName).ToList().ForEach(x => coursebox.Items.Add(x));

                (from str in db.Streams
                 select str.StreamName).ToList().ForEach(x => streambox.Items.Add(x));

                (from aca in db.Academies
                 select aca.AcademyName).ToList().ForEach(x => academybox.Items.Add(x));
            }
        }
        private void FilterTrainee(object sender, SelectionChangedEventArgs e)
        {

            ClearLists();
            using (var db = new ENG86Context())
            {
                (from tre in db.Trainees
                 join trr in db.Trainers on tre.TrainerId equals trr.TrainerId
                 where tre.TraineeName == e.AddedItems[0] as string
                 select trr.TrainerName).ToList().ForEach(x =>
                 {
                     if (!trainerbox.Items.Contains(x))
                     { trainerbox.Items.Add(x); }
                 }
                 );

                (from tre in db.Trainees
                 join trr in db.Courses on tre.CourseId equals trr.CourseId
                 where tre.TraineeName == e.AddedItems[0] as string
                 select trr.CourseName).ToList().ForEach(x =>
                 {
                     if (!coursebox.Items.Contains(x))
                     { coursebox.Items.Add(x); }


                 }
                 );

                (from tre in db.Trainees
                 join trr in db.Academies on tre.AcademyId equals trr.AcademyId
                 where tre.TraineeName == e.AddedItems[0] as string
                 select trr.AcademyName).ToList().ForEach(x =>
                 {
                     if (!academybox.Items.Contains(x))
                     { academybox.Items.Add(x); }


                 }
                 );

                (from tre in db.Trainees
                 join trr in db.Streams on tre.StreamId equals trr.StreamId
                 where tre.TraineeName == e.AddedItems[0] as string
                 select trr.StreamName).ToList().ForEach(x =>
                 {
                     if (!streambox.Items.Contains(x))
                     { streambox.Items.Add(x); }
                 }
                 );
            }

        }
        private void ClearLists()
        {
            //traineebox.Items.Clear();
            trainerbox.Items.Clear();
            coursebox.Items.Clear();
            streambox.Items.Clear();
            academybox.Items.Clear();


        }
    }
}
