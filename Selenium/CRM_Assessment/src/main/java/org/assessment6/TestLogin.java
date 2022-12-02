package org.assessment6;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

public class TestLogin {

    public static void main(String[] args) throws InterruptedException {

        String url = "http://localhost:3000/";
        System.setProperty("webdriver.chrome.driver", "C:\\Users\\Cristina.Guzman\\Downloads\\Bootcamp\\Proyectos\\Assessment 6_28NOV\\Proyecto Visual 02_12 + FrontEnd\\Selenium\\chromedriver.exe");

        // initialize browser
        WebDriver driver = new ChromeDriver();

        //Open the website
        driver.get(url);

        //maximize the webbrowser
        driver.manage().window().maximize();

        //keys
        String email = "crisprueba@prueba.es";
        String password = "Probando11";


        WebElement emailInput = driver.findElement(By.className("username"));
        WebElement passwordInput = driver.findElement(By.className("password"));
        WebElement loginBtn = driver.findElement(By.className("btnLogin"));

        emailInput.sendKeys(email);
        passwordInput.sendKeys(password);
        loginBtn.click();
        Thread.sleep(3000);
        loginBtn.click();

    }

}
