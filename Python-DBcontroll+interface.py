
from tkinter import *
import sqlite3

ninput=None
agelabel=None
i=0

#a번
conn = sqlite3.connect('mydb')
cursor = conn.cursor()
cursor.execute("create table pinfo (id int, age int, name varchar(20))")
conn.commit 

#d번
def homeRec():
    print('처음')
    cursor.execute("select age,name from pinfo where id=1")
    conn.commit
    row=cursor.fetchone()
    age=row[0]
    name=row[1]
    agelabel.delete(0, len(agelabel.get()))
    agelabel.insert(0,age)
    ninput.delete(0, len(ninput.get()))
    ninput.insert(0,name)

#d번                 
def prevRec():
    try:
        print('이전')
        a=int(agelabel.get())
        cursor.execute("select id from pinfo where age={0}".format(a))
        conn.commit
        row=cursor.fetchone()
        b=row[0]-1 

        cursor.execute("select age,name from pinfo where id={0}".format(b))
        conn.commit
        row=cursor.fetchone()
        age=row[0]
        name=row[1]
        agelabel.delete(0, len(agelabel.get()))
        agelabel.insert(0,age)
        ninput.delete(0, len(ninput.get()))
        ninput.insert(0,name)
    except TypeError:
        print('가장 첫번째 데이터 입니다.')

#d번
def nextRec():
    try:
        print('다음')
        a=int(agelabel.get())
        cursor.execute("select id from pinfo where age={0}".format(a))
        conn.commit
        row=cursor.fetchone()
        b=row[0]+1 

        cursor.execute("select age,name from pinfo where id={0}".format(b))
        conn.commit
        row=cursor.fetchone()
        age=row[0]
        name=row[1]
        agelabel.delete(0, len(agelabel.get()))
        agelabel.insert(0,age)
        ninput.delete(0, len(ninput.get()))
        ninput.insert(0,name)
    except TypeError:
        print('가장 마지막 데이터 입니다.')

#d번
def endRec():
    print('끝')
    cursor.execute("select * from pinfo")
    conn.commit
    row=cursor.fetchall()
    r=len(row)
    
    cursor.execute("select age,name from pinfo where id={0}".format(r))
    conn.commit
    row=cursor.fetchone()
    age=row[0]
    name=row[1]
    agelabel.delete(0, len(agelabel.get()))
    agelabel.insert(0,age)
    ninput.delete(0, len(ninput.get()))
    ninput.insert(0,name)

#e번
def findProg():
    try:
        n=ninput.get()
        cursor.execute("select age from pinfo where name='{0}'".format(n))
        conn.commit
        row=cursor.fetchone()
        find=int(row[0])
        agelabel.delete(0, len(agelabel.get()))
        agelabel.insert(0,find)
        print('찾기 완료')
    except TypeError:
        print('존재하지 않는 이름입니다.')

#f번    
def insertProg():
    try:
        global i
        i+=1
        name=ninput.get()
        age=int(agelabel.get())
        cursor.execute("insert into pinfo values({0}, {1}, '{2}')".format(i,age,name))
        conn.commit
        print('삽입 완료')
    except ValueError:
        print('나이는 숫자만 가능합니다.')

#g번
def updateProg():
    try:
        name=ninput.get()
        age=int(agelabel.get())
        cursor.execute("update pinfo set age={0} where name='{1}'".format(age,name))
        conn.commit
        print('변경 완료')
    except ValueError:
        print('나이는 숫자만 가능합니다.')

#h번
def exitProg():
    print('프로그램 종료')
    exit()

    
def mkNameFrame():
    global ninput
    Label(nameFrame, text='이름 :', width=10).pack(side=LEFT)
    ninput = Entry(nameFrame, width=20)
    ninput.pack(side=LEFT)
   
#b번
def mkAgeFrame():
    global agelabel
    Label(ageFrame, text='나이 :', width=10).pack(side=LEFT)
    agelabel = Entry(ageFrame, width=20,bg='yellow') 
    agelabel.pack(side=LEFT)

#c번
    cursor.execute("select * from pinfo")
    conn.commit
    row=cursor.fetchall()
    if len(row)>0:
        homeRec() 
    else:
        print('저장된 데이터가 없습니다.')
        

def mkNaviFrame():
    Button(naviFrame,text='<<',width=7,command=homeRec).pack(side=LEFT)
    Button(naviFrame,text='<',width=7,command=prevRec).pack(side=LEFT)
    Button(naviFrame,text='>',width=7,command=nextRec).pack(side=LEFT)
    Button(naviFrame,text='>>',width=7,command=endRec).pack(side=LEFT)

def mkBtnFrame():
    Button(btnFrame,text=' FIND ',width=7,command=findProg).pack(side=LEFT)
    Button(btnFrame,text='INSERT',width=7,command=insertProg).pack(side=LEFT)    
    Button(btnFrame,text='UPDATE',width=7,command=updateProg).pack(side=LEFT)
    Button(btnFrame,text=' EXIT ',width=7,command=exitProg).pack(side=LEFT)



basewin = Tk()
basewin.geometry('355x160')
basewin.title('Testing Window')


nameFrame = Frame(basewin)
ageFrame = Frame(basewin)
naviFrame = Frame(basewin)
btnFrame = Frame(basewin)

mkNameFrame()
mkAgeFrame()

mkNaviFrame()
mkBtnFrame()

nameFrame.pack(pady=3)
ageFrame.pack(pady=3)
naviFrame.pack(pady=3)
btnFrame.pack(pady=3)






basewin.mainloop()
conn.close()
