using EFCoreMarathon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace EFCoreMarathon
{
    public partial class Record : Form
    {
        MyDBContext _db = new MyDBContext();
        public Record()
        {
            InitializeComponent();
            SetDatasInGridView();  
        }

        
        private void Record_Load(object sender, EventArgs e)
        {
            lblUser.Text = StaticEge.LoggedUser.UserName.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var album = new Album
                {
                    UserId = StaticEge.LoggedUser.UserId,
                    Title = txtAlbumName.Text,
                    Artist = txtArtist.Text,
                    ReleaseDate = dateTimePickerReleaseDate.Value,
                    Price = decimal.Parse(txtPrice.Text),
                    Discount = decimal.Parse(txtDiscount.Text),
                    IsOnSale = checkBoxControl.Checked
                };
                _db.Albums.Add(album);
                _db.SaveChanges();
                SetDatasInGridView();
                ClearDatas();
                MessageBox.Show("Album has added!");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var album = dataGridView1.SelectedRows[0].DataBoundItem as Album;
                    album.Title = txtAlbumName.Text;
                    album.Artist = txtArtist.Text;
                    album.ReleaseDate = dateTimePickerReleaseDate.Value;
                    album.Price = decimal.Parse(txtPrice.Text);
                    album.Discount = decimal.Parse(txtDiscount.Text);
                    album.IsOnSale = checkBoxControl.Checked;
                    _db.SaveChanges();
                    SetDatasInGridView();
                    ClearDatas();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var album = dataGridView1.SelectedRows[0].DataBoundItem as Album;
                    _db.Albums.Remove(album);
                    _db.SaveChanges();
                    SetDatasInGridView();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }


        private void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    var discontinuedAlbums = _db.Albums.Where(a => a.IsOnSale == false).Select(x => new { x.Title, x.Artist }).ToList();
                    dataGridView1.DataSource = discontinuedAlbums;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    var continuedAlbums = _db.Albums.Where(a => a.IsOnSale == true).Select(x => new { x.Title, x.Artist }).ToList();
                    dataGridView1.DataSource = continuedAlbums;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    var recentlyAdded10Albums = _db.Albums.OrderByDescending(a => a.AlbumId).Take(10).Select(x => new { x.Title, x.Artist }).ToList();
                    dataGridView1.DataSource = recentlyAdded10Albums;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    var albumsOnDiscount = _db.Albums.Where(a => a.Discount > 0).Select(x => new { x.Title, x.Artist }).ToList();
                    dataGridView1.DataSource = albumsOnDiscount;
                }
                else
                {
                    MessageBox.Show("Please choose a query!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearDatas();
            SetDatasInGridView();
        }

        public void SetDatasInGridView()
        {
            dataGridView1.DataSource = _db.Albums.ToList();
            dataGridView1.AutoGenerateColumns = false;
        }

        public void ClearDatas()
        {
            txtAlbumName.Text = txtArtist.Text = txtDiscount.Text = txtPrice.Text = string.Empty;

        }
    }
}
