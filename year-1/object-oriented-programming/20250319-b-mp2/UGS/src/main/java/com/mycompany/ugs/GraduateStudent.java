/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.ugs;

/**
 *
 * @author wugg
 */
public class GraduateStudent extends Student {
    public int thesisScore;
    
    public GraduateStudent(String n, String i, int ts) {
        this.name=n;
        this.id=i;
        thesisScore=ts;
    }
    
    public void calculateGrade() {
        System.out.println("Graduate Student: "+name+"(ID: G"+id+") Thesis Grade: "+getGrade(thesisScore));
    }
    
    public void calculateGrade(int marks1, int marks2, int marks3, int ts) {
        double avg = (marks1+marks2+marks3+ts)/4;
        System.out.println("Graduate Student: "+name+"(ID: G"+id+") Final Grade: "+getGrade(avg));
    }
}
