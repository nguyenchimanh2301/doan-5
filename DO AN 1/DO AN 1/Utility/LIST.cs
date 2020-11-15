using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DO_AN_1.Utility
{
   public  class Node<T>
    {
        private T data;
       
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        private Node<T> link;
        public Node<T> Link 
        { get{ return link; }
             set {link = value; }
        }
        public Node() { }
        public Node (T t)
        {
            data = t;
            link = null;
        }
    }
    public class list<T>
    {
        private  Node <T> head;
        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }
        public list()
        {
            head = null;
        }
        public void addhead(T n)
        {
            Node<T> tg = new Node<T>(n);
            tg.Link = head;
            head = tg;
        }
        public void addtail(T x)
        {
            Node<T> t = new Node<T>(x);
            if (head == null)
                head = t;
            else
            {
                Node <T> tg = head;
                while (tg.Link!=null)
                {
                    tg = tg.Link;
                }
                tg.Link = t;
            }
        }
        public void hien()
        {
            Console.WriteLine("cac phan tu danh sach");
            Node<T> h = head;
            while (h != null)
            {
                Console.WriteLine(h.Data+"\t");
                h = h.Link;
            }
            Console.WriteLine();
        }
        public void removetail()
        {
            if (head == null)
            {
                Console.WriteLine("danh sach rong");
                return;
            }
            else
            if (head.Link == null)
            {
                head = null;
            }
            else
            {
                Console.WriteLine("danh sach dc xoa di phan tu cuoi");
                Node<T> tg = head;
                Node<T> t = tg;
                while (tg.Link != null)
                {
                    t = tg;
                    tg = tg.Link;
                }
                t.Link = null;
            }
        }
        public void xoaq(Node<T> q)
        {
            Node<T> tg = head;
           
            Node<T> t = tg;
            while (tg.Link != null)
            {
                if (tg == q) break;
                else
                {
                    t = tg;
                    tg = tg.Link;
                }
                if (q == head) head = head.Link;
                else
                    if (q.Link == null)
                    t.Link = null;
                else t.Link = q.Link;
                

            }

        }
           
    }
}
