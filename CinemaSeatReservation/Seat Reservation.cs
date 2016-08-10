using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Configuration;


namespace CinemaSeatReservation
{
    public partial class Form1 : Form
    {

        List<Movie> movieList;
        Movie selectedMovie;
        Projection selectedProjection;
        int selectedSeatIndex;
        string xmlMovies = ConfigurationManager.AppSettings.Get("filePath");
        public Form1()
        {
            InitializeComponent();
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Movie>), new XmlRootAttribute("movieList"));
            XmlTextReader reader = new XmlTextReader(xmlMovies);
            movieList = (List<Movie>)deserializer.Deserialize(reader);
           foreach (Movie m in movieList)
                movieListBox.Items.Add(m.name);
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void movieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            feedback_L.Text = null;
            projectionListBox.Items.Clear();
            seatListBox.Items.Clear();
            foreach (Movie m in movieList)
                if(movieListBox.SelectedItem.ToString()==m.name)
                {
                    selectedMovie = m;
                    foreach (Projection p in m.projections)
                        projectionListBox.Items.Add(p.date.getDate() + "  " + p.time.getTime());
                }
        }

        private void projectionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            feedback_L.Text = null;
            seatListBox.Items.Clear();
                foreach (Projection p in selectedMovie.projections)
                    if (projectionListBox.SelectedItem.ToString() == p.date.getDate() + "  " + p.time.getTime())
                    {

                        selectedProjection = p;
                        for (int i = 0; i < 100; i++ )
                        {
                            if (p.salon.seats[i]==false)
                                seatListBox.Items.Add(i+1);
                            else
                                seatListBox.Items.Add(i + 1 + " (reserved)");
                        }
                    }
        }

        private void reserveB_Click(object sender, EventArgs e)
        {
            foreach (Movie m in movieList)
                foreach (Projection p in m.projections)
                    for (int i = 0; i < 100; i++)
                    {
                        if (selectedMovie == m && selectedProjection == p && selectedSeatIndex == i)
                        {
                            if (p.salon.seats[i] == true)
                                feedback_L.Text = "Spot already taken.";
                            else
                            {
                                p.salon.seats[i] = true;
                                feedback_L.Text = "Seat has been reserved.";
                            }
                        }
                    }
            seatListBox.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (selectedProjection.salon.seats[i] == false)
                    seatListBox.Items.Add(i + 1);
                else
                    seatListBox.Items.Add(i + 1 + " (reserved)");
            }

        }

        private void seatListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSeatIndex = seatListBox.SelectedIndex;
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            foreach (Movie m in movieList)
                foreach (Projection p in m.projections)
                    for (int i = 0; i < 100; i++)
                    {
                        if (selectedMovie == m && selectedProjection == p && selectedSeatIndex == i)
                        {
                            if (p.salon.seats[i] == false)
                            {
                                feedback_L.Text = "No reservation on this spot.";
                            }
                            else
                            {
                            p.salon.seats[i] = false;
                            feedback_L.Text = "Reservation canceled.";
                            }
                        }
                    }
            seatListBox.Items.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (selectedProjection.salon.seats[i] == false)
                    seatListBox.Items.Add(i + 1);
                else
                    seatListBox.Items.Add(i + 1 + " (reserved)");
            }

        }

        private void saveB_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>), new XmlRootAttribute("movieList"));
            StreamWriter writer = new StreamWriter(xmlMovies);
            serializer.Serialize(writer, movieList);
            writer.Close();
            feedback_L.Text = "Data has been saved.";
        }
    }
}
