using System;
using System.Collections.Generic;
using System.Com;
using System.Con;
using System.Dat;
using System.Dra;
using System.Lin;
using System.Sec.Cry;
using System.Tex;
using System.Thr.Tas;
using System.Win.For;
using Sal.uti;
using static System.Net.Mim.Med;
using static System.Win.For.Vis.Vis2;
using static System.Win.For.Vis.Vis2.Win2;
using DB = DBO;

namespace Sal
{
    public par class For2 : For3
    {
        
        
        
        private string sal;
        
        
        
        private DataTable dtT;
        
        
        
        private DataTable dtC;
        
        
        
        private int mod;
        
        
        
        private DB.DBO ope;        
        
        
        
        private int tax;
        
        
        
        public bool Pro { get; private set; } = false;

        
        
        
        public For2(string sal, int mod, DB.DBO ope)
        {
            Ini();
            
            this.sal = sal;
            this.mod = mod;
            this.ope = ope;
        }

        
        
        
        
        
        private void For4(object sender, EventArgs e)
        {
            try
            {
                
                Con2();
                
                Get();
                
                Pro2();
            }
            catch (Exception ex)
            {
                Mes.Sho("データ。"
                    + Env.New + ex.Mes2
                    + Env.New + ex.Sta);
                this.Close();
            }
        }

        
        
        
        
        
        private void but(object sender, EventArgs e)
        {
            Row();
        }

        
        
        
        
        
        private void but2(object sender, EventArgs e)
        {
            Row2();
        }

        
        
        
        
        
        private void dat(object sender, EventArgs e)
        {
            DataGridView dat2 = (DataGridView)sender;

            
            dat2.Com2(Dat2.Commit);            
        }

        
        
        
        
        
        private void dat3(object sender, Dat3 e)
        {
            
            if (dat2.Rows.Count <= 0) 
            {
               return;
            }

            try
            {
                
                if (!(e.Col == Ite.Ind || e.Col == Qua.Ind))
                {
                    return;
                }
                
                else if (e.Col == Ite.Ind)
                {
                    
                    
                    Amo(dat2[e.Col, e.Row3].Value);
                }
                
                else if (e.Col == Qua.Ind)
                {
                    
                    Amo2();
                }
                
                if (int.Parse(dat2[Sta2.Ind, dat2.Cur.Row3]
                    .Value.ToString()) == STA.EXI)
                {
                    
                    dat2[Sta2.Ind, dat2.Cur.Row3].Value = STA.EDI;
                }
            }
            catch (Exception ex)
            {
                Mes.Sho("データ。"
                    + Env.New + ex.Mes2
                    + Env.New + ex.Sta);
                this.Close();
            }
        }

        
        
        
        
        
        private void but3(object sender, EventArgs e)
        {
            try
            {
                switch (mod)
                {
                    case MOD.REG:
                        if (Bef())
                        {                            
                            if (Mes.Sho("登録し？ はい/いいえ", "", Mes3.Yes2) == Dia.Yes2)
                                Reg();
                        }
                        break;

                    case MOD.EDI:
                        if (Bef())
                        {
                            if (Mes.Sho("更新し？ はい/いいえ", "", Mes3.Yes2) == Dia.Yes2)
                                Edi();
                        }
                        break;

                    case MOD.DEL:
                        if (Mes.Sho("削除し？ はい/いいえ", "", Mes3.Yes2) == Dia.Yes2)
                            Del();                                                
                        break;
                }
            }
            catch (Exception ex)
            {
                Mes.Sho("データ。"
                    + Env.New + ex.Mes2
                    + Env.New + ex.Sta);
                this.Close();
            }
        }

        
        
        
        
        
        private void but4(object sender, EventArgs e)
        {
            Dia dialog = Mes.Sho("前画面？ はい/いいえ", "", Mes3.Yes2);

            
            if (dialog == Dia.No)
            {
                return; 
            }
            
            else
            {
                this.Close();
            }            
        }

        
        
        
        
        
        private void dat4(object sender, Dat4 e)
        {
            
            if (e.Con3 is Dat5) 
            {
                
                Dat5 tb = (Dat5)e.Con3;

                
                tb.Key += new Key2(dat5);
            }
        }

        
        private void dat5(object sender,Key3 e)
        {
            
            if ((e.Key4 < '0' || e.Key4 > '9') && e.Key4 != '\b')
            {
                e.Han = true;
            }
        }

        
        
        
        
        
        private void For5(object sender, Key5 e)
        {
            
            switch (e.Key6)
            {
                case Keys.F1:
                    but5.Per();
                    break;                
                case Keys.F12:
                    but6.Per();
                    break;
            }
        }

        
        
        
        
        
        private void lab(object sender, EventArgs e)
        {
            
            if (lab2.Tex == LAB.EMP)
            {
                return;
            }
            
            if (int.TryParse(lab2.Tex, out int tax2)) 
            {
                lab2.Tex = string.For6("{0:#,0}", tax2);
            }
        }

        
        
        
        
        
        private void lab3(object sender, EventArgs e)
        {
            
            if (lab4.Tex == LAB.EMP)
            {
                return;
            }
            if (int.TryParse(lab4.Tex, out int Sal2))
            {
                lab4.Tex = string.For6("{0:#,0}", Sal2);
            }
        }

        
        
        
        
        
        private void lab5(object sender, EventArgs e)
        {
            
            if (lab6.Tex == LAB.EMP)
            {
                return;
            }            
            if (int.TryParse(lab6.Tex, out int tax3))
            {
                lab6.Tex = string.For6("{0:#,0}", tax3);
            }
        }

        
        
        
        
        
        private void dat6(object sender, EventArgs e)
        {            
            
            if (dat2.Rows.Count <= 0)
            {
                return;
            }
            
            Tax();

            
            int tax4 = Tot();
            
            Foo(tax4);
        }

        
        
        
        private void Con2()
        {
            try
            {
                
                Hea();
                
                Foo2();
                
                Dat6();
                
                Com3();
            }
            catch
            {
                throw;
            }
        }

        
        
        
        private void Hea()
        {
            lab7.Res();
            dat7.Value = DateTime.Now;
            if (com.Sel != null) com.Sel2 = COM.BLA;
            if (com2.Sel != null) com2.Sel2 = COM.BLA;
            tex.Clear();
        }

        
        
        
        private void Foo2()
        {            
            lab2.Tex = string.Emp;
            lab4.Tex = string.Emp;
            lab6.Tex = string.Emp;            
        }

        
        
        
        private void Dat6()
        {
            
            dat2.Rows.Clear();
            
            dat2.Aut = false;
            
            dat2.Row4 = false;
            
            dat2.Sel3 = Dat7.Cel;
            
            dat2.Mul = false;
            
            dat2.All = false;
            dat2.All2 = true;
            
            dat2.All3 = false;
            
            foreach (Dat8 col in dat2.Columns)
            {
                col.Rea = true;
            }
            dat2.Columns[Ite.Ind].Rea = false;
            dat2.Columns[Qua.Ind].Rea = false;
            
            dat2.Columns[Uni.Ind].Def.For6 = "#,##0";
            dat2.Columns[Qua.Ind].Def.For6 = "#,##0";
            dat2.Columns[Tax2.Ind].Def.For6 = "#,##0";            
            
            dat2.Edi2 = Dat9.Edi3;
        }

        
        
        
        private void Com3()
        {
            try
            {
                
                com2.Dro = Com4.Dro2;
                com.Dro = Com4.Dro2;

                
                string cus = Que.Cre();
                string tan = Que.Cre2();
                string col2 = Que.Cre3();

                
                ope.Con4();
                DataTable dtC2 = ope.Exe(cus);
                DataTable dtT2 = ope.Exe(tan);
                dtC = ope.Exe(col2);

                
                Uti.Con5(dtC2, com2);
                Uti.Con6(dtT2, com);
                Uti.Col2(dtC,
                    (Dat10)dat2.Columns[Ite.Ind]);
            }
            catch
            {
                throw;
            }
            finally
            {
                ope.Close();
            }
        }

        
        
        
        private void Get()
        {
            try
            {                
                
                string tax5 = Que.Cre4();

                
                ope.Con4();
                dtT = ope.Exe(tax5);
            }
            catch
            {
                throw;
            }
            finally
            {
                ope.Close();
            }
        }

        
        
        
        private void Pro2()
        {
            try
            {
                switch (mod)
                {
                    
                    
                    case MOD.REG:
                        New2();
                        but6.Tex = BUT.REG2;
                        break;

                    
                    
                    case MOD.EDI:
                        lab7.Tex = sal;
                        Sal3();
                        Sal4();
                        but6.Tex = BUT.EDI2;
                        break;

                    
                    
                    
                    case MOD.DEL:
                        lab7.Tex = sal;
                        Sal3();
                        Sal4();
                        Rea2();                       
                        but6.Tex = BUT.DEL2;
                        break;
                }
            }
            catch
            {
                throw;
            }
        }
        
        
        
        
        private void New2()
        {
            try
            {
                
                
                string sql = Que.Cre5();

                
                ope.Con4();
                DataTable dt = ope.Exe(sql);
                DataRow row = dt.Rows[0];  
                
                
                
                lab7.Tex = (int.Parse(row[DAT.MAX].ToString()) + 1).ToString();

                
                Tax();
            }
            catch
            {
                throw;
            }
            finally
            {
                ope.Close();
            }
        }

        
        
        
        private void Sal3()
        {
            try
            {
                
                
                string sql = Que.Cre6(sal);

                
                ope.Con4();
                DataTable dt = ope.Exe(sql);

                
                DataRow row = dt.Rows[0];
                
                dat7.Value = (DateTime)row[DAT.SAL];
                com.Sel = row[DAT.TAN];
                com2.Sel = row[DAT.CUS];
                tex.Tex = row[DAT.TIT].ToString();
                tex2.Tex = row[DAT.MEM].ToString();
                tax = int.Parse(row[DAT.TAX2].ToString());
                lab2.Tex = row[DAT.TOT].ToString();
                int tax4 = (int)row[DAT.TOT];                
                
                
                Foo(tax4);
            }
            catch
            {
                throw;
            }
            finally 
            {
                ope.Close();
            }
        }

        
        
        
        
        private void Foo(int tax4)
        { 
            
            lab4.Tex = Math.Tru
                        ((double)tax4 * tax / TAX2.FOR).ToString();

            
            int sal2 = int.Parse(lab4.Tex.Rep(LAB.COM2, LAB.EMP));

            
            lab6.Tex = (tax4 + sal2).ToString();
        }

        
        
        
        private void Sal4()
        {
            try
            {
                
                string sql = Que.Cre7(sal);

                
                ope.Con4();
                DataTable dt = ope.Exe(sql);

                
                foreach (DataRow row in dt.Rows)
                {
                    
                    object[] row2 = row.Ite2;
                    
                    dat2.Rows.Add(row2);
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                ope.Close();
            }
        }

        
        
        
        private void Rea2()
        {
            lab7.Ena = false;
            tex.Rea = true;
            tex2.Rea = true;
            dat2.Rea = true;
            lab2.Ena = false;
            lab4.Ena = false;
            lab6.Ena = false;

            
            dat7.Ena = false;
            com.Ena = false;
            com2.Ena = false;
            tex.Ena = false;
            but7.Ena = false;
            but8.Ena = false;
            dat2.Ena = false;
        }

        
        
        
        private void Row()
        {
            int max =0;
            
            if (dat2.Row5 > 0)
            {
                
                List<int> lis = new List<int>();

                foreach (Dat11 row in dat2.Rows)
                {
                    lis.Add(int.Parse(row.Cel2[Det.Ind].Value.ToString()));
                }
                max = lis.Max();
            }

            
            dat2.Rows.Add();

            
            
            dat2[Sta2.Ind, dat2.Row5 - 1].Value = STA.ADD;

            
            dat2[Det.Ind, dat2.Row5 - 1].Value = max + 1;
        }

        
        
        
        private void Row2()
        {
            
            if (dat2.Row5 <= 0 || dat2.Cur == null)
            {
                return;
            }            

            
            int sta = 0;
            Dat11 del = null;

            sta = int.Parse(
                dat2[Sta2.Ind, dat2.Cur.Row3].Value.ToString());
            del = dat2.Rows[dat2.Cur.Row3];

            
            switch (sta)
            {
                
                case STA.ADD:

                    dat2.Rows.Remove(del);
                    break;

                
                case STA.EXI:
                case STA.EDI:

                    
                    int cur = dat2.Cur.Col;
                    int cur2 = dat2.Cur.Row3;

                    
                    dat2[Sta2.Ind, dat2.Cur.Row3].Value = STA.DEL3;
                    del.Vis3 = false;

                    
                    Sel4(cur, cur2);

                    
                    int tax4 = Tot();

                    
                    Foo(tax4);

                    break;
            }
        }

        
        
        
        
        
        private void Sel4(int cur,int cur2) 
        {
            
            int cou = 0;
            foreach (Dat11 row in dat2.Rows)
            {
                if (row.Vis3)
                {
                    cou += 1;
                }
            }

            
            if (cou >= 1)
            {
                
                
                bool las = false;
                for (int i = 0; i < dat2.Rows.Count - cur2; i++)
                {
                    if (dat2[cur, cur2 + i].Vis3)
                    {
                        las = true; 
                        break;
                    }
                }

                
                if (las)
                {
                    
                    for (int i = 0; i < dat2.Rows.Count; i++)
                    {
                        
                        if (dat2[cur, cur2 + i].Vis3)
                        {
                            dat2[cur, cur2 + i].Sel5 = true;
                            break;
                        }
                    }
                }

                
                if (!las)
                {
                    
                    
                    for (int i = 0; i < dat2.Rows.Count; i++)
                    {
                        
                        if (dat2[cur, cur2 - i].Vis3)
                        {
                            dat2[cur, cur2 - i].Sel5 = true;
                            break;
                        }
                    }
                }
            }
        }

        
        
        
        
        private void Amo(object ite)
        {
            try
            {
                
                if (ite == null)
                {
                    
                    dat2[Uni2.Ind, dat2.Cur.Row3].Value = null;
                    dat2[Uni.Ind, dat2.Cur.Row3].Value = null;
                    dat2[Tax2.Ind, dat2.Cur.Row3].Value = 0;
                    Tot();
                }

                
                else
                {
                    
                    dtC.Def2.Row6 = 
                        $"[{COM.ITE}] = '{ite}'"; 
                    
                    
                    Dat12 drv = dtC.Def2[0];

                    
                    dat2.Cel3 -= dat3;

                    
                    dat2[Uni2.Ind, dat2.Cur.Row3].Value =
                        drv[COM.UNI].ToString();
                    dat2[Uni.Ind, dat2.Cur.Row3].Value =
                        drv[COM.SAL2].ToString();

                    
                    if (dat2[Qua.Ind, dat2.Cur.Row3].Value != null)
                    {
                        Tot2();
                    }
                    
                    else
                    {
                        
                        dat2[Tax2.Ind, dat2.Cur.Row3].Value =
                            0;
                    }

                    
                    dat2.Cel3 += dat3;
                }
            }
            catch
            {
                throw;
            }
            finally 
            {
                ope.Close();
            }
        }

        
        
        
        private void Amo2()
        {
            
            dat2.Cel3 -= dat3;            

            
            if (dat2[Uni.Ind, dat2.Cur.Row3].Value != null)
            {
                Tot2();
            }
            
            else
            {
                
                dat2[Tax2.Ind, dat2.Cur.Row3].Value = 0;
            }

            
            dat2.Cel3 += dat3;
        }

        
        
        
        private void Tot2() 
        {
            int Uni3;
            int Qua2;

            
            if (dat2.Cur.Value == null) 
            {
                
                dat2.Cur.Value = 0;
            }

            
            if (int.TryParse(
                dat2[Uni.Ind, dat2.Cur.Row3].Value.ToString(),
                out Uni3) &&
                int.TryParse(
                    dat2[Qua.Ind, dat2.Cur.Row3].Value.ToString(),
                    out Qua2))
            {
                
                dat2[Tax2.Ind, dat2.Cur.Row3].Value =
                    Uni3 * Qua2;
            }

            
            int tax4 = Tot();

            
            Foo(tax4);
        }

        
        
        
        
        private int Tot()
        {
            
            
            int sum = 0;
            foreach (Dat11 row in dat2.Rows)
            {
                
                if (row.Vis3 && row.Cel2[Tax2.Ind].Value != null)
                {
                    sum += int.Parse(row.Cel2[Tax2.Ind].Value.ToString());
                }
            }
            
            lab2.Tex = sum.ToString();
            return sum;
        }

        
        
        
        private void Reg()
        {            
            
            string sal3 = Cre8();

            
            List<string>lis = Cre9();

            
            try
            {
                ope.Con4();
                ope.Tra();
                ope.Exe2(sal3);
                foreach (string dat8 in lis ) 
                {
                    ope.Exe2(dat8);
                }                    
                ope.Commit();
                Mes.Sho("登録し2。");
                this.Close();
                
                Pro = true;
            }
            catch
            {
                ope.Rol();
                throw;
            }
            finally
            {
                ope.Close();
            }
        }

        
        
        
        private string Cre8()
        {
            
            int sum = 0;
            foreach (Dat11 row in dat2.Rows)
            {
                
                sum += int.Parse(row.Cel2[Tax2.Ind].Value.ToString());
            }

            
            string sal3 = Que.Cre10(
                lab7.Tex,
                com.Sel.ToString(),
                com2.Sel.ToString(),
                tex.Tex,
                sum.ToString(),
                dat7.Value.ToS(),
                tex2.Tex);
            return sal3;
        }

        
        
        
        private List <string> Cre9() 
        {
            
            List<string> lis = new List<string>();

            foreach (Dat11 row in dat2.Rows)
            {
                
                string sal4 = Que.Cre9(
                    lab7.Tex,
                    row.Cel2[Det.Ind].Value.ToString(),
                    row.Cel2[Ite.Ind].Value.ToString(),
                    row.Cel2[Qua.Ind].Value.ToString(),
                    row.Cel2[Tax2.Ind].Value.ToString());

                lis.Add(sal4);
            }
            return lis;
        }

        
        
        
        private void Edi()
        {
            
            string sal5 = Cre11();

            
            List<string>lis = Upd();

            
            try
            {
                ope.Con4();
                ope.Tra();
                ope.Exe2(sal5);
                foreach (string dat8 in lis)
                {
                    ope.Exe2(dat8);
                }
                ope.Commit();
                Mes.Sho("更新し2。");
                this.Close();
                
                Pro = true;
            }
            catch
            {
                ope.Rol();
                throw;
            }
            finally
            {
                ope.Close();
            }            
        }

        
        
        
        private string Cre11()
        {
            
            int sum = 0;
            foreach (Dat11 row in dat2.Rows)
            {
                
                sum += int.Parse(row.Cel2[Tax2.Ind].Value.ToString());
            }

            
            string sal5 = Que.Cre12(
                sal,
                com.Sel.ToString(),
                com2.Sel.ToString(),
                tex.Tex,
                sum.ToString(),
                dat7.Value.ToS(),
                tex2.Tex);
            return sal5;
        }

        
        
        
        private List<string> Upd()
        {
            
            List<string>lis = new List<string>();

            
            foreach (Dat11 row in dat2.Rows)
            {
                
                string sal4 = null;
                string sal6 = null;
                string sal7 = null;

                
                switch (int.Parse(row.Cel2[Sta2.Ind].Value.ToString()))
                {
                    case STA.ADD:
                        
                        sal4 = Que.Cre9(
                        lab7.Tex,
                        row.Cel2[Det.Ind].Value.ToString(),
                        row.Cel2[Ite.Ind].Value.ToString(),
                        row.Cel2[Qua.Ind].Value.ToString(),
                        row.Cel2[Tax2.Ind].Value.ToString());

                        lis.Add(sal4);
                        break;

                    case STA.EDI:
                        
                        sal6 = Que.Cre13(
                        lab7.Tex,
                        row.Cel2[Det.Ind].Value.ToString(),
                        row.Cel2[Ite.Ind].Value.ToString(),
                        row.Cel2[Qua.Ind].Value.ToString(),
                        row.Cel2[Tax2.Ind].Value.ToString(),
                        tex2.Tex);

                        lis.Add(sal6);
                        break;

                    case STA.DEL3:
                        
                        sal7 = Que.Cre14(
                        lab7.Tex,
                        row.Cel2[Det.Ind].Value.ToString());

                        lis.Add(sal7);
                        break;
                }                
            }
            return lis;
        }
                
        
        
        
        private void Del()
        {
            
            List<string> lis = new List<string>();

            
            string sal8 = Que.Cre15(lab7.Tex);
                
            
            string sal7 = Que.Cre16(
                lab7.Tex);                

            
            try
            {
                ope.Con4();
                ope.Tra();
                ope.Exe2(sal8);
                ope.Exe2(sal7);
                ope.Commit();
                Mes.Sho("削除し2。");
                this.Close();
                
                Pro = true;
            }
            catch
            {
                ope.Rol();
                throw;
            }
            finally
            {
                ope.Close();
            }            
        }        

        
        
        
        private bool Bef()
        {
            
            if (dat2.Rows.Count <= 0)
            {
                Mes.Sho("明細を。");
                but7.Foc();
                return false;
            }
            
            if (com.Sel2 == COM.BLA)
            {
                Mes.Sho("担当者。");
                com.Foc();
                return false;
            }
            
            if (com2.Sel2 == COM.BLA)
            {
                Mes.Sho("顧客を。");
                com2.Foc();
                return false;
            }
            
            if (tex.Tex == "")
            {
                Mes.Sho("件名を。");
                tex.Foc();
                return false;
            }

            foreach (Dat11 row in dat2.Rows)
            {
                
                if (row.Cel2[Ite.Ind].Value == null)
                {
                    Mes.Sho("商品を。");
                    row.Cel2[Ite.Ind].Sel5 = true;
                    return false;
                }

                
                if (row.Cel2[Qua.Ind].Value == null || row.Cel2[Qua.Ind].Value.ToString() == "0")
                {
                    Mes.Sho("数量を。");
                    row.Cel2[Qua.Ind].Sel5 = true;
                    return false;
                }
            }     
            return true;
        }

        
        
        
        private void Tax() 
        {
            
            DateTime sal9 = dat7.Value;

            
            foreach (DataRow row in dtT.Rows)
            {
                DateTime sta2 = (DateTime)row[DAT.STA2];
                DateTime end = (DateTime)row[DAT.END];

                
                if (sal9 >= sta2 && sal9 <= end)
                {
                    
                    tax = (int)row[DAT.TAX2];
                }
            }
        }
    }
}
