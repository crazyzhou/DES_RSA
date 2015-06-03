using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

namespace DES_12307130088
{
    public class RSA
    {
        public BigInteger n, e, d;
        BigInteger p, q;

        //BigintToBinstr函数功能： 将BigInteger类型数x转成长度为len的二进制字符串
        string BigintToBinstr(BigInteger x, byte len)
        {
            char[] s = new char[len];
            for (int i = len - 1; i >= 0; i--) 
            {
                s[i] = (x & 1) == 1 ? '1' : '0';
                x /= 2;
            }
            return new string(s);
        }

        //BinstrToBigint函数功能： 将二进制字符串s转成BigInteger类型数
        BigInteger BinstrToBigint(string s)
        {
            BigInteger x=0;
            int len = s.Length;
            for (int i = 0; i < len; i++) 
            {
                x = x * 2 + (s[i]-'0');
            }
            return x;
        }

        // RandomK函数功能：生成位数（二进制下）为K的二进制随机数
        BigInteger RandomK(int digit)
        {
            int i;
            BigInteger num = 1;
            Random rnd = new Random();
            for (i = 0; i < digit - 1; i++)
            {
                num = num * 2 + rnd.Next(2);
            }
            return num;
        }

        // RandomLessThanN 函数功能：生成小于n的随机数
        BigInteger RandomLessThanN(BigInteger num)
        {
            int i;
            int digit = (int)BigInteger.Log(num, 2) + 1;
            BigInteger t;
            Random rnd = new Random();
            do
            {
                t = 0;
                for (i = 0; i < digit; i++)
                {
                    t = t * 2 + rnd.Next(2);
                }
            }
            while (t >= num);
            return t;
        }

        //Extended_Euclid函数功能：运用扩展欧几里得算法计算使得ax+by=1的x的解
        //本程序中主要用以计算在模euler_n意义下的e的逆：d，即寻找d和y，使得e*d+euler_n*y=1
        void Extended_Euclid(BigInteger a, BigInteger b, ref BigInteger x, ref BigInteger y)
        {
            BigInteger temp;
            if (b==0)
            {
                x=1;
                y=0;
                q=a;
                return;
            }
            Extended_Euclid(b, a % b, ref x, ref y);
            temp=x;
            x=y;
            y=temp-a/b*y;
        }

        //Miller_Rabin素数检验算法
        bool Miller_Rabin(BigInteger num)
        {
            BigInteger m = num - 1;
            int digit = (int)BigInteger.Log(num, 2) + 1;
            int i, k = 0;
            while (m.IsEven)
            {
                m /=2;
                k++;
            }
            BigInteger a = RandomLessThanN(num);
            BigInteger b = BigInteger.ModPow(a, m, num);
            if (BigInteger.Remainder(b, num) == 1)
            {
                return true;
            }
            for (i = 0; i <= k - 1; i++)
            {
                if (BigInteger.Remainder(b, num) == num - 1) 
                {
                    return true;
                }
                b = BigInteger.ModPow(b, 2, num);
            }
            return false;
        }

        //利用Miller_Rabin检验算法生成位数（二进制下）为digit的大素数
        BigInteger GetPrime(int digit)
        {
            int i=0;
            BigInteger prime=0;
            do
            {
                prime = RandomK(digit) | 1;
            }
            while (BigInteger.GreatestCommonDivisor(prime - 1, e) != 1);    //生成正奇数prime，直至e无法整除prime-1
            for (i = 0; i < 20; i++)    //至少通过20次Miller_Rabin素数检验，prime的素数概率上升至1-2^-40
            {
                if (!Miller_Rabin(prime))
                {
                    prime = RandomK(digit) | 1;
                    i = 0;
                }
            }
            return prime;
        }

        //生成公钥、私钥
        public void GenerateKey()
        {
            BigInteger y=0;
            e = 65537;  //e设为65537
            p = GetPrime(63);   //p为63位大素数
            q = GetPrime(65);   //q为65位大素数
            //选取63、65主要为了防止p、q过于接近而易受攻击
            n = BigInteger.Multiply(p, q);  //n=p*q
            BigInteger Euler_n = BigInteger.Multiply(p - 1, q - 1); //欧拉函数 φ(n) = (p-1)(q-1)
            Extended_Euclid(e, Euler_n, ref d, ref y);  //运用扩展欧几里得算法求得模euler_n下e的逆：d
            while (d<0)
            {
                d += Euler_n;   //若d为负数，则转为正数
            }
        }

        //RSA_Encrypt函数功能：利用对方的公钥e1,n1，将明文二进制字符串k，RSA加密为长度为len的二进制字符串
        public string RSA_Encrypt(string k, byte len, BigInteger e1, BigInteger n1)
        {
            BigInteger knum = BinstrToBigint(k);
            BigInteger x = BigInteger.ModPow(knum, e1, n1); //x = knum^e1 mod n1
            return BigintToBinstr(x, len);
        }

        //RSA_Decrypt函数功能：利用本地公钥e,n和私钥d，将密文二进制字符串k，RSA解密为长度为len的二进制字符串
        public string RSA_Decrypt(string k, byte len)
        {
            BigInteger knum = BinstrToBigint(k);
            BigInteger x = BigInteger.ModPow(knum, d, n);   //x = knum^d mod n
            return BigintToBinstr(x, len);
        }
    }
}