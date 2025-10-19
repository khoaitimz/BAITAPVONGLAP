using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        /*
        //Bài 1
        //-S1
        Console.WriteLine("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        uint S1 = 0 ;

        for (int i = 1; i <= n; i++)
            S1 += (uint)i;
        Console.WriteLine($"S1 = 1+2+3+..+{n} = {S1}");
        
        //-S2
        Console.WriteLine("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        double S2 = 0;

        for (int i = 1; i <= n; i++)
            S2 += 1/(double)i;
        Console.WriteLine($"S2 = 1 + 1/2 + 1/3 + ... + 1/{n} = {S2}");
        
        //-S3
        Console.WriteLine("Nhập N: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N < 1)  //Đảm bảo chỉ nhập số nguyên dương
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }

        long S3 = 0; // S3 có thể rất lớn, dùng long để tránh tràn số

        Console.Write("S3 = ");
        for (int i = 1; i <= N; i++)
        {
            // Ghép i với chính nó, ví dụ i = 12 => term = 1212
            string termStr = i.ToString() + i.ToString(); // Tạo chuỗi biểu diễn số
            long term = long.Parse(termStr); //Chuyển chuỗi trở lại dạng số nguyên 
            S3 += term;

            Console.Write(term);
            if (i < N) Console.Write(" + ");
        }
        Console.WriteLine($" = {S3}");
        
        //-S4
        Console.WriteLine("Nhập n: ");
        int n = int.Parse(Console.ReadLine());
        long S4 = 1;
        for (int i = 1; i <= n; i++)
        {
            S4 *= i ;
        }
        Console.WriteLine($"S4 = 1*2*3*...*{n} = {S4}");
        
        //-S5
        Console.WriteLine("Nhập n: ");
        if(!int.TryParse(Console.ReadLine(), out int N) || N < 1)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }

        double S5 = 0;
        double giaithua = 1;

        for (int i = 1; i <= N; i++)
        {
            giaithua *= i; // Tính giai thừa i!
            S5 += 1 / giaithua; // Cộng dồn vào S5
        }
        Console.WriteLine($"S5 = 1/1! + 1/2! + 1/3! + ... + 1/{N}! = {S5}");
        
        //-S6
        Console.WriteLine("Nhập n: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N < 1)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        double S6 = 0;

        for (int i = 1; i <= N; i++)
        {
            S6 += 1.0 / (i * (i + 1));
        }
        Console.WriteLine($"S6 = 1/(1*2) + 1/(2*3) + 1/(3*4) + ... + 1/({N}*{N+1}) = {S6}");
        
        //Bài 2
        Console.WriteLine("Nhập a (a>0 và a<1): ");
        if (!double.TryParse(Console.ReadLine(), out double a) || a <= 0 || a >= 1)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        // Tìm N sao cho 1/N < a
        int N = 1;
        while (1.0 / N >= a)
        {
            N++;
        }
        Console.WriteLine($"Giá trị N thỏa mãn điều kiện là: {N}");

        double S2 = 0;
        double S5 = 0;
        double S6 = 0;
        double giaithua = 1;
        if (a >= 0 && a < 1)
        {
            for (int i = 1; i <= N ; i++)
            {
                S2 += 1/ (double)i;
            }
            for (int i = 1; i <= N; i++)
            {
                giaithua *= i; // Tính giai thừa i!
                S5 += 1.0 / giaithua; // Cộng dồn vào S5
            }
            for (int i = 1; i <= N; i++)
            {
                S6 += 1.0 / (i * (i + 1));
            }
            Console.WriteLine($"S2 = 1 + 1/2 + 1/3 + ... + 1/{N} = {S2}");
            Console.WriteLine($"S5 = 1/1! + 1/2! + 1/3! + ... + 1/{N}! = {S5}");
            Console.WriteLine($"S6 = 1/(1*2) + 1/(2*3) + 1/(3*4) + ... + 1/({N}*{N+1}) = {S6}");
        }
      
        //Bài 3
        Console.WriteLine("Nhập số nguyên N: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        for (int i = 2; i <= (int)Math.Sqrt(N); i++)
        {
            if (N % i == 0)
            {
                Console.WriteLine($"{N} không phải số nguyên tố.");
                return;
            }
            else
            {
                Console.WriteLine($"{N} là số nguyên tố.");
                return;
            }
        }
       
        //Bài 4
        Console.WriteLine("Nhập số nguyên N: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        string nhiphan = Convert.ToString(N, 2);
        Console.WriteLine($"Số {N} trong hệ nhị phân là: {nhiphan}");
        
        //Bài 5
        Console.WriteLine("Nhập số nguyên M: ");
        int M = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số nguyên N: ");
        int N = int.Parse(Console.ReadLine());

        if (M <= 0 || N <= 0 || M <= N)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        static long GiaiThua(int n)
        {
            long kq = 1;
            for (int i = 1; i <= n; i++)
                kq *= i;
            return kq;
        }
        long C = GiaiThua(M) / (GiaiThua(N) * GiaiThua(M - N));
        Console.WriteLine($"Tổ hợp C({M},{N}) = {C}");
        long A = GiaiThua(M) / GiaiThua(M - N);
        Console.WriteLine($"Chỉnh hợp A({M},{N}) = {A}");
        
        //Bài 6
        Console.WriteLine("Nhập bậc n của đa thức: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        double F = 0;
        double[] a = new double[n + 1];
        for (int i = n; i >= 0; i--)
        {
            Console.Write($"Nhập hệ số a[{i}]: ");
            a[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Nhập giá trị x: ");
        double x = double.Parse(Console.ReadLine());
        for (int i = n; i >= 0; i--)
        {
            F = F * x + a[i];
        }
        Console.WriteLine($"Giá trị của đa thức tại x = {x} là: F({x}) = {F}");
        
        //Bài 7
        Console.WriteLine("Nhập số nguyên dương N: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        int dem = 0;
        int so = 2;
        Console.WriteLine($"{N} số nguyên tố đầu tiên là: ");
        while (dem < N)
        {
            bool isPrime = true;
            for (int i = 2; i <= (int)Math.Sqrt(so); i++)
            {
                if (so % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.Write(so + " ");
                dem++;
            }
            so++;
        }
       
        //Bài 8
        Console.WriteLine("Nhập chuỗi ký tự: ");
        string input = Console.ReadLine();
        int width = Console.WindowWidth;

        for (int pos = width; pos > -input.Length; pos--)
        {
            Console.Clear();
            Console.Write(new string (' ',Math.Max(0,pos))+input);
            System.Threading.Thread.Sleep(100);
        }
        
        //Bài 9
        Console.WriteLine("Nhập chuỗi ký tự: ");
        string input = Console.ReadLine();

        int height = Console.WindowHeight;
        for (int pos = 0; pos < height - 1; pos++)
        {
            Console.Clear();
            for (int i = 0; i < pos; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine(input);
            System.Threading.Thread.Sleep(200);
        }
        
        //Bài 11
        Console.Write("Nhập chiều rộng: ");
        if (!int.TryParse(Console.ReadLine(), out int width) || width <= 0)
        {
            Console.WriteLine("Chiều rộng không hợp lệ. Phải là số nguyên dương.");
            return;
        }

        Console.Write("Nhập chiều cao: ");
        if (!int.TryParse(Console.ReadLine(), out int height) || height <= 0)
        {
            Console.WriteLine("Chiều cao không hợp lệ. Phải là số nguyên dương.");
            return;
        }

        for (int r = 0; r < height; r++)
        {
            for (int c = 0; c < width; c++)
            {
                // In dấu '*' ở viền, bên trong là khoảng trắng
                if (r == 0 || r == height - 1 || c == 0 || c == width - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
        */
        //Bài 13
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        double a, b;
        int n;
        bool tiepTuc = true;

        while (tiepTuc)
        {
            Console.WriteLine("\n====== MÁY TÍNH BỎ TÚI NÂNG CAO ======");
            Console.WriteLine("1. Cộng (+)");
            Console.WriteLine("2. Trừ (-)");
            Console.WriteLine("3. Nhân (*)");
            Console.WriteLine("4. Chia (/)");
            Console.WriteLine("5. Lũy thừa (x^y)");
            Console.WriteLine("6. Căn bậc chẵn bất kỳ (√[n](x))");
            Console.WriteLine("7. Tính Sigma N (1 + 2 + ... + N)");
            Console.WriteLine("8. Tính giai thừa N!");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
            int chon = int.Parse(Console.ReadLine());

            switch (chon)
            {
                case 1:
                    Console.Write("Nhập a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Nhập b: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Kết quả: {a} + {b} = {a + b}");
                    break;

                case 2:
                    Console.Write("Nhập a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Nhập b: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Kết quả: {a} - {b} = {a - b}");
                    break;

                case 3:
                    Console.Write("Nhập a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Nhập b: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Kết quả: {a} * {b} = {a * b}");
                    break;

                case 4:
                    Console.Write("Nhập a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Nhập b: ");
                    b = double.Parse(Console.ReadLine());
                    if (b == 0)
                        Console.WriteLine("Không thể chia cho 0!");
                    else
                        Console.WriteLine($"Kết quả: {a} / {b} = {a / b}");
                    break;

                case 5:
                    Console.Write("Nhập cơ số x: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Nhập số mũ y: ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Kết quả: {a}^{b} = {Math.Pow(a, b)}");
                    break;

                case 6:
                    Console.Write("Nhập số cần lấy căn x: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Nhập bậc căn (chẵn) n: ");
                    n = int.Parse(Console.ReadLine());

                    if (n % 2 != 0)
                        Console.WriteLine("Chỉ hỗ trợ căn bậc CHẴN!");
                    else if (a < 0)
                        Console.WriteLine("Không thể lấy căn chẵn của số âm!");
                    else
                        Console.WriteLine($"Kết quả: căn bậc {n} của {a} = {Math.Pow(a, 1.0 / n)}");
                    break;

                case 7:
                    Console.Write("Nhập N: ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 1)
                        Console.WriteLine("N phải ≥ 1!");
                    else
                    {
                        long tong = (long)n * (n + 1) / 2;
                        Console.WriteLine($"Σ(1 + 2 + ... + {n}) = {tong}");
                    }
                    break;

                case 8:
                    Console.Write("Nhập N: ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 0)
                        Console.WriteLine("Không tồn tại giai thừa cho số âm!");
                    else
                    {
                        long kq = 1;
                        for (int i = 1; i <= n; i++)
                            kq *= i;
                        Console.WriteLine($"{n}! = {kq}");
                    }
                    break;

                case 0:
                    tiepTuc = false;
                    Console.WriteLine("Tạm biệt!");
                    break;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }

        /*
        //Bài 14
        Console.WriteLine("Nhập họ tên đầy đủ: ");
        string ten = Console.ReadLine();

        if (ten == null) return;
        ten = ten.Trim();
        string[] parts = ten.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length < 2)
        {
            Console.WriteLine("Vui lòng nhập đầy đủ họ và tên.");
            return;
        }
        string ho = string.Join(" ", parts, 0, parts.Length - 1);
        string tenCuoi = parts[parts.Length - 1];
        Console.WriteLine($"Họ: {ho}");
        Console.WriteLine($"Tên: {tenCuoi}");
        
        //Bài 15
        Console.WriteLine("Nhập nhiệt độ C: ");
        if (!double.TryParse(Console.ReadLine(), out double celsius))
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        double fahrenheit = (celsius * 9 / 5) + 32;
        for (int i = 0; i <= 20; i++)
        {
            Console.WriteLine($"{celsius + i}°C = {fahrenheit + i * 9 / 5}°F");
        }
       
        //Bài 16
        Console.WriteLine("Nhập số nguyên dương N: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        if (N==0 || N==1)
        {
            Console.WriteLine($"{N} không phải số Fibonacci.");
            return;
        }
        long prev = 1;
        long curr = 1;

        for (int i = 3; i <= N; i++)
        {
            long next = prev + curr;
            prev = curr;
            curr = next;
        }
        Console.WriteLine($"Số Fibonacci thứ {N} là: {curr}");
        
        //Bài 17
        Console.WriteLine("Nhập số nguyên dương N: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        long a0 = 1;
        long a1 = 1;

        if (N == 1 || N == 2)
        {
            Console.WriteLine($"Số thứ {N} trong dãy là: 1");
            return;
        }
        Console.Write(a0 + " " + a1);
        for (int i = 2; i < N; i++)
        {
            long next = a0 + a1; // a_i = a_{i-2} + a_{i-1}
            Console.Write(" " + next);
            a0 = a1;
            a1 = next;
        }
        Console.WriteLine();
        
        //Bài 18
        Console.WriteLine("Nhập tiền gửi ban đầu: ");
        double s = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập lãi suất hàng tháng (%): ");
        double r = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số tháng gửi: ");
        double t = int.Parse(Console.ReadLine());

        double total = s * Math.Pow((1.0 + r/100), t);
        Console.WriteLine($"Tổng số tiền sau {t} tháng là: {total}");
        
        //Bài 19
        Console.WriteLine("Nhập số nguyên dương M: ");
        int M = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số nguyên dương N: ");
        int N = int.Parse(Console.ReadLine());
        if (M <= 0 || N <= 0)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        while (N != 0)
        {
            int r = M % N;
            M = N;
            N = r;
        }
        int UCLN = M;
        Console.WriteLine($"Ước chung lớn nhất của {M} & {N} là: {UCLN}");
        int BCNN = (M * N) / UCLN;
        Console.WriteLine($"Bội chung nhỏ nhất của {M} & {N} là: {BCNN}");
        
        //Bài 20
        Random random = new Random();
        int num = random.Next(0, 100);
        int guess;
        int attempts = 0;
        Console.WriteLine("Đã chọn một số ngẫu nhiên từ 0 đến 99. Hãy đoán số đó!");
        Console.WriteLine("Bạn có 6 lượt đoán.");
        
        do
        {
            Console.WriteLine("Nhập dự đoán của bạn: ");
            int.TryParse(Console.ReadLine(), out guess);
            attempts++;
            if (guess < num)
                Console.WriteLine("Số bạn đoán nhỏ hơn số cần tìm.");
            else if (guess > num)
                Console.WriteLine("Số bạn đoán lớn hơn số cần tìm.");
            else
                Console.WriteLine($"Chúc mừng! Bạn đã đoán đúng số {num} trong {attempts} lượt.");
        } while (guess != num && attempts < 6);
        if (guess != num)
            Console.WriteLine("Rất tiếc bạn đã hết lượt đoán. Số đúng là: " + num);
        
        //Bài 21
        Console.WriteLine("Nhập chiều cao N của tam giác Pascal: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N - i - 1; j++)
            {
                Console.Write(" ");
            }
            int num = 1;
            for (int k = 0; k <= i; k++)
            {
                Console.Write(num + " ");
                num = num * (i - k) / (k + 1);
            }
            Console.WriteLine();
        }
        
        //Bài 23
        Console.WriteLine("Nhập số nguyên dương N: ");
        string input = Console.ReadLine()?.Trim();
        if (!int.TryParse(input, out int N) || N <= 0)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        if (!BigInteger.TryParse(input, out BigInteger n))
        {
            Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập một số nguyên.");
            return;
        }
        int count = n.ToString().Length;
        string digits = n.ToString();
        BigInteger sum = 0;
        foreach (char digit in digits)
        {
            sum += BigInteger.Parse(digit.ToString());
        }
        Console.WriteLine($"Số ký số của {N} là: {count}");
        Console.WriteLine($"Tổng các ký số của {N} là: {sum}");
        
        //Bài 24
        Console.WriteLine("Nhập số nguyên dương N: ");
        int N = int.Parse(Console.ReadLine());

        int original = N;
        int reversed = 0;
        while (N > 0)
        {
            int digit = N % 10;
            reversed = reversed * 10 + digit;
            N /= 10;
        }
        if (reversed == original)
            Console.WriteLine("Số đã nhập là số đối xứng.");
        else
            Console.WriteLine("Số đã nhập không phải là số đối xứng.");
        
        //Bài 25
        Console.WriteLine("Nhập số nguyên dương N: ");
        long N = long.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số nguyên dương M: ");
        int M = int.Parse(Console.ReadLine());

        long tong = 0;
        for ( int i = 0; i < M; i++)
        {
            if (N == 0)
                break;
            tong += N % 10;
            N /= 10;
        }
        Console.WriteLine($"Tổng {M} chữ số cuối cùng của số đã nhập là: {tong}");
        
        //Bài 26
        Console.WriteLine("Nhập số tiền muốn đổi: ");
        if (!int.TryParse(Console.ReadLine(), out int S) || S <= 0)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        int[] denominations = { 1, 5, 10, 20, 50 };
        int count = 0;
        for (int c50 = 0; c50 <= S / 50; c50++)
        {
            for (int c20 = 0; c20 <= (S - c50 * 50) / 20; c20++)
            {
                for (int c10 = 0; c10 <= (S - c50 * 50 - c20 * 20) / 10; c10++)
                {
                    for (int c5 = 0; c5 <= (S - c50 * 50 - c20 * 20 - c10 * 10) / 5; c5++)
                    {
                        int c1 = S - (c50 * 50 + c20 * 20 + c10 * 10 + c5 * 5);
                        if (c1 >= 0)
                        {
                            count++;
                        }
                    }
                }
            }
        }
        Console.WriteLine($"Tổng số cách đổi tiền: {count}");
        
        //Bài 27
        Console.WriteLine("Nhập số nguyên dương N: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
        {
            Console.WriteLine("Giá trị nhập không hợp lệ!");
            return;
        }
        int original = N;
        int reversed = 0;
        while (N > 0)
        {
            int digit = N % 10;
            reversed = reversed * 10 + digit;
            N /= 10;
        }
        Console.WriteLine($"Số đảo ngược của {original} là: {reversed}");
        */
    }
}
