using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using static Assigment_3.Form1;
using System.Diagnostics;

namespace Assigment_3
{
    public partial class Form1 : Form
    {
        private FileManager fileManager;
        private List<Student> students;


        public Form1()
        {
            InitializeComponent();
            this.fileManager = new FileManager();
            this.loadDataFromFile();
        }

        private void loadDataFromFile()
        {
            students = new List<Student>();
            string[] studentData = fileManager.readStudentDataFromFile();
            createStudentFromStudentDataArray(studentData);
        }

        private void createStudentFromStudentDataArray(string[] studentData)
        {
            foreach (string studData in studentData)
            {
                string[] lineArray = studData.Split(":");
                Student student = new Student(lineArray[1]);
                student.setStudID(lineArray[0]);
                if (lineArray.Length > 2)
                {
                    string[] courseAndMarkArray = lineArray[2].Split(",");
                    foreach (string cm in courseAndMarkArray)
                    {
                        string[] courseAndMarkSplit = cm.Split("|");
                        Course course = new Course(courseAndMarkSplit[0], Convert.ToDouble(courseAndMarkSplit[1]));
                        student.addCourse(course);
                    }
                }
                students.Add(student);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //Number of Students can not be greater than 4
            if (dataGridView1.Rows.Count > 4 || students.Count == 4)
            {
                MessageBox.Show("Max number of Students have been saved!! ");
                txt_name.Text = string.Empty;
                txt_mark.Text = string.Empty;
                txt_course.Text = string.Empty;
                return;
            }
            if (students.Count != 0)
            {
                /* Use Contains to check if the name is in the List
                   This will be used to check if name already exist
                    so that we can add the course to it
                 */
                List<string> names = new List<string>();
                foreach (Student student in students.ToList())
                {
                    names.Add(student.getName());
                }

                foreach (Student student in students.ToList())
                {
                    Course cs = new Course(txt_course.Text, Convert.ToDouble(txt_mark.Text));
                    if (student.getName().Equals(txt_name.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        if (student.getCourses().Count < 3)
                        {
                            student.addCourse(cs);
                        }
                        else
                        {
                            MessageBox.Show("Max number of courses for a student is 3!! ");
                        }
                    }
                    else if (!names.Contains(txt_name.Text))
                    {
                        Course c = new Course(txt_course.Text, Convert.ToDouble(txt_mark.Text));
                        Student s = new Student(txt_name.Text);
                        s.addCourse(c);
                        students.Add(s);
                        names.Add(s.getName());
                    }
                }

            }

            //make sure the mark is between 0-100
            else if (double.Parse(txt_mark.Text) < 0 || double.Parse(txt_mark.Text) > 100)
            {
                MessageBox.Show("Mark must between 0-100.", "Error", MessageBoxButtons.OK);
            }

            else
            {
                Course c = new Course(txt_course.Text, Convert.ToDouble(txt_mark.Text));
                Student s = new Student(txt_name.Text);
                s.addCourse(c);
                students.Add(s);
            }

            // Delete the file and rewrite it
            File.Delete(fileManager.filePath);
            foreach (Student stud in students.ToList())
            {
                string dataToBeSave = stud.getStudID() + ":" + stud.getName() + ":" + stud.getCourseNamesAndMarks();
                fileManager.saveOrUpdateDataToFile(dataToBeSave);
            }
            txt_name.Text = string.Empty;
            txt_mark.Text = string.Empty;
            txt_course.Text = string.Empty;

        }

        private void btn_dele_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deleting the record....To continue press OK.", "Caution", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                try
                {
                    dataGridView1.Rows.Clear();
                    File.Delete(fileManager.filePath);
                    students.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }  
            }

            else
            {
                Console.WriteLine("Delection canceled.");
            }
            
        }



        private void txt_name_Enter(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

      



        private void btn_load_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                return;
            }
            dataGridView1.Rows.Clear();

            string[] studentData = fileManager.readStudentDataFromFile();
            foreach (string studData in studentData)
            {
                string[] lineArray = studData.Split(":");
                //ID         Name           Coursename|Mark   
                dataGridView1.Rows.Add(new object[] { lineArray[0], lineArray[1], lineArray[2] });
            }
        }


        
        private void btn_update_Click_1(object sender, EventArgs e)
        {
            if (students.Count < 5 && dataGridView1.RowCount < 5)
            {
                if (File.Exists(fileManager.filePath))
                {
                    try
                    {
                        File.Delete(fileManager.filePath);
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            List<string> valList = new List<string>();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.Value == null)
                                {
                                    continue;
                                }
                                valList.Add(cell.Value.ToString());
                            }
                            fileManager.saveOrUpdateDataToFile(string.Join(":", valList));
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred " + ex.Message);
                    }
                }
            }

        

            else
            {
                MessageBox.Show("Max number of Students have been saved!! ");
                txt_name.Text = string.Empty;
                txt_mark.Text = string.Empty;
                txt_course.Text = string.Empty;

            }
            dataGridView1.Rows.Clear();
        }



        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
