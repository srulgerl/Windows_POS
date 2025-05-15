using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace posLibrary
{
    public class DataBaseConnection
    {
        public void CreateDatabase()
        {
            string dbPath = Path.Combine(Directory.GetCurrentDirectory(), "pos.db");

            if (!File.Exists(dbPath))
            {

                SQLiteConnection.CreateFile(dbPath);

                using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
                {
                    conn.Open();

                    string sql = @"
                CREATE TABLE IF NOT EXISTS users (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    username TEXT NOT NULL UNIQUE,
                    password TEXT NOT NULL,
                    role TEXT NOT NULL
                );

                INSERT INTO users (username, password, role) VALUES 
                    ('Manager', '1234', 'Manager'),
                    ('Cashier1', 'pass1', 'Cashier'),
                    ('Cashier2', 'pass2', 'Cashier');

                CREATE TABLE IF NOT EXISTS products (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL,
                    price DECIMAL NOT NULL,
                    quantity INTEGER NOT NULL,
                    category_id INTEGER,
                    discount INT DEFAULT 0,
                    barcode INTEGER UNIQUE,
                    FOREIGN KEY (category_id) REFERENCES categories(id)
                );
                INSERT INTO products (name, price, quantity, category_id, discount, barcode) VALUES 
                    ('Cola', 1.50, 43, 1, 5, 1234567),        
                    ('Chips', 2.00, 21, 2, 10, 2345678),      
                    ('Smartphone', 499.99, 46, 3, 15, 3456789), 
                    ('T-Shirt', 19.99, 93, 4, 0, 4567890),    
                    ('Detergent', 5.99, 12, 5, 20, 5678901),   
                    ('Water Bottle', 1.00, 64, 1, 0, 6789012),
                    ('Candy Bar', 0.99, 34, 2, 5, 7890123),   
                    ('Headphones', 29.99, 21, 3, 10, 8901234), 
                    ('Jeans', 39.99, 2, 4, 25, 9012345),     
                    ('Light Bulb', 3.49, 14, 5, 0, 1237890); 

                CREATE TABLE IF NOT EXISTS categories (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL
                );  
                INSERT INTO categories (name) VALUES 
                    ('Beverages'),
                    ('Snacks'),
                    ('Electronics'),
                    ('Clothing'),
                    ('Household');

                CREATE TABLE IF NOT EXISTS transactions (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    user_id INTEGER,
                    total_price REAL,
                    FOREIGN KEY (user_id) REFERENCES users(id)
                );

                CREATE TABLE IF NOT EXISTS transaction_items (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    transaction_id INTEGER,
                    product_id INTEGER,
                    quantity INTEGER,
                    FOREIGN KEY (transaction_id) REFERENCES transactions(id),
                    FOREIGN KEY (product_id) REFERENCES products(id)
                );
            ";
                    try
                    {
                        using (var cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (SQLiteException ex)
                    {
                        Console.WriteLine("Error creating tables: " + ex.Message);
                    }
                }
            }
        }
    }
}
