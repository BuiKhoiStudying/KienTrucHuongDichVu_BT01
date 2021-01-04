using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNo1
{
    public class QLSV
    {
        private SV[] arr;

        private int n;

        public QLSV() {
            arr = null;
            n = 0;
        }

        //add vao cuoi mang
        public void Add(SV s) {
            this.Insert(s, n);
        }

        //insert
        public void Insert(SV s, int k) {
            SV[] newarr = new SV[n+1];
            int idx = 0;
            for (; idx<k; idx++) {
                newarr[idx] = this.arr[idx];
            }
            newarr[idx] = s;
            idx += 1;
            for (; idx<n+1; idx++) {
                newarr[idx] = this.arr[idx-1];
            }
            this.arr = newarr;
            this.n += 1;
        }

        //check address
        public int IndexOf(SV s) {
            for (int i=0; i<this.arr.Length; i++) {
                SV temp = this.arr[i];
                if (temp == s) {
                    return i;
                }
            }

            return -1;
        }

        //Delete sv in K
        public void RemoveAt(int k) {
            SV[] newarr = new SV[n-1];
            int idx = 0;
            for (; idx<k; idx++) {
                newarr[idx] = this.arr[idx];
            }
            for (; idx<n-1; idx++) {
                newarr[idx] = this.arr[idx+1];
            }
            this.arr = newarr;
            this.n -= 1;
        }

        //Find and delete
        public void Remove(SV s){
            int idx = this.IndexOf(s);
            this.RemoveAt(idx);
        }

        public int GetLength(){
            return this.arr.Length;
        }

        public override string ToString() {
            //goi ham ToString cua tung doi tuong sv
            foreach (SV s in this.arr)
            {
                Console.WriteLine(s.ToString());
            }
            return "";
        }

        //check theo mssv, update phan tu tim thay theo s
        public void Update(SV s) {
            for (int i=0; i<this.n; i++) {
                SV temp = this.arr[i];
                if (temp.MSSV == s.MSSV) {
                    temp.NameSV = s.NameSV;
                    temp.Age = s.Age;

                    this.arr[i] = temp;
                }
            }
        }
    }
}