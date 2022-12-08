# Gudang.in

Ubah bagian
SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\! Materi Kuliah\Semester 3\PBO\exp3\InventoryManagementSystem\InventoryManagementSystem\Tutorial Database\dbIMS.mdf;Integrated Security=True;Connect Timeout=30");
menjadi 
SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=(File Directory)\dbIMS.mdf;Integrated Security=True;Connect Timeout=30");
