using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Food> beverage = new ObservableCollection<Food>();
        private ObservableCollection<Food> mainCourse = new ObservableCollection<Food>();
        private ObservableCollection<Food> appetizer = new ObservableCollection<Food>();
        private ObservableCollection<Food> dessert = new ObservableCollection<Food>();

        private ObservableCollection<Food> foodList = new ObservableCollection<Food>();
        int foodCnt;
        double sum;
        string sub, tax = "15%", total;

        public MainWindow()
        {
            InitializeComponent();

            LoadCollectionData();
            
            cbBeverage.ItemsSource = beverage;
            cbMainCourse.ItemsSource = mainCourse;
            cbAppetizer.ItemsSource = appetizer;
            cbDessert.ItemsSource = dessert;

            myBill.ItemsSource = foodList;
            foodCnt = 0;
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
        private void LoadCollectionData()
        {
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 0,
                Name = "-------Select------",
                Category = "",
                Price = 0.0
            });
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 1,
                Name = "Soda",
                Category = "Beverage",
                Price = 1.95
            }
            );
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 2,
                Name = "Tea",
                Category = "Beverage",
                Price = 1.50
            }
            );
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 3,
                Name = "Coffee",
                Category = "Beverage",
                Price = 1.25
            }
            );
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 4,
                Name = "Mineral Water",
                Category = "Beverage",
                Price = 2.95
            }
            );
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 5,
                Name = "Juice",
                Category = "Beverage",
                Price = 2.50
            }
            );
            beverage.Add(new Food()
            {
                Quantity = 1,
                ID = 6,
                Name = "Milk",
                Category = "Beverage",
                Price = 1.50
            }
            );
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 0,
                Name = "-------Select------",
                Category = "",
                Price = 0.0
            });
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 7,
                Name = "Buffalo Wings",
                Category = "Appetizer",
                Price = 5.95
            }
            );
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 8,
                Name = "Buffalo Fingers",
                Category = "Appetizer",
                Price = 6.95
            }
            );
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 9,
                Name = "Potato Skins",
                Category = "Appetizer",
                Price = 8.95
            });
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 10,
                Name = "Nachos",
                Category = "Appetizer",
                Price = 8.95
            }
            );
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 11,
                Name = "Mushroom Caps",
                Category = "Appetizer",
                Price = 10.95
            });
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 12,
                Name = "Shrimp Cocktail",
                Category = "Appetizer",
                Price = 12.95
            });
            appetizer.Add(new Food()
            {
                Quantity = 1,
                ID = 13,
                Name = "Chips and Salsa",
                Category = "Appetizer",
                Price = 6.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 0,
                Name = "-------Select------",
                Category = "",
                Price = 0.0
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 14,
                Name = "Seafood Alfredo",
                Category = "Main Course",
                Price = 15.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 15,
                Name = "Chicken Alfredo",
                Category = "Main Course",
                Price = 13.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 16,
                Name = "Turkey Club",
                Category = "Main Course",
                Price = 11.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 17,
                Name = "Lobster Pie",
                Category = "Main Course",
                Price = 19.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 18,
                Name = "Prime Rib",
                Category = "Main Course",
                Price = 20.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 19,
                Name = "Shrimp Scampi",
                Category = "Main Course",
                Price = 18.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 20,
                Name = "Turkey Dinner",
                Category = "Main Course",
                Price = 13.95
            });
            mainCourse.Add(new Food()
            {
                Quantity = 1,
                ID = 21,
                Name = "Stuffed Chicken",
                Category = "Main Course",
                Price = 14.95
            });
            dessert.Add(new Food()
            {
                Quantity = 1,
                ID = 0,
                Name = "-------Select------",
                Category = "",
                Price = 0.0
            });
            dessert.Add(new Food()
            {
                Quantity = 1,
                ID = 22,
                Name = "Apple Pie",
                Category = "Dessert",
                Price = 5.95
            });

            dessert.Add(new Food()
            {
                Quantity = 1,
                ID = 23,
                Name = "Sundae",
                Category = "Dessert",
                Price = 3.95
            });
            dessert.Add(new Food()
            {
                Quantity = 1,
                ID = 24,
                Name = "Carrot Cake",
                Category = "Dessert",
                Price = 5.95
            });
            dessert.Add(new Food()
            {
                Quantity = 1,
                ID = 25,
                Name = "Mud Pie",
                Category = "Dessert",
                Price = 4.95
            });
            dessert.Add(new Food()
            {
                Quantity = 1,
                ID = 26,
                Name = "Apple Crisp",
                Category = "Dessert",
                Price = 5.95
            });

        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClearItem_Click(object sender, RoutedEventArgs e)
        {
            if (myBill.SelectedIndex == -1) { MessageBox.Show("Please select an item"); }
            else { foodList.RemoveAt(myBill.SelectedIndex); }
        }

        private void Cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            var selected = sender as ComboBox;
            bool added = false;
            if (selected.SelectedIndex.ToString() == "-1" || Int32.Parse(selected.SelectedIndex.ToString()) == 0)
            {

            }
            else
            {
                Food food1 = selected.SelectedValue as Food;
                if (foodList.Count() == 0)
                {
                    foodList.Add(food1);
                }
                else
                {
                    //check duplicates
                    for (int i = 0; i < foodList.Count(); i++)
                    {
                        if (foodList[i].ID == food1.ID)
                        {
                            foodCnt = foodCnt + 1;
                            foodList.Remove(foodList[i]);
                            foodList.Add(new Food()
                            {
                                ID = food1.ID,
                                Category = food1.Category,
                                Name = food1.Name,
                                Quantity = foodCnt,
                                Price = food1.Price
                            });
                            added = true;
                            break;
                        }
                    }
                    if (!added)
                    {
                        foodList.Add(food1);
                    }

                }
            }
            billSum();

            Action a = () => selected.Text = "My Default Text";
            Dispatcher.BeginInvoke(a);
        }

        private void billSum()
        {
            sum = 0.0;
            foreach (Food food in foodList)
            {
                sum += food.TotalPrice;
            }
            sub = sum.ToString("C2", CultureInfo.CurrentCulture);
            tbSubtotal.Text = sub;
            total= (sum * 1.15).ToString("C2", CultureInfo.CurrentCulture);
            tbTotal.Text = total;
        }

        private void BtnClearBill_Click(object sender, RoutedEventArgs e)
        {
            foodList.Clear();
      }

        private void MyBill_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            TextBox tbx = e.EditingElement as TextBox;
            
            DataGridRow row = e.Row;
            int index = row.GetIndex();
            DataGridColumn column = e.Column;
            int col = column.DisplayIndex;
            //draft.Text = "Count: "+ tbx.Text + "\rRow: "+ index + "\rCol: "+col;
            TextBlock x = myBill.Columns[0].GetCellContent(myBill.Items[index]) as TextBlock;
            foodCnt = Int32.Parse(x.Text);
            foreach (Food food in foodList)
            {
                if (food.ID == Int32.Parse(x.Text))
                {
                    foodList.Remove(food);
                    foodList.Add(new Food()
                    {
                        ID = food.ID,
                        Category = food.Category,
                        Name = food.Name,
                        Quantity = Int32.Parse(tbx.Text),
                        Price = food.Price
                    });                   
                    billSum();
                    break;
                }
            }
           
        }

        private void btnLink_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicked");
        }
        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            myBill.SelectAllCells();
            myBill.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, myBill);
            String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            String result = (string)Clipboard.GetData(DataFormats.Text);
            myBill.UnselectAllCells();
            System.IO.StreamWriter file1 = new System.IO.StreamWriter(@"C:\Users\Invoice.xls");
            file1.WriteLine(result.Replace(',', ' '));
            file1.WriteLine("Subtotal" + ' ' + sub);
            file1.WriteLine("Tax" + ' '  + tax);
            file1.WriteLine("Total" + ' ' + total);
            file1.Close();

            MessageBox.Show(" Exported invoice in C\\Users named Invoice.xls ");
        }
    }
}
