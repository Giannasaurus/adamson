/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.ugs;

/**
 *
 * @author wugg
 */
public class UGS {
    public static void main(String[] args) {
        Student student1 = new Student("Gianna", "123");
        Student student2 = new Student("Ysabelle", "456");
        Student student3 = new Student("Cedrick", "789");
        
        student1.calculateGrade(75);
        student2.calculateGrade(85, 95);
        student3.calculateGrade(90, 80, 85);
        
        GraduateStudent gradStudent1 = new GraduateStudent("Paul", "000", 88);
        gradStudent1.calculateGrade();
        gradStudent1.calculateGrade(85, 75, 90, 95);
    }
}
