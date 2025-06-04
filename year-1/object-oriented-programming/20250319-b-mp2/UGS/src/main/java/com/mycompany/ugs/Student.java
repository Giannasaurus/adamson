/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.ugs;

/**
 *
 * @author wugg
 */
public class Student {
    public String name="", id="";
    
    public Student() {
        
    }
    
    public Student(String n, String i) {
        name=n;
        id=i;
    }
    
    public String getGrade(double marks) {
        if (marks<=100 && marks>=97) {
            return "A";
        } else if (marks<=96 && marks>=93) {
            return "A-";
        } else if (marks<=92 && marks>=89) {
            return "B+";
        } else if (marks<=88 && marks>=85) {
            return "B";
        } else if (marks<=84 && marks>=82) {
            return "B-";
        } else if (marks<=81 && marks>=79) {
            return "C+";
        } else if (marks<=78 && marks>=76) {
            return "C";
        } else if (marks<=75 && marks>=73) {
            return "C-";
        } else if (marks<=72 && marks>=70) {
            return "D";
        } else {
            return "FAILED";
        }
    }
    
    public void calculateGrade(int marks) {
        System.out.println("Student: "+name+"(ID: S"+id+") Grade: "+getGrade(marks));
    }
    
    public void calculateGrade(int marks1, int marks2) {
        double avg = (marks1+marks2)/2;
        System.out.println("Student: "+name+"(ID: S"+id+") Average Grade: "+getGrade(avg));
    }
    
    public void calculateGrade(int marks1, int marks2, int marks3) {
        double avg = (marks1+marks2+marks3)/3;
        System.out.println("Student: "+name+"(ID: S"+id+") Average Grade: "+getGrade(avg));
    }
}
